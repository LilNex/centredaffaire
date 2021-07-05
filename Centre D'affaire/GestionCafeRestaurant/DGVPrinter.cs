using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Diagnostics;



namespace DGVPrinterHelper //AllocationRequest
{    
    #region Supporting Classes

    /// <summary>
    /// Setup and implements logs for internal logging
    /// </summary>
    class LogManager
    {
        /// <summary>
        /// Path to log file
        /// </summary>
        private String basepath;
        public String BasePath
        {
            get { return basepath; }
            set { basepath = value; }
        }

        /// <summary>
        /// Header for log file name
        /// </summary>
        private String logheader;
        public String LogNameHeader
        {
            get { return logheader; }
            set { logheader = value; }
        }

        private int useFrame = 1;

        /// <summary>
        /// Define logging message categories
        /// </summary>
        public enum Categories
        {
            Info = 1,
            Warning,
            Error,
            Exception
        }

        /// <summary>
        /// Constructor, allow user to override path and name of logging file
        /// </summary>
        /// <param name="userbasepath"></param>
        /// <param name="userlogname"></param>
        public LogManager(String userbasepath, String userlogname)
        {
            BasePath = String.IsNullOrEmpty(userbasepath) ? "." : userbasepath;
            LogNameHeader = String.IsNullOrEmpty(userlogname) ? "MsgLog" : userlogname;

            Log(Categories.Info, "********************* New Trace *********************");
        }

        /// <summary>
        /// Log a message, using the provided category
        /// </summary>
        /// <param name="category"></param>
        /// <param name="msg"></param>
        public void Log(Categories category, String msg)
        {
            // get call stack
            StackTrace stackTrace = new StackTrace();

            // get calling method name
            String caller = stackTrace.GetFrame(useFrame).GetMethod().Name;

            // log it
            LogWriter.Write(caller, category, msg, BasePath, LogNameHeader);

            // reset frame pointer
            useFrame = 1;
        }

        /// <summary>
        /// Log an informational message
        /// </summary>
        /// <param name="msg"></param>
        public void LogInfoMsg(String msg)
        {
            useFrame++; // bump up the stack frame pointer to skip this entry
            Log(Categories.Info, msg);
        }

        /// <summary>
        /// Log an error message
        /// </summary>
        /// <param name="msg"></param>
        public void LogErrorMsg(String msg)
        {
            useFrame++; // bump up the stack frame pointer to skip this entry
            Log(Categories.Error, msg);
        }

        /// <summary>
        /// Log an exception
        /// </summary>
        /// <param name="ex"></param>
        public void Log(Exception ex)
        {
            useFrame++; // bump up the stack frame pointer to skip this entry
            Log(Categories.Exception, String.Format("{0} from {1}", ex.Message, ex.Source));
        }
    }

    /// <summary>
    /// Do the actual log writing using setup info in Log Manager class
    /// </summary>
    class LogWriter
    {
        /// <summary>
        /// Create standard log file name with "our" name format
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static String LogFileName(String name)
        {
            return String.Format("{0}_{1:yyyyMMdd}.Log", name, DateTime.Now);
        }

        /// <summary>
        /// Write the log entry to the file. Note that the log file is always flushed and closed. This
        /// will impact performance, but ensures that messages aren't lost
        /// </summary>
        /// <param name="from"></param>
        /// <param name="category"></param>
        /// <param name="msg"></param>
        /// <param name="path"></param>
        /// <param name="name"></param>
        public static void Write(String from, LogManager.Categories category, String msg, String path, String name)
        {
            StringBuilder line = new StringBuilder();
            line.Append(DateTime.Now.ToShortDateString().ToString());
            line.Append("-");
            line.Append(DateTime.Now.ToLongTimeString().ToString());
            line.Append(", ");
            line.Append(category.ToString().PadRight(6, ' '));
            line.Append(",");
            line.Append(from.PadRight(13, ' '));
            line.Append(",");
            line.Append(msg);
            StreamWriter w = new StreamWriter(path + "\\" + LogFileName(name), true);
            w.WriteLine(line.ToString());
            w.Flush();
            w.Close();
        }
    }

    /// <summary>
    /// Class for the ownerdraw event. Provide the caller with the cell data, the current
    /// graphics context and the location in which to draw the cell.
    /// </summary>
    public class DGVCellDrawingEventArgs : EventArgs
    {
        public Graphics g;
        public RectangleF DrawingBounds;
        public DataGridViewCellStyle CellStyle;
        public int row;
        public int column;
        public Boolean Handled;

        public DGVCellDrawingEventArgs(Graphics g, RectangleF bounds, DataGridViewCellStyle style,
            int row, int column)
            : base()
        {
            this.g = g;
            DrawingBounds = bounds;
            CellStyle = style;
            this.row = row;
            this.column = column;
            Handled = false;
        }
    }

    /// <summary>
    /// Delegate for ownerdraw cells - allow the caller to provide drawing for the cell
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void CellOwnerDrawEventHandler(object sender, DGVCellDrawingEventArgs e);

    /// <summary>
    /// Hold Extension methods
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Extension method to print all the "ImbeddedImages" in a provided list
        /// </summary>
        /// <typeparam name="?"></typeparam>
        /// <param name="list"></param>
        /// <param name="g"></param>
        /// <param name="pagewidth"></param>
        /// <param name="pageheight"></param>
        /// <param name="margins"></param>
        public static void DrawImbeddedImage<T>(this IEnumerable<T> list,
            Graphics g, int pagewidth, int pageheight, Margins margins)
        {
            foreach (T t in list)
            {
                if (t is DGVPrinter.ImbeddedImage)
                {
                    DGVPrinter.ImbeddedImage ii = (DGVPrinter.ImbeddedImage)Convert.ChangeType(t, typeof(DGVPrinter.ImbeddedImage));
                    // Fix - DrawImageUnscaled was actually scaling the images!!?! Oh well...
                    //g.DrawImageUnscaled(ii.theImage, ii.upperleft(pagewidth, pageheight, margins));
                    g.DrawImage(ii.theImage,
                        new Rectangle(ii.upperleft(pagewidth, pageheight, margins),
                        new Size(ii.theImage.Width, ii.theImage.Height)));
                }
            }
        }

    }
    
    #endregion

    
    public class DGVPrinter
    {
        public enum Alignment { NotSet, Left, Right, Center }
        public enum Location { Header, Footer, Absolute }
        public enum SizeType { CellSize, StringSize, Porportional }
        public enum PrintLocation { All, FirstOnly, LastOnly, None }

        //---------------------------------------------------------------------
        // internal classes/structs
        //---------------------------------------------------------------------
        #region Internal Classes

        // Identify the reason for a new page when tracking rows
        enum paging { keepgoing, outofroom, datachange };

        // Allow the user to provide images that will be printed as either logos in the
        // header and/or footer or watermarked as in printed behind the text.
        public class ImbeddedImage
        {
            public Image theImage { get; set; }
            public Alignment ImageAlignment { get; set; }
            public Location ImageLocation { get; set; }
            public Int32 ImageX { get; set; }
            public Int32 ImageY { get; set; }

            internal Point upperleft(int pagewidth, int pageheight, Margins margins)
            {
                int y = 0;
                int x = 0;

                // if we've been given an absolute location, just use it
                if (ImageLocation == Location.Absolute)
                    return new Point(ImageX, ImageY);

                // set the y location based on header or footer
                switch (ImageLocation)
                {
                    case Location.Header:
                        y = margins.Top;
                        break;
                    case Location.Footer:
                        y = pageheight - theImage.Height - margins.Bottom;
                        break;
                    default:
                        throw new ArgumentException(String.Format("Unkown value: {0}", ImageLocation));
                }

                // set the x location based on left,right,center
                switch (ImageAlignment)
                {
                    case Alignment.Left:
                        x = margins.Left;
                        break;
                    case Alignment.Center:
                        x = (int)(pagewidth / 2 - theImage.Width / 2) + margins.Left;
                        break;
                    case Alignment.Right:
                        x = (int)(pagewidth - theImage.Width) + margins.Left;
                        break;
                    case Alignment.NotSet:
                        x = ImageX;
                        break;
                    default:
                        throw new ArgumentException(String.Format("Unkown value: {0}", ImageAlignment));
                }

                return new Point(x, y);
            }
        }

        public IList<ImbeddedImage> ImbeddedImageList = new List<ImbeddedImage>();

        // handle wide-column printing - that is, lists of columns that extend
        // wider than one page width. Columns are broken up into "Page Sets" that
        // are printed one after another until all columns are printed.
        class PageDef
        {
            public PageDef(Margins m, int count, int pagewidth)
            {
                columnindex = new List<int>(count);
                colstoprint = new List<object>(count);
                colwidths = new List<float>(count);
                colwidthsoverride = new List<float>(count);
                coltotalwidth = 0;
                margins = (Margins)m.Clone();
                pageWidth = pagewidth;
            }

            public List<int> columnindex;
            public List<object> colstoprint;
            public List<float> colwidths;
            public List<float> colwidthsoverride;
            public float coltotalwidth;
            public Margins margins;
            private int pageWidth;

            public int printWidth
            {
                get { return pageWidth - margins.Left - margins.Right; }
            }
        }
        IList<PageDef> pagesets;
        int currentpageset = 0;

        // class to hold settings for the PrintDialog presented to the user during
        // the print process
        public class PrintDialogSettingsClass
        {
            public bool AllowSelection = true;
            public bool AllowSomePages = true;
            public bool AllowCurrentPage = true;
            public bool AllowPrintToFile = false;
            public bool ShowHelp = true;
            public bool ShowNetwork = true;
            public bool UseEXDialog = true;
        }

        // class to identify row data for printing
        public class rowdata
        {
            public DataGridViewRow row = null;
            public float height = 0;
            public bool pagebreak = false;
            public bool splitrow = false;
        }
        #endregion

        //---------------------------------------------------------------------
        // global variables
        //---------------------------------------------------------------------
        #region global variables

        // the data grid view we're printing
        DataGridView dgv = null;

        // print document
        PrintDocument printDoc = null;

        // logging 
        LogManager Logger = null;

        // print status items
        Boolean EmbeddedPrinting = false;
        List<rowdata> rowstoprint;
        IList colstoprint;          // divided into pagesets for printing
        int lastrowprinted = -1;
        int currentrow = -1;
        int fromPage = 0;
        int toPage = -1;
        const int maxPages = 2147483647;

        // page formatting options
        int pageHeight = 0;
        float staticheight = 0;
        float rowstartlocation = 0;
        int pageWidth = 0;
        int printWidth = 0;
        float rowheaderwidth = 0;
        int CurrentPage = 0;
        int totalpages;
        PrintRange printRange;

        // calculated values
        //private float headerHeight = 0;
        private float footerHeight = 0;
        private float pagenumberHeight = 0;
        private float colheaderheight = 0;
        //private List<float> rowheights;
        private List<float> colwidths;
        //private List<List<SizeF>> cellsizes;

        #endregion

        //---------------------------------------------------------------------
        // properties - settable by user
        //---------------------------------------------------------------------
        #region properties

        #region global properties

        /// <summary>
        /// Enable logging of of the print process. Default is to log to a file named
        /// 'DGVPrinter_yyyymmdd.Log' in the current directory. Since logging may have 
        /// an impact on performance, it should be used for troubleshooting purposes only.
        /// </summary>
        protected Boolean enablelogging;
        public Boolean EnableLogging
        {
            get { return enablelogging; }
            set 
            {
                enablelogging = value;
                if (enablelogging)
                {
                    Logger = new LogManager(".", "DGVPrinter");
                }
            }
        }

        /// <summary>
        /// Allow the user to change the logging directory. Setting this enables logging by default.
        /// </summary>
        public String LogDirectory
        {
            get 
            { 
                if (null != Logger) 
                    return Logger.BasePath; 
                else 
                    return null; 
            }
            set
            {
                if (null == Logger)
                    EnableLogging = true;
                Logger.BasePath = value;
            }
        }

        /// <summary>
        /// OwnerDraw Event declaration. Callers can subscribe to this event to override the 
        /// cell drawing.
        /// </summary>
        public event CellOwnerDrawEventHandler OwnerDraw;

        /// <summary>
        /// provide an override for the print preview dialog "owner" field
        /// Note: Changed style for VS2005 compatibility
        /// </summary>
        //public Form Owner
        //{ get; set; }
        protected Form _Owner = null;
        public Form Owner
        {
            get { return _Owner; }
            set { _Owner = value; }
        }

        /// <summary>
        /// provide an override for the print preview zoom setting
        /// Note: Changed style for VS2005 compatibility
        /// </summary>
        //public Double PrintPreviewZoom
        //{ get; set; }
        protected Double _PrintPreviewZoom = 1.0;
        public Double PrintPreviewZoom
        {
            get { return _PrintPreviewZoom; }
            set { _PrintPreviewZoom = value; }
        }


        /// <summary>
        /// expose printer settings to allow access to calling program
        /// </summary>
        public PrinterSettings PrintSettings
        {
            get { return printDoc.PrinterSettings; }
        }

        /// <summary>
        /// expose settings for the PrintDialog displayed to the user
        /// </summary>
        private PrintDialogSettingsClass printDialogSettings = new PrintDialogSettingsClass();
        public PrintDialogSettingsClass PrintDialogSettings
        {
            get { return printDialogSettings; }
        }

        /// <summary>
        /// Set Printer Name
        /// </summary>
        private String printerName;
        public String PrinterName
        {
            get { return printerName; }
            set { printerName = value; }
        }

        /// <summary>
        /// Allow access to the underlying print document
        /// </summary>
        public PrintDocument printDocument
        {
            get { return printDoc; }
            set { printDoc = value; }
        }

        /// <summary>
        /// Allow caller to set the upper-left corner icon used
        /// in the print preview dialog
        /// </summary>
        private Icon ppvIcon = null;
        public Icon PreviewDialogIcon
        {
            get { return ppvIcon; }
            set { ppvIcon = value; }
        }

        /// <summary>
        /// Allow caller to set print preview dialog
        /// </summary>
        private PrintPreviewDialog previewdialog = null;
        public PrintPreviewDialog PreviewDialog
        {
            get { return previewdialog; }
            set { previewdialog = value; }
        }

        /// <summary>
        /// Flag to control whether or not we print the Page Header
        /// </summary>
        private Boolean printHeader = true;
        public Boolean PrintHeader
        {
            get { return printHeader; }
            set { printHeader = value; }
        }

        /// <summary>
        /// Determine the height of the header
        /// </summary>
        private float HeaderHeight 
        {
            get
            {
                float headerheight = 0;

                // Add in title and subtitle heights - this is sensitive to 
                // wether or not titles are printed on the current page
                // TitleHeight and SubTitleHeight have their respective spacing
                // already included
                headerheight += TitleHeight+ SubTitleHeight;

                // Add in column header heights
                if ((bool)PrintColumnHeaders)
                {
                    headerheight += colheaderheight;
                }

                // return calculated height
                return headerheight;
            }
        }

        /// <summary>
        /// Flag to control whether or not we print the Page Footer
        /// </summary>
        private Boolean printFooter = true;
        public Boolean PrintFooter
        {
            get { return printFooter; }
            set { printFooter = value; }
        }

        /// <summary>
        /// Flag to control whether or not we print the Column Header line
        /// </summary>
        private Boolean? printColumnHeaders;
        public Boolean? PrintColumnHeaders
        {
            get { return printColumnHeaders; }
            set { printColumnHeaders = value; }
        }

        /// <summary>
        /// Flag to control whether or not we print the Column Header line
        /// Defaults to False to match previous functionality
        /// </summary>
        private Boolean? printRowHeaders = false; 
        public Boolean? PrintRowHeaders
        {
            get { return printRowHeaders; }
            set { printRowHeaders = value; }
        }

        /// <summary>
        /// Flag to control whether rows are printed whole or if partial
        /// rows should be printed to fill the bottom of the page. Turn this
        /// "Off" (i.e. false) to print cells/rows deeper than one page
        /// </summary>
        private Boolean keepRowsTogether = true;
        public Boolean KeepRowsTogether
        {
            get { return keepRowsTogether; }
            set { keepRowsTogether = value; }
        }

        /// <summary>
        /// How much of a row must show on the current page before it is 
        /// split when KeepRowsTogether is set to true.
        /// </summary>
        private float keeprowstogethertolerance = 15;
        public float KeepRowsTogetherTolerance
        {
            get { return keeprowstogethertolerance; }
            set { keeprowstogethertolerance = value; }
        }
        
        #endregion

        // Title
        #region title properties

        // override flag
        bool overridetitleformat = false;

        // formatted height of title
        float titleheight = 0;

        /// <summary>
        /// Title for this report. Default is empty.
        /// </summary>
        private String title;
        public String Title
        {
            get { return title; }
            set
            {
                title = value;
                if (docName == null)
                {
                    printDoc.DocumentName = value;
                }
            }
        }

        /// <summary>
        /// Name of the document. Default is report title (can be empty)
        /// </summary>
        private String docName;
        public String DocName
        {
            get { return docName; }
            set { printDoc.DocumentName = value; docName = value; }
        }

        /// <summary>
        /// Font for the title. Default is Tahoma, 18pt.
        /// </summary>
        private Font titlefont;
        public Font TitleFont
        {
            get { return titlefont; }
            set { titlefont = value; }
        }

        /// <summary>
        /// Foreground color for the title. Default is Black
        /// </summary>
        private Color titlecolor;
        public Color TitleColor
        {
            get { return titlecolor; }
            set { titlecolor = value; }
        }

        /// <summary>
        /// Allow override of the header cell format object
        /// </summary>
        private StringFormat titleformat;
        public StringFormat TitleFormat
        {
            get { return titleformat; }
            set { titleformat = value; overridetitleformat = true; }
        }

        /// <summary>
        /// Allow the user to override the title string alignment. Default value is 
        /// Alignment - Near; 
        /// </summary>
        public StringAlignment TitleAlignment
        {
            get { return titleformat.Alignment; }
            set
            {
                titleformat.Alignment = value;
                overridetitleformat = true;
            }
        }

        /// <summary>
        /// Allow the user to override the title string format flags. Default values
        /// are: FormatFlags - NoWrap, LineLimit, NoClip
        /// </summary>
        public StringFormatFlags TitleFormatFlags
        {
            get { return titleformat.FormatFlags; }
            set
            {
                titleformat.FormatFlags = value;
                overridetitleformat = true;
            }
        }

        /// <summary>
        /// Control where in the document the title prints
        /// </summary>
        private PrintLocation titleprint = PrintLocation.All;
        public PrintLocation TitlePrint
        {
            get { return titleprint; }
            set { titleprint = value; }
        }

        /// <summary>
        /// Return the title height based whether to print it or not
        /// </summary>
        private float TitleHeight
        {
            get
            {
                if (PrintLocation.All == TitlePrint)
                    return titleheight + titlespacing;

                if ((PrintLocation.FirstOnly == TitlePrint) && (1 == CurrentPage))
                    return titleheight + titlespacing;

                if ((PrintLocation.LastOnly == TitlePrint) && (totalpages == CurrentPage))
                    return titleheight + titlespacing;

                return 0;
            }
        }

        /// <summary>
        /// Mandatory spacing between the grid and the footer
        /// </summary>
        private float titlespacing;
        public float TitleSpacing
        {
            get { return titlespacing; }
            set { titlespacing = value; }
        }

        /// <summary>
        /// Title Block Background Color
        /// </summary>
        private Brush titlebackground;
        public Brush TitleBackground
        {
            get { return titlebackground; }
            set { titlebackground = value; }
        }

        /// <summary>
        /// Title Block Border
        /// </summary>
        private Pen titleborder;
        public Pen TitleBorder
        {
            get { return titleborder; }
            set { titleborder = value; }
        }

        #endregion

        // SubTitle
        #region subtitle properties

        // override flat
        bool overridesubtitleformat = false;

        // formatted height of subtitle
        float subtitleheight = 0;

        /// <summary>
        /// SubTitle for this report. Default is empty.
        /// </summary>
        private String subtitle;
        public String SubTitle
        {
            get { return subtitle; }
            set { subtitle = value; }
        }

        /// <summary>
        /// Font for the subtitle. Default is Tahoma, 12pt.
        /// </summary>
        private Font subtitlefont;
        public Font SubTitleFont
        {
            get { return subtitlefont; }
            set { subtitlefont = value; }
        }

        /// <summary>
        /// Foreground color for the subtitle. Default is Black
        /// </summary>
        private Color subtitlecolor;
        public Color SubTitleColor
        {
            get { return subtitlecolor; }
            set { subtitlecolor = value; }
        }

        /// <summary>
        /// Allow override of the header cell format object
        /// </summary>
        private StringFormat subtitleformat;
        public StringFormat SubTitleFormat
        {
            get { return subtitleformat; }
            set { subtitleformat = value; overridesubtitleformat = true; }
        }

        /// <summary>
        /// Allow the user to override the subtitle string alignment. Default value is 
        /// Alignment - Near; 
        /// </summary>
        public StringAlignment SubTitleAlignment
        {
            get { return subtitleformat.Alignment; }
            set
            {
                subtitleformat.Alignment = value;
                overridesubtitleformat = true;
            }
        }

        /// <summary>
        /// Allow the user to override the subtitle string format flags. Default values
        /// are: FormatFlags - NoWrap, LineLimit, NoClip
        /// </summary>
        public StringFormatFlags SubTitleFormatFlags
        {
            get { return subtitleformat.FormatFlags; }
            set
            {
                subtitleformat.FormatFlags = value;
                overridesubtitleformat = true;
            }
        }

        /// <summary>
        /// Control where in the document the title prints
        /// </summary>
        private PrintLocation subtitleprint = PrintLocation.All;
        public PrintLocation SubTitlePrint
        {
            get { return subtitleprint; }
            set { subtitleprint = value; }
        }

        /// <summary>
        /// Return the title height based whether to print it or not
        /// </summary>
        private float SubTitleHeight
        {
            get
            {
                if (PrintLocation.All == SubTitlePrint)
                    return subtitleheight + subtitlespacing;

                if ((PrintLocation.FirstOnly == SubTitlePrint) && (1 == CurrentPage))
                    return subtitleheight + subtitlespacing;

                if ((PrintLocation.LastOnly == SubTitlePrint) && (totalpages == CurrentPage))
                    return subtitleheight + subtitlespacing;

                return 0;
            }
        }

        /// <summary>
        /// Mandatory spacing between the grid and the footer
        /// </summary>
        private float subtitlespacing;
        public float SubTitleSpacing
        {
            get { return subtitlespacing; }
            set { subtitlespacing = value; }
        }

        /// <summary>
        /// Title Block Background Color
        /// </summary>
        private Brush subtitlebackground;
        public Brush SubTitleBackground
        {
            get { return subtitlebackground; }
            set { subtitlebackground = value; }
        }

        /// <summary>
        /// Title Block Border
        /// </summary>
        private Pen subtitleborder;
        public Pen SubTitleBorder
        {
            get { return subtitleborder; }
            set { subtitleborder = value; }
        }

        #endregion

        // Footer
        #region footer properties

        // override flag
        bool overridefooterformat = false;

        /// <summary>
        /// footer for this report. Default is empty.
        /// </summary>
        private String footer;
        public String Footer
        {
            get { return footer; }
            set { footer = value; }
        }

        /// <summary>
        /// Font for the footer. Default is Tahoma, 10pt.
        /// </summary>
        private Font footerfont;
        public Font FooterFont
        {
            get { return footerfont; }
            set { footerfont = value; }
        }

        /// <summary>
        /// Foreground color for the footer. Default is Black
        /// </summary>
        private Color footercolor;
        public Color FooterColor
        {
            get { return footercolor; }
            set { footercolor = value; }
        }

        /// <summary>
        /// Allow override of the header cell format object
        /// </summary>
        private StringFormat footerformat;
        public StringFormat FooterFormat
        {
            get { return footerformat; }
            set { footerformat = value; overridefooterformat = true; }
        }

        /// <summary>
        /// Allow the user to override the footer string alignment. Default value is 
        /// Alignment - Center; 
        /// </summary>
        public StringAlignment FooterAlignment
        {
            get { return footerformat.Alignment; }
            set
            {
                footerformat.Alignment = value;
                overridefooterformat = true;
            }
        }

        /// <summary>
        /// Allow the user to override the footer string format flags. Default values
        /// are: FormatFlags - NoWrap, LineLimit, NoClip
        /// </summary>
        public StringFormatFlags FooterFormatFlags
        {
            get { return footerformat.FormatFlags; }
            set
            {
                footerformat.FormatFlags = value;
                overridefooterformat = true;
            }
        }

        /// <summary>
        /// Mandatory spacing between the grid and the footer
        /// </summary>
        private float footerspacing;
        public float FooterSpacing
        {
            get { return footerspacing; }
            set { footerspacing = value; }
        }

        /// <summary>
        /// Control where in the document the title prints
        /// </summary>
        private PrintLocation footerprint = PrintLocation.All;
        public PrintLocation FooterPrint
        {
            get { return footerprint; }
            set { footerprint = value; }
        }

        /// <summary>
        /// Determine the height of the footer
        /// </summary>
        private float FooterHeight
        {
            get
            {
                float footerheight = 0;

                // return calculated height if we're printing the footer
                if ((PrintLocation.All == FooterPrint)
                    || ((PrintLocation.FirstOnly == FooterPrint) && (1 == CurrentPage))
                    || ((PrintLocation.LastOnly == FooterPrint) && (totalpages == CurrentPage)) )
                {
                    // Add in footer text height 
                    footerheight += footerHeight + FooterSpacing;
                }

                return footerheight;
            }
        }

        /// <summary>
        /// Title Block Background Color
        /// </summary>
        private Brush footerbackground;
        public Brush FooterBackground
        {
            get { return footerbackground; }
            set { footerbackground = value; }
        }

        /// <summary>
        /// Title Block Border
        /// </summary>
        private Pen footerborder;
        public Pen FooterBorder
        {
            get { return footerborder; }
            set { footerborder = value; }
        }

        #endregion

        // Page Numbering
        #region page number properties

        // override flag
        bool overridepagenumberformat = false;

        /// <summary>
        /// Include page number in the printout. Default is true.
        /// </summary>
        private bool pageno = true;
        public bool PageNumbers
        {
            get { return pageno; }
            set { pageno = value; }
        }

        /// <summary>
        /// Font for the page number, Default is Tahoma, 8pt.
        /// </summary>
        private Font pagenofont;
        public Font PageNumberFont
        {
            get { return pagenofont; }
            set { pagenofont = value; }
        }

        /// <summary>
        /// Text color (foreground) for the page number. Default is Black
        /// </summary>
        private Color pagenocolor;
        public Color PageNumberColor
        {
            get { return pagenocolor; }
            set { pagenocolor = value; }
        }

        /// <summary>
        /// Allow override of the header cell format object
        /// </summary>
        private StringFormat pagenumberformat;
        public StringFormat PageNumberFormat
        {
            get { return pagenumberformat; }
            set { pagenumberformat = value; overridepagenumberformat = true; }
        }

        /// <summary>
        /// Allow the user to override the page number string alignment. Default value is 
        /// Alignment - Near; 
        /// </summary>
        public StringAlignment PageNumberAlignment
        {
            get { return pagenumberformat.Alignment; }
            set
            {
                pagenumberformat.Alignment = value;
                overridepagenumberformat = true;
            }
        }

        /// <summary>
        /// Allow the user to override the pagenumber string format flags. Default values
        /// are: FormatFlags - NoWrap, LineLimit, NoClip
        /// </summary>
        public StringFormatFlags PageNumberFormatFlags
        {
            get { return pagenumberformat.FormatFlags; }
            set
            {
                pagenumberformat.FormatFlags = value;
                overridepagenumberformat = true;
            }
        }

        /// <summary>
        /// Allow the user to select whether to have the page number at the top or bottom
        /// of the page. Default is false: page numbers on the bottom of the page
        /// </summary>
        private bool pagenumberontop = false;
        public bool PageNumberInHeader
        {
            get { return pagenumberontop; }
            set { pagenumberontop = value; }
        }

        /// <summary>
        /// Should the page number be printed on a separate line, or printed on the
        /// same line as the header / footer? Default is false;
        /// </summary>
        private bool pagenumberonseparateline = false;
        public bool PageNumberOnSeparateLine
        {
            get { return pagenumberonseparateline; }
            set { pagenumberonseparateline = value; }
        }

        /// <summary>
        /// Show the total page number as n of total 
        /// </summary>
        private bool showtotalpagenumber = false;
        public bool ShowTotalPageNumber
        {
            get { return showtotalpagenumber; }
            set { showtotalpagenumber = value; }
        }

        /// <summary>
        /// Text separating page number and total page number. Default is ' of '.
        /// </summary>
        private String pageseparator = " of ";
        public String PageSeparator
        {
            get { return pageseparator; }
            set { pageseparator = value; }
        }

        private String pagetext = "Page ";
        public String PageText
        {
            get { return pagetext; }
            set { pagetext = value; }
        }

        private String parttext = " - Part ";
        public String PartText
        {
            get { return parttext; }
            set { parttext = value; }
        }

        /// <summary>
        /// Control where in the document the title prints
        /// </summary>
        private PrintLocation pagenumberprint = PrintLocation.All;
        public PrintLocation PageNumberPrint
        {
            get { return pagenumberprint; }
            set { pagenumberprint = value; }
        }

        /// <summary>
        /// Determine the height of the footer
        /// </summary>
        private float PageNumberHeight
        {
            get
            {
                // return calculated height if we're printing the footer
                if ((PrintLocation.All == PageNumberPrint)
                    || ((PrintLocation.FirstOnly == PageNumberPrint) && (1 == CurrentPage))
                    || ((PrintLocation.LastOnly == PageNumberPrint) && (totalpages == CurrentPage)))
                {
                    // return page number height if we're printing it on a separate line
                    // if we're not printing on a separate line, but we're suppressing the
                    // header or footer then we still need to reserve space for the page number
                    if (pagenumberonseparateline)
                        return pagenumberHeight;
                    else if (pagenumberontop && 0 == TitleHeight && 0 == SubTitleHeight)
                    {
                        return pagenumberHeight;
                    }
                    else if (!pagenumberontop && 0 == FooterHeight)
                    {
                        return footerspacing + pagenumberHeight;
                    }
                }

                return 0;
            }
        }

        #endregion

        // Header Cell Printing 
        #region header cell properties

        private DataGridViewCellStyle rowheaderstyle;
        public DataGridViewCellStyle RowHeaderCellStyle
        {
            get { return rowheaderstyle; }
            set { rowheaderstyle = value; }
        }

        /// <summary>
        /// Allow override of the row header cell format object
        /// </summary>
        private StringFormat rowheadercellformat = null;
        public StringFormat GetRowHeaderCellFormat(DataGridView grid)
        {
            // get default values from provided data grid view, but only
            // if we don't already have a header cell format
            if ((null != grid) && (null == rowheadercellformat))
            {
                buildstringformat(ref rowheadercellformat, grid.Rows[0].HeaderCell.InheritedStyle,
                    headercellalignment, StringAlignment.Near, headercellformatflags,
                    StringTrimming.Word);
            }

            // if we still don't have a header cell format, create an empty
            if (null == rowheadercellformat)
                rowheadercellformat = new StringFormat(headercellformatflags);

            return rowheadercellformat;
        }

        /// <summary>
        /// Default value to show in the row header cell if no value is provided in the DataGridView.
        /// Defaults to one tab space
        /// </summary>
        private String rowheadercelldefaulttext = "\t";
        public String RowHeaderCellDefaultText
        {
            get { return rowheadercelldefaulttext; }
            set { rowheadercelldefaulttext = value; }
        }

        /// <summary>
        /// Allow override of the header cell format object
        /// </summary>
        private Dictionary<string, DataGridViewCellStyle> columnheaderstyles =
            new Dictionary<string, DataGridViewCellStyle>();
        public Dictionary<string, DataGridViewCellStyle> ColumnHeaderStyles
        {
            get { return columnheaderstyles; }
        }

        /// <summary>
        /// Allow override of the header cell format object
        /// </summary>
        private StringFormat columnheadercellformat = null;
        public StringFormat GetColumnHeaderCellFormat(DataGridView grid)
        {
            // get default values from provided data grid view, but only
            // if we don't already have a header cell format
            if ((null != grid) && (null == columnheadercellformat))
            {
                buildstringformat(ref columnheadercellformat, grid.Columns[0].HeaderCell.InheritedStyle,
                    headercellalignment, StringAlignment.Near, headercellformatflags,
                    StringTrimming.Word);
            }

            // if we still don't have a header cell format, create an empty
            if (null == columnheadercellformat)
                columnheadercellformat = new StringFormat(headercellformatflags);

            return columnheadercellformat;
        }

        /// <summary>
        /// Deprecated - use HeaderCellFormat
        /// Allow the user to override the header cell string alignment. Default value is 
        /// Alignment - Near; 
        /// </summary>
        private StringAlignment headercellalignment;
        public StringAlignment HeaderCellAlignment
        {
            get { return headercellalignment; }
            set { headercellalignment = value; }
        }

        /// <summary>
        /// Deprecated - use HeaderCellFormat
        /// Allow the user to override the header cell string format flags. Default values
        /// are: FormatFlags - NoWrap, LineLimit, NoClip
        /// </summary>
        private StringFormatFlags headercellformatflags;
        public StringFormatFlags HeaderCellFormatFlags
        {
            get { return headercellformatflags; }
            set { headercellformatflags = value; }
        }
        #endregion

        // Individual Cell Printing
        #region cell properties

        /// <summary>
        /// Allow override of the cell printing format
        /// </summary>
        private StringFormat cellformat = null;
        public StringFormat GetCellFormat(DataGridView grid)
        {
            // get default values from provided data grid view, but only
            // if we don't already have a cell format
            if ((null != grid) && (null == cellformat))
            {
                buildstringformat(ref cellformat, grid.Rows[0].Cells[0].InheritedStyle,
                    cellalignment, StringAlignment.Near, cellformatflags,
                    StringTrimming.Word);
            }

            // if we still don't have a cell format, create an empty
            if (null == cellformat)
                cellformat = new StringFormat(cellformatflags);

            return cellformat;
        }

        /// <summary>
        /// Deprecated - use GetCellFormat
        /// Allow the user to override the cell string alignment. Default value is 
        /// Alignment - Near; 
        /// </summary>
        private StringAlignment cellalignment;
        public StringAlignment CellAlignment
        {
            get { return cellalignment; }
            set { cellalignment = value; }
        }

        /// <summary>
        /// Deprecated - use GetCellFormat
        /// Allow the user to override the cell string format flags. Default values
        /// are: FormatFlags - NoWrap, LineLimit, NoClip
        /// </summary>
        private StringFormatFlags cellformatflags;
        public StringFormatFlags CellFormatFlags
        {
            get { return cellformatflags; }
            set { cellformatflags = value; }
        }

        /// <summary>
        /// allow the user to override the column width calcs with their own defaults
        /// </summary>
        private List<float> colwidthsoverride = new List<float>();
        private Dictionary<string, float> publicwidthoverrides = new Dictionary<string, float>();
        public Dictionary<string, float> ColumnWidths
        {
            get { return publicwidthoverrides; }
        }

        /// <summary>
        /// Allow per column style overrides
        /// </summary>
        private Dictionary<string, DataGridViewCellStyle> colstyles =
            new Dictionary<string, DataGridViewCellStyle>();
        public Dictionary<string, DataGridViewCellStyle> ColumnStyles
        {
            get { return colstyles; }
        }

        /// <summary>
        /// Allow per column style overrides
        /// </summary>
        private Dictionary<string, DataGridViewCellStyle> altrowcolstyles =
            new Dictionary<string, DataGridViewCellStyle>();
        public Dictionary<string, DataGridViewCellStyle> AlternatingRowColumnStyles
        {
            get { return altrowcolstyles; }
        }

        /// <summary>
        /// Allow the user to set columns that appear on every pageset. Only used when 
        /// the printout is wider than one page.
        /// </summary>
        private List<int> fixedcolumns = new List<int>();
        private List<string> fixedcolumnnames = new List<string>();
        public List<string> FixedColumns
        {
            get { return fixedcolumnnames; }
        }

        /// <summary>
        /// List of columns to not display in the grid view printout.
        /// </summary>
        private List<String> hidecolumns = new List<string>();
        public List<String> HideColumns
        {
            get { return hidecolumns; }
        }

        /// <summary>
        /// Insert a page break when the value in this column changes
        /// </summary>
        private object oldvalue = null;
        private String breakonvaluechange;
        public String BreakOnValueChange
        {
            get { return breakonvaluechange; }
            set { breakonvaluechange = value; }
        }

        #endregion

        // Page Level Properties
        #region page level properties

        /// <summary>
        /// Page margins override. Default is (60, 60, 40, 40)
        /// </summary>
        public Margins PrintMargins
        {
            get { return PageSettings.Margins; }
            set { PageSettings.Margins = value; }
        }

        /// <summary>
        /// Expose the printdocument default page settings to the caller
        /// </summary>
        public PageSettings PageSettings
        {
            get { return printDoc.DefaultPageSettings; }
        }

        /// <summary>
        /// Spread the columns porportionally accross the page. Default is false.
        /// Deprecated. Please use the ColumnWidth property
        /// </summary>
        private bool porportionalcolumns = false;
        public bool PorportionalColumns
        {
            get { return porportionalcolumns; }
            set 
            { 
                porportionalcolumns = value;
                if (porportionalcolumns)
                    ColumnWidth = ColumnWidthSetting.Porportional;
                else
                    ColumnWidth = ColumnWidthSetting.CellWidth;
            }
        }

        /// <summary>
        /// Center the table on the page. 
        /// </summary>
        private Alignment tablealignment = Alignment.NotSet;
        public Alignment TableAlignment
        {
            get { return tablealignment; }
            set { tablealignment = value; }
        }

        /// <summary>
        /// Change the default row height to either the height of the string or the size of 
        /// the cell. Added for image cell handling; set to CellHeight for image cells
        /// </summary>
        public enum RowHeightSetting { DataHeight, CellHeight }
        private RowHeightSetting _rowheight = RowHeightSetting.DataHeight;
        public RowHeightSetting RowHeight
        {
            get { return _rowheight; }
            set { _rowheight = value; }
        }

        /// <summary>
        /// Change the default column width to be spread porportionally accross the page,
        /// to the size of the grid cell or the size of the formatted data string.
        /// Set to CellWidth for image cells.
        /// </summary>
        public enum ColumnWidthSetting { DataWidth, CellWidth, Porportional }
        private ColumnWidthSetting _rowwidth = ColumnWidthSetting.CellWidth;
        public ColumnWidthSetting ColumnWidth
        {
            get { return _rowwidth; }
            set 
            {
                _rowwidth = value;
                if (value == ColumnWidthSetting.Porportional)
                    porportionalcolumns = true;
                else
                    porportionalcolumns = false;
            }
        }

        #endregion

        // Utility Functions
        #region
        /// <summary>
        /// calculate the print preview window width to show the entire page
        /// </summary>
        /// <returns></returns>
        private int PreviewDisplayWidth()
        {
            double displayWidth = printDoc.DefaultPageSettings.Bounds.Width
                + 3 * printDoc.DefaultPageSettings.HardMarginY;
            return (int)(displayWidth * PrintPreviewZoom);
        }

        /// <summary>
        /// calculate the print preview window height to show the entire page
        /// </summary>
        /// <returns></returns>
        private int PreviewDisplayHeight()
        {
            double displayHeight = printDoc.DefaultPageSettings.Bounds.Height
                + 3 * printDoc.DefaultPageSettings.HardMarginX;

            return (int)(displayHeight * PrintPreviewZoom);
        }

        /// <summary>
        /// Invoke any provided cell owner draw routines
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnCellOwnerDraw(DGVCellDrawingEventArgs e)
        {
            if (null != OwnerDraw)
                OwnerDraw(this, e);
        }

        /// <summary>
        /// Given a row and column, get the current grid cell style, including our local 
        /// overrides
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        protected DataGridViewCellStyle GetStyle(DataGridViewRow row, DataGridViewColumn col)
        {
            // set initial default
            DataGridViewCellStyle colstyle = row.Cells[col.Index].InheritedStyle.Clone();
            
            // check for our override
            if (ColumnStyles.ContainsKey(col.Name))
            {
                colstyle = ColumnStyles[col.Name];
            }

            // check for alternating row override
            if (0 != (row.Index & 1) && AlternatingRowColumnStyles.ContainsKey(col.Name))
            {
                colstyle = AlternatingRowColumnStyles[col.Name];
            }

            return colstyle;
        }

        /// <summary>
        /// Skim the colstoprint list for a column name and return it's index
        /// </summary>
        /// <param name="colname">Name of column to find</param>
        /// <returns>index of column</returns>
        protected int GetColumnIndex(string colname)
        {
            int i = 0;
            foreach (DataGridViewColumn col in colstoprint)
            {
                if (col.Name != colname)
                {
                    i++;
                }
                else
                {
                    break;
                }
            }

            // catch unknown column names
            if (i >= colstoprint.Count)
            {
                throw new Exception("Unknown Column Name: " + colname);
            }

            return i;
        }

        #endregion

        #endregion

        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------
        /// <summary>
        /// Constructor for DGVPrinter
        /// </summary>
        public DGVPrinter()
        {
            
            printDoc = new PrintDocument();
           
            PrintMargins = new Margins(60, 60, 40, 40);

           
            pagenofont = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            pagenocolor = Color.Black;
            titlefont = new Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point);
            titlecolor = Color.Black;
            subtitlefont = new Font("Tahoma", 12, FontStyle.Bold, GraphicsUnit.Point);
            subtitlecolor = Color.Black;
            footerfont = new Font("Tahoma", 10, FontStyle.Bold, GraphicsUnit.Point);
            footercolor = Color.Black;

            titlespacing = 0;
            subtitlespacing = 0;
            footerspacing = 0;

            
            buildstringformat(ref titleformat, null, StringAlignment.Center, StringAlignment.Center,
                StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip, StringTrimming.Word);
            buildstringformat(ref subtitleformat, null, StringAlignment.Center, StringAlignment.Center,
                StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip, StringTrimming.Word);
            buildstringformat(ref footerformat, null, StringAlignment.Center, StringAlignment.Center,
                StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip, StringTrimming.Word);
            buildstringformat(ref pagenumberformat, null, StringAlignment.Far, StringAlignment.Center,
                StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip, StringTrimming.Word);

            columnheadercellformat = null;
            rowheadercellformat = null;
            cellformat = null;

            
            Owner = null;
            PrintPreviewZoom = 1.0;

            
            headercellalignment = StringAlignment.Near;
            headercellformatflags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            cellalignment = StringAlignment.Near;
            cellformatflags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
        }


        /// <summary>
        /// Start the printing process, print to a printer.
        /// </summary>
        /// <param name="dgv">The DataGridView to print</param>
        /// NOTE: Any changes to this method also need to be done in PrintPreviewDataGridView
        public void PrintDataGridView(DataGridView dgv)
        {
            if (EnableLogging) Logger.LogInfoMsg("PrintDataGridView process started");
            if (null == dgv) throw new Exception("Null Parameter passed to DGVPrinter.");
            if (!(typeof(DataGridView).IsInstanceOfType(dgv)))
                throw new Exception("Invalid Parameter passed to DGVPrinter.");

            // save the datagridview we're printing
            this.dgv = dgv;
            
            // display dialog and print
            if (DialogResult.OK == DisplayPrintDialog())
            {
                PrintNoDisplay(dgv);
            }
        }

        /// <summary>
        /// Start the printing process, print to a print preview dialog
        /// </summary>
        /// <param name="dgv">The DataGridView to print</param>
        /// NOTE: Any changes to this method also need to be done in PrintDataGridView
        public void PrintPreviewDataGridView(DataGridView dgv)
        {
            if (EnableLogging) Logger.LogInfoMsg("PrintPreviewDataGridView process started");
            if (null == dgv) throw new Exception("Null Parameter passed to DGVPrinter.");
            if (!(typeof(DataGridView).IsInstanceOfType(dgv)))
                throw new Exception("Invalid Parameter passed to DGVPrinter.");

            // save the datagridview we're printing
            this.dgv = dgv;

            // display dialog and print
            if (DialogResult.OK == DisplayPrintDialog())
            {
                PrintPreviewNoDisplay(dgv);
            }
        }

        
        /// <summary>
        /// Display a printdialog and return the result. Either this method or 
        /// the equivalent must be done prior to calling either of the PrintNoDisplay
        /// or PrintPreviewNoDisplay methods.
        /// </summary>
        /// <returns></returns>
        public DialogResult DisplayPrintDialog()
        {
            if (EnableLogging) Logger.LogInfoMsg("DisplayPrintDialog process started");
           
            PrintDialog pd = new PrintDialog();
            pd.UseEXDialog = printDialogSettings.UseEXDialog;
            pd.AllowSelection = printDialogSettings.AllowSelection;
            pd.AllowSomePages = printDialogSettings.AllowSomePages;
            pd.AllowCurrentPage = printDialogSettings.AllowCurrentPage;
            pd.AllowPrintToFile = printDialogSettings.AllowPrintToFile;
            pd.ShowHelp = printDialogSettings.ShowHelp;
            pd.ShowNetwork = printDialogSettings.ShowNetwork;

            pd.Document = printDoc;
            if (!String.IsNullOrEmpty(printerName))
                printDoc.PrinterSettings.PrinterName = printerName;

            // show the dialog and display the result
            return pd.ShowDialog();
        }

        /// <summary>
        /// Print the provided grid view. Either DisplayPrintDialog() or it's equivalent
        /// setup must be completed prior to calling this routine
        /// </summary>
        /// <param name="dgv"></param>
        public void PrintNoDisplay(DataGridView dgv)
        {
            if (EnableLogging) Logger.LogInfoMsg("PrintNoDisplay process started");
            if (null == dgv) throw new Exception("Null Parameter passed to DGVPrinter.");
            if (!(dgv is DataGridView))
                throw new Exception("Invalid Parameter passed to DGVPrinter.");

            // save the grid we're printing
            this.dgv = dgv;

            printDoc.PrintPage += new PrintPageEventHandler(PrintPageEventHandler);
            printDoc.BeginPrint += new PrintEventHandler(BeginPrintEventHandler);

            // setup and do printing
            SetupPrint();
            printDoc.Print();
        }

        /// <summary>
        /// Preview the provided grid view. Either DisplayPrintDialog() or it's equivalent
        /// setup must be completed prior to calling this routine
        /// </summary>
        /// <param name="dgv"></param>
        public void PrintPreviewNoDisplay(DataGridView dgv)
        {
            if (EnableLogging) Logger.LogInfoMsg("PrintPreviewNoDisplay process started");
            if (null == dgv) throw new Exception("Null Parameter passed to DGVPrinter.");
            if (!(dgv is DataGridView))
                throw new Exception("Invalid Parameter passed to DGVPrinter.");

            // save the grid we're printing
            this.dgv = dgv;

            printDoc.PrintPage += new PrintPageEventHandler(PrintPageEventHandler);
            printDoc.BeginPrint += new PrintEventHandler(BeginPrintEventHandler);

            // display the preview dialog
            SetupPrint();

            // if the caller hasn't provided a print preview dialog, then create one
            if (null == PreviewDialog)
                PreviewDialog = new PrintPreviewDialog();

            // set up dialog for preview
            PreviewDialog.Document = printDoc;
            PreviewDialog.UseAntiAlias = true;
            PreviewDialog.Owner = Owner;
            PreviewDialog.PrintPreviewControl.Zoom = PrintPreviewZoom;
            PreviewDialog.Width = PreviewDisplayWidth();
            PreviewDialog.Height = PreviewDisplayHeight();

            if (null != ppvIcon)
                PreviewDialog.Icon = ppvIcon;

            // show the dialog
            PreviewDialog.ShowDialog();
        }


        public Boolean EmbeddedPrint(DataGridView dgv, Graphics g, Rectangle area)
        {
            if (EnableLogging) Logger.LogInfoMsg("EmbeddedPrint process started");
            
            if ((null == dgv))
                throw new Exception("Null Parameter passed to DGVPrinter.");
            EmbeddedPrinting = true;

            this.dgv = dgv;
            Margins saveMargins = PrintMargins;
            PrintMargins.Top = area.Top;
            PrintMargins.Bottom = 0;
            PrintMargins.Left = area.Left;
            PrintMargins.Right = 0;

            pageHeight = area.Height + area.Top;
            printWidth = area.Width;
            pageWidth = area.Width + area.Left;

            PrintHeader = false;
            PrintFooter = false;
            pageno = false;

           
            SetupPrint();

           
            return false;
        }

        public void EmbeddedPrintMultipageSetup(DataGridView dgv, Rectangle area)
        {
            if (EnableLogging) Logger.LogInfoMsg("EmbeddedPrintMultipageSetup process started");
            
            if ((null == dgv))
                throw new Exception("Null Parameter passed to DGVPrinter.");

            
            EmbeddedPrinting = true;

         
            this.dgv = dgv;
            Margins saveMargins = PrintMargins;
            PrintMargins.Top = area.Top;
            PrintMargins.Bottom = 0;
            PrintMargins.Left = area.Left;
            PrintMargins.Right = 0;

           
            pageHeight = area.Height + area.Top;
            printWidth = area.Width;
            pageWidth = area.Width + area.Left;

            
            PrintHeader = false;
            PrintFooter = false;
            pageno = false;

            
            SetupPrint();
        }

        /// <summary>
        /// BeginPrint Event Handler
        /// Set values at start of print run
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BeginPrintEventHandler(object sender, PrintEventArgs e)
        {
            if (EnableLogging) Logger.LogInfoMsg("BeginPrintEventHandler called. Printing started.");
            // reset counters since we'll go through this twice if we print from preview
            currentpageset = 0;
            lastrowprinted = -1;
            CurrentPage = 0;
        }

        /// <summary>
        /// PrintPage event handler. This routine prints one page. It will
        /// skip non-printable pages if the user selected the "some pages" option
        /// on the print dialog.
        /// </summary>
        /// <param name="sender">default object from windows</param>
        /// <param name="e">Event info from Windows about the printing</param>
        public void PrintPageEventHandler(object sender, PrintPageEventArgs e)
        {
            if (EnableLogging) Logger.LogInfoMsg("PrintPageEventHandler called. Printing a page.");
            e.HasMorePages = PrintPage(e.Graphics);
        }


       
        /// <summary>
        /// Set up the print job. Save information from print dialog
        /// and print document for easy access. Also sets up the rows
        /// and columns that will be printed. At this point, we're 
        /// collecting all columns in colstoprint. This will be broken
        /// up into pagesets later on 
        /// </summary>
        void SetupPrint()
        {
            if (EnableLogging)
            {
                Logger.LogInfoMsg("SetupPrint process started");
                var m = printDoc.DefaultPageSettings.Margins;
                Logger.LogInfoMsg(String.Format("Initial Printer Margins are {0}, {1}, {2}, {3}", m.Left, m.Right, m.Top, m.Bottom));
            }

            if (null == PrintColumnHeaders)
                PrintColumnHeaders = dgv.ColumnHeadersVisible;

            if (null == PrintRowHeaders)
                PrintRowHeaders = dgv.RowHeadersVisible;

           
            if ((null == RowHeaderCellStyle) && (0 != dgv.Rows.Count))
                RowHeaderCellStyle = dgv.Rows[0].HeaderCell.InheritedStyle;
            if (null == columnheadercellformat)
                buildstringformat(ref columnheadercellformat, dgv.Columns[0].HeaderCell.InheritedStyle,
                    headercellalignment, StringAlignment.Near, headercellformatflags,
                    StringTrimming.Word);
            if (null == rowheadercellformat)
                buildstringformat(ref rowheadercellformat, RowHeaderCellStyle,
                    headercellalignment, StringAlignment.Near, headercellformatflags,
                    StringTrimming.Word);
            if (null == cellformat)
                buildstringformat(ref cellformat, dgv.DefaultCellStyle,
                    cellalignment, StringAlignment.Near, cellformatflags,
                    StringTrimming.Word);


            if (!EmbeddedPrinting)
            {
                int printareawidth;
                int hardx = (int)Math.Round(printDoc.DefaultPageSettings.HardMarginX);
                int hardy = (int)Math.Round(printDoc.DefaultPageSettings.HardMarginY);
                if (printDoc.DefaultPageSettings.Landscape)
                    printareawidth = (int)Math.Round(printDoc.DefaultPageSettings.PrintableArea.Height);
                else
                    printareawidth = (int)Math.Round(printDoc.DefaultPageSettings.PrintableArea.Width);

                pageHeight = printDoc.DefaultPageSettings.Bounds.Height;
                pageWidth = printDoc.DefaultPageSettings.Bounds.Width;

               
                PrintMargins = printDoc.DefaultPageSettings.Margins;

                
                PrintMargins.Right = (hardx > PrintMargins.Right) ? hardx : PrintMargins.Right;
                PrintMargins.Left = (hardx > PrintMargins.Left) ? hardx : PrintMargins.Left;
                PrintMargins.Top = (hardy > PrintMargins.Top) ? hardy : PrintMargins.Top;
                PrintMargins.Bottom = (hardy > PrintMargins.Bottom) ? hardy : PrintMargins.Bottom;

                
                printWidth = pageWidth - PrintMargins.Left - PrintMargins.Right;
                printWidth = (printWidth > printareawidth) ? printareawidth : printWidth;

              
                if (EnableLogging)
                {
                    Logger.LogInfoMsg(String.Format("Printer 'Hard' X limit is {0} and 'Hard' Y limit is {1}", hardx, hardy));
                    Logger.LogInfoMsg(String.Format("Printer height limit is {0} and width limit is {1}, print width is {2}", 
                        pageHeight, pageWidth, printWidth));
                    Logger.LogInfoMsg(String.Format("Final overall margins are {0}, {1}, {2}, {3}",
                        PrintMargins.Left, PrintMargins.Right, PrintMargins.Top, PrintMargins.Bottom));
                    Logger.LogInfoMsg(String.Format("Table Alignment is {0}", TableAlignment.ToString()));
                }
            }

           
            printRange = printDoc.PrinterSettings.PrintRange;
            if (EnableLogging) Logger.LogInfoMsg(String.Format("PrintRange is {0}", printRange));

       
            if (PrintRange.SomePages == printRange)
            {
               
                fromPage = printDoc.PrinterSettings.FromPage;
                toPage = printDoc.PrinterSettings.ToPage;
            }
            else
            {
                
                fromPage = 0;
                toPage = maxPages;
            }

           
            SetupPrintRange();

           
            SetupColumns();

           
            measureprintarea(printDoc.PrinterSettings.CreateMeasurementGraphics());
            totalpages = Pagination();

        }

        /// <summary>
        /// Set up width override and fixed columns lists
        /// </summary>
        private void SetupColumns()
        {
          
            foreach (string colname in fixedcolumnnames)
            {
                try
                {
                    fixedcolumns.Add(GetColumnIndex(colname));
                }
                catch
                {
                   
                    colstoprint.Add(dgv.Columns[colname]);
                    fixedcolumns.Add(GetColumnIndex(colname));                    
                }
            }    

            
            foreach (DataGridViewColumn col in colstoprint)
                if (publicwidthoverrides.ContainsKey(col.Name))
                    colwidthsoverride.Add(publicwidthoverrides[col.Name]);
                else
                    colwidthsoverride.Add(-1);

        }

        /// <summary>
        /// Determine the print range based on dialog selections and user input. The rows
        /// and columns are sorted to ensure that the rows appear in their correct index 
        /// order and the columns appear in DisplayIndex order to account for added columns
        /// and re-ordered columns.
        /// </summary>
        private void SetupPrintRange()
        {
        
            SortedList temprowstoprint = null;
            SortedList tempcolstoprint = null; 
            if (PrintRange.Selection == printRange)
            {
                temprowstoprint = new SortedList(dgv.SelectedCells.Count);
                tempcolstoprint = new SortedList(dgv.SelectedCells.Count); 
                if (0 != dgv.SelectedRows.Count)
                {
                    temprowstoprint = new SortedList(dgv.SelectedRows.Count);
                    tempcolstoprint = new SortedList(dgv.Columns.Count); 

                 
                    temprowstoprint = new SortedList(dgv.SelectedRows.Count);
                    foreach (DataGridViewRow row in dgv.SelectedRows)
                        if (row.Visible && !row.IsNewRow)
                            temprowstoprint.Add(row.Index, row);
                    foreach (DataGridViewColumn col in dgv.Columns) if (col.Visible) tempcolstoprint.Add(col.DisplayIndex, col);
                }
               
                else if (0 != dgv.SelectedColumns.Count)
                {
                    temprowstoprint = new SortedList(dgv.Rows.Count);
                    tempcolstoprint = new SortedList(dgv.SelectedColumns.Count); 

                    foreach (DataGridViewRow row in dgv.Rows) 
                        if (row.Visible && !row.IsNewRow)
                           temprowstoprint.Add(row.Index, row);

                    foreach (DataGridViewColumn col in dgv.SelectedColumns)
                        if (col.Visible)
                            tempcolstoprint.Add(col.DisplayIndex, col);
                }
                else
                {
                   
                    temprowstoprint = new SortedList(dgv.SelectedCells.Count);
                    tempcolstoprint = new SortedList(dgv.SelectedCells.Count);

                    
                    int displayindex, colindex, rowindex;
                    foreach (DataGridViewCell cell in dgv.SelectedCells)
                    {
                        displayindex = cell.OwningColumn.DisplayIndex;
                        colindex = cell.ColumnIndex;
                        rowindex = cell.RowIndex;

                        
                        if (!temprowstoprint.Contains(rowindex))
                        {
                            DataGridViewRow row = dgv.Rows[rowindex];
                            if (row.Visible && !row.IsNewRow)
                                temprowstoprint.Add(rowindex, dgv.Rows[rowindex]);
                        }
                      
                        if (!tempcolstoprint.Contains(displayindex))
                            tempcolstoprint.Add(displayindex, dgv.Columns[colindex]);
                    }
                }
            }
           
            else if (PrintRange.CurrentPage == printRange)
            {
               
                temprowstoprint = new SortedList(dgv.DisplayedRowCount(true));
                tempcolstoprint = new SortedList(dgv.Columns.Count);

                
                for (int i = dgv.FirstDisplayedScrollingRowIndex;
                    i < dgv.FirstDisplayedScrollingRowIndex + dgv.DisplayedRowCount(true);
                    i++)
                {
                    DataGridViewRow row = dgv.Rows[i];
                    if (row.Visible) temprowstoprint.Add(row.Index, row);
                }

              
                foreach (DataGridViewColumn col in dgv.Columns) if (col.Visible) tempcolstoprint.Add(col.DisplayIndex, col);
            }
            
            else
            {
                temprowstoprint = new SortedList(dgv.Rows.Count);
                tempcolstoprint = new SortedList(dgv.Columns.Count);

              
                foreach (DataGridViewRow row in dgv.Rows) if (row.Visible && !row.IsNewRow) temprowstoprint.Add(row.Index, row);
                foreach (DataGridViewColumn col in dgv.Columns) if (col.Visible) tempcolstoprint.Add(col.DisplayIndex, col);
            }
            rowstoprint = new List<rowdata>(temprowstoprint.Count);
            foreach (object item in temprowstoprint.Values) rowstoprint.Add(new rowdata() { row = (DataGridViewRow)item });

            colstoprint = new List<DataGridViewColumn>(tempcolstoprint.Count);
            foreach (object item in tempcolstoprint.Values) colstoprint.Add(item);
            foreach (String columnname in HideColumns)
            {
                colstoprint.Remove(dgv.Columns[columnname]);
            }

            if (EnableLogging) Logger.LogInfoMsg(String.Format("Grid Printout Range is {0} columns", colstoprint.Count));
            if (EnableLogging) Logger.LogInfoMsg(String.Format("Grid Printout Range is {0} rows", rowstoprint.Count));
            
        }

        /// <summary>
        /// Centralize the string format settings. Build a string format object
        /// using passed in settings, (allowing a user override of a single setting)
        /// and get the alignment from the cell control style.
        /// </summary>
        /// <param name="format">String format, ref parameter with return settings</param>
        /// <param name="controlstyle">DataGridView style to apply (if available)</param>
        /// <param name="alignment">Override text Alignment</param>
        /// <param name="linealignment">Override line alignment</param>
        /// <param name="flags">String format flags</param>
        /// <param name="trim">Override string trimming flags</param>
        /// <returns></returns>
        private void buildstringformat(ref StringFormat format, DataGridViewCellStyle controlstyle,
            StringAlignment alignment, StringAlignment linealignment, StringFormatFlags flags,
            StringTrimming trim)
        {
           
            if (null == format)
                format = new StringFormat();
            format.Alignment = alignment;
            format.LineAlignment = linealignment;
            format.FormatFlags = flags;
            format.Trimming = trim;
            if ((null != dgv) && (RightToLeft.Yes == dgv.RightToLeft))
                format.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
            if (null != controlstyle)
            {
                DataGridViewContentAlignment cellalign = controlstyle.Alignment;
                if (cellalign.ToString().Contains("Center")) format.Alignment = StringAlignment.Center;
                else if (cellalign.ToString().Contains("Left")) format.Alignment = StringAlignment.Near;
                else if (cellalign.ToString().Contains("Right")) format.Alignment = StringAlignment.Far;

                if (cellalign.ToString().Contains("Top")) format.LineAlignment = StringAlignment.Near;
                else if (cellalign.ToString().Contains("Middle")) format.LineAlignment = StringAlignment.Center;
                else if (cellalign.ToString().Contains("Bottom")) format.LineAlignment = StringAlignment.Far;
            }
        }

        /// <summary>
        /// Calculate cell size based on data versus size settings
        /// </summary>
        /// <param name="g">Current graphics context</param>
        /// <param name="cell">Cell being measured</param>
        /// <param name="index">Column index of cell being measured</param>
        /// <param name="cellstyle">Computed Style of cell being measured</param>
        /// <param name="basewidth">Initial width for size calculation</param>
        /// <param name="format">Computed string format for cell data</param>
        /// <returns>Size of printed cell</returns>
        private SizeF calccellsize(Graphics g, DataGridViewCell cell, DataGridViewCellStyle cellstyle, 
            float basewidth, float overridewidth, StringFormat format)
        {
            SizeF size = new SizeF(cell.Size);

            if ((RowHeightSetting.DataHeight == RowHeight) ||
                (ColumnWidthSetting.DataWidth == ColumnWidth) ||
                (ColumnWidthSetting.Porportional == ColumnWidth))
            {
                SizeF datasize;
              
                if (("DataGridViewImageCell" == dgv.Columns[cell.ColumnIndex].CellType.Name)
                    && ("Image" == cell.ValueType.Name || "Byte[]" == cell.ValueType.Name))
                {
                   
                    Image img;

 
                    if ((null == cell.Value) || (typeof(DBNull) == cell.Value.GetType()))
                        return new SizeF(1,1);

                    
                    if ("Image" == cell.ValueType.Name || "Object" == cell.ValueType.Name)
                    {
                        
                        img = (System.Drawing.Image)cell.Value;
                    }
                    else if ("Byte[]" == cell.ValueType.Name)
                    {
                        
                       
                        ImageConverter ic = new ImageConverter();
                        img = (Image)ic.ConvertFrom((byte[])cell.Value);
                    }
                    else
                        throw new Exception(String.Format("Unknown image cell underlying type: {0} in column {1}",
                            cell.ValueType.Name, cell.ColumnIndex));

                   
                    datasize = img.Size;
                }
                else
                {
                    float width = (-1 != overridewidth) ? overridewidth : basewidth;

                    
                    datasize = g.MeasureString(cell.EditedFormattedValue.ToString(), cellstyle.Font,
                        new SizeF(width, maxPages), format);
                    if (printWidth < datasize.Width)
                        datasize = g.MeasureString(cell.FormattedValue.ToString(), cellstyle.Font,
                        new SizeF(pageWidth - cellstyle.Padding.Left - cellstyle.Padding.Right, maxPages),
                        format);
                }
                
               
                if (RowHeightSetting.DataHeight == RowHeight)
                    size.Height = datasize.Height + cellstyle.Padding.Top + cellstyle.Padding.Bottom;
                if ((ColumnWidthSetting.DataWidth == ColumnWidth) ||
                    (ColumnWidthSetting.Porportional == ColumnWidth))
                    size.Width = datasize.Width + cellstyle.Padding.Left + cellstyle.Padding.Right;
            }

            return size;
        }

        /// <summary>
        /// Recalculate row heights for cells whose width is greater than the set column width. 
        /// Called when column widths are changed in order to flow text down the page instead of 
        /// accross.
        /// </summary>
        /// <param name="g">Graphics Context for measuring image columns</param>
        /// <param name="colindex">column index in colstoprint</param>
        /// <param name="newcolwidth">new column width</param>
        private void RecalcRowHeights(Graphics g, int colindex, float newcolwidth)
        {
            DataGridViewCell cell = null;
            float finalsize = 0F;
                
         
            for (int i = 0; i < rowstoprint.Count; i++)
            {
                cell = ((DataGridViewRow)rowstoprint[i].row).Cells[((DataGridViewColumn)colstoprint[colindex]).Index];

                if (RowHeightSetting.DataHeight == RowHeight)
                {
                    StringFormat currentformat = null;

                    
                    DataGridViewCellStyle colstyle = GetStyle(((DataGridViewRow)rowstoprint[i].row), ((DataGridViewColumn)colstoprint[colindex]));

                    
                    buildstringformat(ref currentformat, colstyle, cellformat.Alignment, cellformat.LineAlignment,
                        cellformat.FormatFlags, cellformat.Trimming);

                    
                    SizeF size = calccellsize(g, cell, colstyle, newcolwidth, colwidthsoverride[colindex], currentformat);

                    finalsize = size.Height;
                }
                else
                {
                    finalsize = cell.Size.Height;
                }

                
                rowstoprint[i].height = (rowstoprint[i].height < finalsize ? finalsize : rowstoprint[i].height);
            }
        }


        /// <summary>
        /// Scan all the rows and columns to be printed and calculate the 
        /// overall individual column width (based on largest column value), 
        /// the header sizes, and determine all the row heights.
        /// </summary>
        /// <param name="g">The graphics context for all measurements</param>
        private void measureprintarea(Graphics g)
        {
            int i, j;
            colwidths = new List<float>(colstoprint.Count);
            footerHeight = 0;

            
            DataGridViewColumn col;
            DataGridViewRow row;

           
            for (i = 0; i < colstoprint.Count; i++)
            {
                col = (DataGridViewColumn)colstoprint[i];
                
               
                StringFormat currentformat = null;
                DataGridViewCellStyle headercolstyle = col.HeaderCell.InheritedStyle.Clone();
                if (ColumnHeaderStyles.ContainsKey(col.Name))
                {
                    headercolstyle = columnheaderstyles[col.Name];

                    
                    buildstringformat(ref currentformat, headercolstyle, cellformat.Alignment, cellformat.LineAlignment,
                        cellformat.FormatFlags, cellformat.Trimming);
                }
                else if (col.HasDefaultCellStyle)
                {
                    
                    buildstringformat(ref currentformat, headercolstyle, cellformat.Alignment, cellformat.LineAlignment,
                        cellformat.FormatFlags, cellformat.Trimming);
                }
                else
                {
                    currentformat = columnheadercellformat;
                }

               
                SizeF size = col.HeaderCell.Size;
                
              
                float usewidth = 0;
                if (0 <= colwidthsoverride[i])
                    
                    colwidths.Add(colwidthsoverride[i]);           
                else if ((ColumnWidthSetting.CellWidth == ColumnWidth) || (ColumnWidthSetting.Porportional == ColumnWidth))
                {
                    usewidth = col.HeaderCell.Size.Width;
                    
                    size = calccellsize(g, col.HeaderCell, headercolstyle, usewidth, colwidthsoverride[i], columnheadercellformat);
                    colwidths.Add(col.Width);                    
                }
                else
                {
                    usewidth = printWidth;
                    
                    size = calccellsize(g, col.HeaderCell, headercolstyle, usewidth, colwidthsoverride[i], columnheadercellformat);
                    colwidths.Add(size.Width);
                }
                
               
                if (RowHeightSetting.DataHeight == RowHeight)
                    colheaderheight = (colheaderheight < size.Height ? size.Height : colheaderheight);
                else
                    colheaderheight = col.HeaderCell.Size.Height;
            }

           

            if (pageno)
            {
                pagenumberHeight = (g.MeasureString("Page", pagenofont, printWidth, pagenumberformat)).Height;
            }

           
            if (PrintHeader)
            {
                
                titleheight = (g.MeasureString(title, titlefont, printWidth, titleformat)).Height;
                subtitleheight = (g.MeasureString(subtitle, subtitlefont, printWidth, subtitleformat)).Height;
            }

            if (PrintFooter)
            {
                if (!String.IsNullOrEmpty(footer))
                {
                    footerHeight += (g.MeasureString(footer, footerfont, printWidth, footerformat)).Height;
                }

                footerHeight += footerspacing;
            }

        
            for (i = 0; i < rowstoprint.Count; i++)
            {
                row = (DataGridViewRow)rowstoprint[i].row;

             
                if ((bool)PrintRowHeaders)
                {
                   
                    String rowheadertext = String.IsNullOrEmpty(row.HeaderCell.FormattedValue.ToString())
                        ? rowheadercelldefaulttext : row.HeaderCell.FormattedValue.ToString();

                    SizeF rhsize = g.MeasureString(rowheadertext,
                        row.HeaderCell.InheritedStyle.Font);
                    rowheaderwidth = (rowheaderwidth < rhsize.Width) ? rhsize.Width : rowheaderwidth;
                }

                
                for (j = 0; j < colstoprint.Count; j++)
                {
                    col = (DataGridViewColumn)colstoprint[j];
                
                 
                    StringFormat currentformat = null;
                    DataGridViewCellStyle colstyle = GetStyle(row, col); 

                    buildstringformat(ref currentformat, colstyle, cellformat.Alignment, cellformat.LineAlignment,
                        cellformat.FormatFlags, cellformat.Trimming);
                
                  
                    float basewidth;
                
                    if (0 <= colwidthsoverride[j])
                       
                        basewidth = colwidthsoverride[j];
                    else if ((ColumnWidthSetting.CellWidth == ColumnWidth) || (ColumnWidthSetting.Porportional == ColumnWidth))
                        
                        basewidth = colwidths[j];
                    else
                    {
                     
                        basewidth = printWidth;

                        
                        basewidth -= colstyle.Padding.Left + colstyle.Padding.Right;

                       
                        SizeF size = calccellsize(g, row.Cells[col.Index], colstyle,
                            basewidth, colwidthsoverride[j], currentformat);

                        basewidth = size.Width;
                    }

                    
                    if (!(0 <= colwidthsoverride[j]) && (ColumnWidthSetting.DataWidth == ColumnWidth))
                        colwidths[j] = colwidths[j] < basewidth ? basewidth : colwidths[j];
                }
            }

            

            pagesets = new List<PageDef>();
            pagesets.Add(new PageDef(PrintMargins, colstoprint.Count, pageWidth));
            int pset = 0;

            
            pagesets[pset].coltotalwidth = rowheaderwidth;

            
            for (j = 0; j < fixedcolumns.Count; j++)
            {
                int fixedcol = fixedcolumns[j];
                pagesets[pset].columnindex.Add(fixedcol);
                pagesets[pset].colstoprint.Add(colstoprint[fixedcol]);
                pagesets[pset].colwidths.Add(colwidths[fixedcol]);
                pagesets[pset].colwidthsoverride.Add(colwidthsoverride[fixedcol]);
                pagesets[pset].coltotalwidth += (colwidthsoverride[fixedcol] >= 0)
                    ? colwidthsoverride[fixedcol] : colwidths[fixedcol];
            }

            
            if (printWidth < (pagesets[pset].coltotalwidth))
            {
                throw new Exception("Fixed column widths exceed the page width.");
            }

           
            float columnwidth;
            for (i = 0; i < colstoprint.Count; i++)
            {
              
                if (fixedcolumns.Contains(i))
                    continue;

               
                columnwidth = (colwidthsoverride[i] >= 0)
                    ? colwidthsoverride[i] : colwidths[i];
                if (printWidth < (pagesets[pset].coltotalwidth + columnwidth) && i != 0)
                {
                    pagesets.Add(new PageDef(PrintMargins, colstoprint.Count, pageWidth));
                    pset++;

                  
                    pagesets[pset].coltotalwidth = rowheaderwidth;

                   
                    for (j = 0; j < fixedcolumns.Count; j++)
                    {
                        int fixedcol = fixedcolumns[j];
                        pagesets[pset].columnindex.Add(fixedcol);
                        pagesets[pset].colstoprint.Add(colstoprint[fixedcol]);
                        pagesets[pset].colwidths.Add(colwidths[fixedcol]);
                        pagesets[pset].colwidthsoverride.Add(colwidthsoverride[fixedcol]);
                        pagesets[pset].coltotalwidth += (colwidthsoverride[fixedcol] >= 0)
                            ? colwidthsoverride[fixedcol] : colwidths[fixedcol];
                    }

                  
                    if (printWidth < (pagesets[pset].coltotalwidth)) 
                    {
                        throw new Exception("Fixed column widths exceed the page width.");
                    }
                }

               
                pagesets[pset].columnindex.Add(i);
                pagesets[pset].colstoprint.Add(colstoprint[i]);
                pagesets[pset].colwidths.Add(colwidths[i]);
                pagesets[pset].colwidthsoverride.Add(colwidthsoverride[i]);
                pagesets[pset].coltotalwidth += columnwidth;
            }

           
            if (RightToLeft.Yes == dgv.RightToLeft)
            {
                for (pset = 0; pset < pagesets.Count; pset++)
                {
                    pagesets[pset].columnindex.Reverse();
                    pagesets[pset].colstoprint.Reverse();
                    pagesets[pset].colwidths.Reverse();
                    pagesets[pset].colwidthsoverride.Reverse();
                }
            }

            for (i = 0; i < pagesets.Count; i++)
            {
                PageDef pageset = pagesets[i];
                if (EnableLogging)
                {
                    String columnlist = "";

                    Logger.LogInfoMsg(String.Format("PageSet {0} Information ----------------------------------------------", i));

                   
                    for (int k = 0; k < pageset.colstoprint.Count; k++)
                        columnlist = String.Format("{0},{1}", columnlist,
                            ((DataGridViewColumn)(pageset.colstoprint[k])).Index);
                    Logger.LogInfoMsg(String.Format("Measured columns {0}", columnlist.Substring(1)));
                    columnlist = "";

                  
                    for (int k = 0; k < pageset.colstoprint.Count; k++)
                        columnlist = String.Format("{0},{1}", columnlist, pageset.colwidths[k]);
                    Logger.LogInfoMsg(String.Format("Original Column Widths: {0}", columnlist.Substring(1)));
                    columnlist = "";

                    for (int k = 0; k < pageset.colstoprint.Count; k++)
                        columnlist = String.Format("{0},{1}", columnlist, pageset.colwidthsoverride[k]);
                    Logger.LogInfoMsg(String.Format("Overridden Column Widths: {0}", columnlist.Substring(1)));
                    columnlist = "";
                }

                
                AdjustPageSets(g, pageset);

                
                if (EnableLogging)
                {
                    String columnlist = "";

                    // list final column widths for this page
                    for (int k = 0; k < pageset.colstoprint.Count; k++)
                        columnlist = String.Format("{0},{1}", columnlist, pageset.colwidths[k]);
                    Logger.LogInfoMsg(String.Format("Final Column Widths: {0}", columnlist.Substring(1)));
                    columnlist = "";

                    Logger.LogInfoMsg(String.Format("pageset print width is {0}, total column width to be printed is {1}", 
                        pageset.printWidth, pageset.coltotalwidth));
                }
            }
        }

        /// <summary>
        /// Adjust column widths for fixed and porportional columns, set the 
        /// margins to enforce the selected tablealignment.
        /// </summary>
        /// <param name="g">The graphics context for all measurements</param>
        /// <param name="pageset">The pageset to adjust</param>
        private void AdjustPageSets(Graphics g, PageDef pageset)
        {
            int i;
            float fixedcolwidth = rowheaderwidth;
            float remainingcolwidth = 0;
            float ratio;

           
            
            for (i = 0; i < pageset.colwidthsoverride.Count; i++)
                if (pageset.colwidthsoverride[i] >= 0)
                    fixedcolwidth += pageset.colwidthsoverride[i];

           
            for (i = 0; i < pageset.colwidths.Count; i++)
                if (pageset.colwidthsoverride[i] < 0)
                    remainingcolwidth += pageset.colwidths[i];

            if ((porportionalcolumns || ColumnWidthSetting.Porportional == ColumnWidth) && 
                0 < remainingcolwidth)
                ratio = ((float)printWidth - fixedcolwidth) / (float)remainingcolwidth;
            else
                ratio = (float)1.0;

            
            pageset.coltotalwidth = rowheaderwidth;
            for (i = 0; i < pageset.colwidths.Count; i++)
            {
                if (pageset.colwidthsoverride[i] >= 0)
                   
                    pageset.colwidths[i] = pageset.colwidthsoverride[i];
                else if (ColumnWidthSetting.Porportional == ColumnWidth)
                    
                    pageset.colwidths[i] = pageset.colwidths[i] * ratio;
                else if (pageset.colwidths[i] > printWidth - pageset.coltotalwidth)
                    pageset.colwidths[i] = printWidth - pageset.coltotalwidth;

                //recalculate any rows that need to flow down the page
                RecalcRowHeights(g, pageset.columnindex[i], pageset.colwidths[i]);

                pageset.coltotalwidth += pageset.colwidths[i];

            }

            
            if (Alignment.Left == tablealignment)
            {
            
                pageset.margins.Right = pageWidth - pageset.margins.Left - (int)pageset.coltotalwidth;
                if (0 > pageset.margins.Right) pageset.margins.Right = 0;
            }
            else if (Alignment.Right == tablealignment)
            {
                
                pageset.margins.Left = pageWidth - pageset.margins.Right - (int)pageset.coltotalwidth;
                if (0 > pageset.margins.Left) pageset.margins.Left = 0;
            }
            else if (Alignment.Center == tablealignment)
            {
              
                pageset.margins.Left = (pageWidth - (int)pageset.coltotalwidth) / 2;
                if (0 > pageset.margins.Left) pageset.margins.Left = 0;
                pageset.margins.Right = pageset.margins.Left;
            }
        }

        /// <summary>
        /// Set page breaks for the rows to be printed, and count total pages
        /// </summary>
        private int Pagination()
        {
            float pos = 0;
            paging newpage = paging.keepgoing;

           
            CurrentPage = 1;
            staticheight = pageHeight - FooterHeight - pagesets[currentpageset].margins.Bottom; //PrintMargins.Bottom;

          
            staticheight -= PageNumberHeight;

         
            pos = PrintMargins.Top + HeaderHeight;

           
            if (!String.IsNullOrEmpty(breakonvaluechange))
            {
                oldvalue = rowstoprint[0].row.Cells[breakonvaluechange].EditedFormattedValue;
            }

          
            for (int currentrow = 0; currentrow < (rowstoprint.Count); currentrow++)
            {
              
                if (pos + rowstoprint[currentrow].height >= staticheight)
                {
                    newpage = paging.outofroom;
                }

                
                if ((!String.IsNullOrEmpty(breakonvaluechange))  &&
                    (!oldvalue.Equals(rowstoprint[currentrow].row.Cells[breakonvaluechange].EditedFormattedValue)))
                {
                    newpage = paging.datachange;
                    oldvalue = rowstoprint[currentrow].row.Cells[breakonvaluechange].EditedFormattedValue;
                }

               
                if (newpage != paging.keepgoing)
                {
                     rowstoprint[currentrow].pagebreak = true;

                   
                    CurrentPage++;

                 
                    if (CurrentPage > toPage)
                    {
                       
                        return toPage;
                    }

                    
                    if (KeepRowsTogether
                        || newpage == paging.datachange
                        || (newpage == paging.outofroom && (staticheight - pos) < KeepRowsTogetherTolerance))
                    {
                        
                        pos = rowstoprint[currentrow].height;
                    }
                    else
                    {
                       
                        rowstoprint[currentrow].splitrow = true;

                       
                        pos = pos + rowstoprint[currentrow].height - staticheight;
                    }

                   
                    staticheight = pageHeight - FooterHeight - pagesets[currentpageset].margins.Bottom; 

                   
                    staticheight += PageNumberHeight;


                    
                    pos += PrintMargins.Top + HeaderHeight + PageNumberHeight;
                }
                else
                {
                   
                    pos += rowstoprint[currentrow].height;
                }

                
                newpage = paging.keepgoing;
            }

           
            return CurrentPage;
        }

        /// <summary>
        /// Check for more pages. This is called at the end of printing a page set.
        /// If there's another page set to print, we return true.
        /// </summary>
        private bool DetermineHasMorePages()
        {
            currentpageset++;
            if (currentpageset < pagesets.Count)
            {
                
                return true;        
            }
            else
                return false;
        }

        /// <summary>
        /// This routine prints one page. It will skip non-printable pages if the user 
        /// selected the "some pages" option on the print dialog. This is called during 
        /// the Print event.
        /// </summary>
        /// <param name="g">Graphics object to print to</param>
        private bool PrintPage(Graphics g)
        {
            
            int firstrow = 0;
            
            
            bool HasMorePages = false;

            
            bool printthispage = false;

          
            float printpos = pagesets[currentpageset].margins.Top;

        
            CurrentPage++;
            if (EnableLogging) Logger.LogInfoMsg(String.Format("Print Page processing page {0} -----------------------", CurrentPage));
            if ((CurrentPage >= fromPage) && (CurrentPage <= toPage))
                printthispage = true;

          
            staticheight = pageHeight - FooterHeight - pagesets[currentpageset].margins.Bottom;
            if (!pagenumberontop)
                staticheight -= PageNumberHeight;

           
            float used = 0;

           
            rowdata thisrow = null;

          
            rowdata nextrow = null;

           

            while (!printthispage)
            {
                if (EnableLogging) Logger.LogInfoMsg(String.Format("Print Page skipping page {0} part {1}", CurrentPage, currentpageset + 1));

              
                printpos = pagesets[currentpageset].margins.Top + HeaderHeight + PageNumberHeight;

              
                bool pagecomplete = false;
                currentrow = lastrowprinted + 1;

                
                firstrow = currentrow;

                do
                {
                    thisrow = rowstoprint[currentrow];

                    used = (thisrow.height - rowstartlocation) > (staticheight - printpos)
                            ? (staticheight - printpos) : thisrow.height - rowstartlocation;
                    printpos += used;
                    
                  
                    lastrowprinted++;
                    currentrow++;
                    nextrow = (currentrow < rowstoprint.Count) ? rowstoprint[currentrow] : null;
                    if (null != nextrow && nextrow.pagebreak) 
                    {
                        pagecomplete = true;

                        if (nextrow.splitrow)
                        {
                           
                            rowstartlocation += (nextrow.height - rowstartlocation) > (staticheight - printpos)
                                ? (staticheight - printpos) : nextrow.height - rowstartlocation;
                        }
                    }
                    else
                    {
                        
                        rowstartlocation = 0;
                    }

                    
                    if ((0 == rowstartlocation) && lastrowprinted >= rowstoprint.Count - 1)
                        pagecomplete = true;
                
                } while (!pagecomplete);

                
                if (EnableLogging) Logger.LogInfoMsg(String.Format("Print Page skipped rows {0} to {1}", firstrow, currentrow));

                CurrentPage++;
                
                if ((CurrentPage >= fromPage) && (CurrentPage <= toPage))
                    printthispage = true;

               
                if (0 != rowstartlocation)
                {
                    
                    HasMorePages = true;
                }
              
                else if ((lastrowprinted >= rowstoprint.Count - 1) || (CurrentPage > toPage))
                {
                    
                    HasMorePages = DetermineHasMorePages();

                    
                    lastrowprinted = -1;
                    CurrentPage = 0;

                    return HasMorePages;
                }
            }

            if (EnableLogging)
            {
                Logger.LogInfoMsg(String.Format("Print Page printing page {0} part {1}", CurrentPage, currentpageset + 1));
                var m = pagesets[currentpageset].margins;
                Logger.LogInfoMsg(String.Format("Current Margins are {0}, {1}, {2}, {3}", m.Left, m.Right, m.Top, m.Bottom));
            }

          

            
            ImbeddedImageList.Where(p => p.ImageLocation == Location.Absolute).DrawImbeddedImage(g, pagesets[currentpageset].printWidth,
                pageHeight, pagesets[currentpageset].margins);

          

         
            printpos = pagesets[currentpageset].margins.Top;

           
            if (PrintHeader)
            {
               
                ImbeddedImageList.Where(p => p.ImageLocation == Location.Header).DrawImbeddedImage(g, pagesets[currentpageset].printWidth,
                    pageHeight, pagesets[currentpageset].margins);

                if (pagenumberontop)
                {
                    printpos = PrintPageNo(g, printpos);
                }

               
                if (0 != TitleHeight && !String.IsNullOrEmpty(title))
                    printsection(g, ref printpos, title, titlefont,
                        titlecolor, titleformat, overridetitleformat,
                        pagesets[currentpageset],
                        titlebackground, titleborder);

               
                printpos += TitleHeight;

                
                if (0 != SubTitleHeight && !String.IsNullOrEmpty(subtitle))
                    printsection(g, ref printpos, subtitle, subtitlefont,
                        subtitlecolor, subtitleformat, overridesubtitleformat,
                        pagesets[currentpageset],
                        subtitlebackground, subtitleborder);

                printpos += SubTitleHeight;
            }

            
            if ((bool)PrintColumnHeaders)
            {
                
                printcolumnheaders(g, ref printpos, pagesets[currentpageset]);
            }

           
            bool continueprinting = true;
            currentrow = lastrowprinted + 1;

            firstrow = currentrow;

            if (currentrow >= rowstoprint.Count)
            {
               
                continueprinting = false;
            }

            while (continueprinting)
            {
                thisrow = rowstoprint[currentrow];

               
                used = printrow(g, printpos, (DataGridViewRow)(thisrow.row),
                    pagesets[currentpageset], rowstartlocation);
                printpos += used;

                
                
                lastrowprinted++;
                currentrow++;
                nextrow = (currentrow < rowstoprint.Count) ? rowstoprint[currentrow] : null;
                if (null != nextrow && nextrow.pagebreak)
                {
                    continueprinting = false;

                    if (nextrow.splitrow)
                    {
                      
                        rowstartlocation += printrow(g, printpos, (DataGridViewRow)(nextrow.row),
                            pagesets[currentpageset], rowstartlocation); 
                    }
                }
                else
                {
                    
                    rowstartlocation = 0;
                }

                
                if ((0 == rowstartlocation) && lastrowprinted >= rowstoprint.Count - 1)
                    continueprinting = false;                    

            }

             if (EnableLogging)
            {
                Logger.LogInfoMsg(String.Format("Print Page printed rows {0} to {1}", firstrow, currentrow));
                PageDef pageset = pagesets[currentpageset];
                String columnlist = "";

                for (int i = 0; i < pageset.colstoprint.Count; i++) 
                    columnlist = String.Format("{0},{1}", columnlist,
                        ((DataGridViewColumn)(pageset.colstoprint[i])).Index);

                Logger.LogInfoMsg(String.Format("Print Page printed columns {0}", columnlist.Substring(1)));
            }

            if (PrintFooter)
            {
                //
                ImbeddedImageList.Where(p => p.ImageLocation == Location.Footer).DrawImbeddedImage(g, pagesets[currentpageset].printWidth,
                    pageHeight, pagesets[currentpageset].margins);
                
                
                printpos = pageHeight - footerHeight - pagesets[currentpageset].margins.Bottom;  // - margins.Top

                
                printpos += footerspacing;

                
                if (!pagenumberontop)
                {
                    printpos = PrintPageNo(g, printpos);
                }

                if (0 != FooterHeight)
                    printfooter(g, ref printpos, pagesets[currentpageset]);
            }

           
            if (0 != rowstartlocation)
            {
               
                HasMorePages = true;
            }
            
           
            if ((CurrentPage >= toPage) || (lastrowprinted >= rowstoprint.Count - 1))
            {
                
                HasMorePages = DetermineHasMorePages();

                
                rowstartlocation = 0;
                lastrowprinted = -1;
                CurrentPage = 0;
            }
            else
            {
                HasMorePages = true;
            }

            return HasMorePages;
        }

        /// <summary>
        /// Print the page number
        /// </summary>
        /// <param name="g"></param>
        /// <param name="printpos"></param>
        /// <returns></returns>
        private float PrintPageNo(Graphics g, float printpos)
        {
            if (pageno)
            {
                String pagenumber = pagetext + CurrentPage.ToString(CultureInfo.CurrentCulture);
                if (showtotalpagenumber)
                {
                    pagenumber += pageseparator + totalpages.ToString(CultureInfo.CurrentCulture);
                }
                if (1 < pagesets.Count)
                    pagenumber += parttext + (currentpageset + 1).ToString(CultureInfo.CurrentCulture);

                
                printsection(g, ref printpos,
                    pagenumber, pagenofont, pagenocolor, pagenumberformat,
                    overridepagenumberformat, pagesets[currentpageset],
                    null, null);

                if (pagenumberonseparateline)
                    printpos += pagenumberHeight;
            }
            return printpos;
        }

        /// <summary>
        /// Print a header or footer section. Used for page numbers and titles
        /// </summary>
        /// <param name="g">Graphic context to print in</param>
        /// <param name="pos">Track vertical space used; 'y' location</param>
        /// <param name="text">String to print</param>
        /// <param name="font">Font to use for printing</param>
        /// <param name="color">Color to print in</param>
        /// <param name="format">String format for text</param>
        /// <param name="useroverride">True if the user overrode the alignment or flags</param>
        /// <param name="margins">The table's print margins</param>
        /// <param name="background">Background fill for the section; may be null for no background</param>
        /// <param name="border">Border for the section; may be null for no border</param>
        private void printsection(Graphics g, ref float pos, string text,
            Font font, Color color, StringFormat format, bool useroverride, PageDef pageset,
            Brush background, Pen border)
        {
            // measure string
            SizeF printsize = g.MeasureString(text, font, pageset.printWidth, format);

            // build area to print within
            RectangleF printarea = new RectangleF((float)pageset.margins.Left, pos, (float)pageset.printWidth,
               printsize.Height);

            // draw a background, if a Brush has been provided
            if (null != background)
            {
                g.FillRectangle(background, printarea);
            }

            // draw a border, if a Pen has been provided
            if (null != border)
            {
                g.DrawRectangle(border, printarea.X, printarea.Y, printarea.Width, printarea.Height);
            }

            // do the actual print
            g.DrawString(text, font, new SolidBrush(color), printarea, format);
        }

        /// <summary>
        /// Print the footer. This handles the footer spacing, and printing the page number
        /// at the bottom of the page (if the page number is not in the header).
        /// </summary>
        /// <param name="g">Graphic context to print in</param>
        /// <param name="pos">Track vertical space used; 'y' location</param>
        /// <param name="margins">The table's print margins</param>
        private void printfooter(Graphics g, ref float pos, PageDef pageset)
        {

            // print the footer
            printsection(g, ref pos, footer, footerfont, footercolor, footerformat,
                overridefooterformat, pageset, footerbackground, footerborder);
        }

        /// <summary>
        /// Print the column headers. Most printing format info is retrieved from the 
        /// source DataGridView.
        /// </summary>
        /// <param name="g">Graphics Context to print within</param>
        /// <param name="pos">Track vertical space used; 'y' location</param>
        /// <param name="pageset">Current pageset - defines columns and margins</param>
        private void printcolumnheaders(Graphics g, ref float pos, PageDef pageset)
        {
          
           
            float xcoord = pageset.margins.Left + rowheaderwidth;

            Pen lines = new Pen(dgv.GridColor, 1);

           
            DataGridViewColumn col;
            for (int i = 0; i < pageset.colstoprint.Count; i++)
            {
                col = (DataGridViewColumn)pageset.colstoprint[i];

               
                float cellwidth = (pageset.colwidths[i] > pageset.printWidth - rowheaderwidth ?
                    pageset.printWidth - rowheaderwidth : pageset.colwidths[i]);

               
                DataGridViewCellStyle style = col.HeaderCell.InheritedStyle.Clone();
                if (ColumnHeaderStyles.ContainsKey(col.Name))
                {
                    style = ColumnHeaderStyles[col.Name];
                }

               
                RectangleF cellprintarea = new RectangleF(xcoord, pos, cellwidth, colheaderheight);

                DrawCell(g, cellprintarea, style, col.HeaderCell, 0, columnheadercellformat, lines);

                xcoord += pageset.colwidths[i];
            }

            
            pos += colheaderheight +
                (dgv.ColumnHeadersBorderStyle != DataGridViewHeaderBorderStyle.None ? lines.Width : 0);
        }

        /// <summary>
        /// Print one row of the DataGridView. Most printing format info is retrieved
        /// from the DataGridView.
        /// </summary>
        /// <param name="g">Graphics Context to print within</param>
        /// <param name="pos">Track vertical space used; 'y' location</param>
        /// <param name="row">The row that will be printed</param>
        /// <param name="pageset">Current Pageset - defines columns and margins</param>
        /// <param name="startline">Line no. in row to start printing text at</param>
        private float printrow(Graphics g, float finalpos, DataGridViewRow row, PageDef pageset,
            float startlocation)
        {
            // track printing location accross the page
            float xcoord = pageset.margins.Left;
            float pos = finalpos;

            // set the pen for drawing the grid lines
            Pen lines = new Pen(dgv.GridColor, 1);

            // calc row width, account for columns wider than the print area!
            float rowwidth = (pageset.coltotalwidth > pageset.printWidth ? pageset.printWidth : pageset.coltotalwidth);

            // calc row heigth in pixels to print
            float rowheight = (rowstoprint[currentrow].height - startlocation) > (staticheight - pos)
                ? (staticheight - pos) : rowstoprint[currentrow].height - startlocation;

           
            DataGridViewCellStyle rowstyle = row.InheritedStyle.Clone();
            DataGridViewCellStyle headerstyle = row.HeaderCell.InheritedStyle.Clone();

           
            RectangleF printarea = new RectangleF(xcoord, pos, rowwidth,
                rowheight);

           
            g.FillRectangle(new SolidBrush(rowstyle.BackColor), printarea);

            
          
            if ((bool)PrintRowHeaders)
            {
                RectangleF headercellprintarea = new RectangleF(xcoord, pos, 
                    rowheaderwidth, rowheight);

                DrawCell(g, headercellprintarea, headerstyle, row.HeaderCell, startlocation, 
                    rowheadercellformat, lines);

                
                xcoord += rowheaderwidth;
            }

           
            DataGridViewColumn col;
            for (int i = 0; i < pageset.colstoprint.Count; i++)
            {
                
                col = (DataGridViewColumn)pageset.colstoprint[i];
                DataGridViewCell cell = row.Cells[col.Index];

                
                float cellwidth = (pageset.colwidths[i] > pageset.printWidth - rowheaderwidth ?
                    pageset.printWidth - rowheaderwidth : pageset.colwidths[i]);

                
                if (cellwidth > 0)
                {
                    
                    StringFormat finalformat = null;
                    Font cellfont = null;
                    DataGridViewCellStyle colstyle = GetStyle(row, col); // = row.Cells[col.Index].InheritedStyle.Clone(); 

                    
                    buildstringformat(ref finalformat, colstyle, cellformat.Alignment, cellformat.LineAlignment,
                        cellformat.FormatFlags, cellformat.Trimming);
                    cellfont = colstyle.Font;

                    
                    RectangleF cellprintarea = new RectangleF(xcoord, pos, cellwidth,
                        rowheight);

                    DrawCell(g, cellprintarea, colstyle, cell, startlocation, finalformat, lines);
                }
                // track horizontal space used
                xcoord += pageset.colwidths[i];
            }

            //-----------------------------------------------------------------
            // All done with this row, consume "used" vertical space
            //-----------------------------------------------------------------
            return rowheight;
        }

        /// <summary>
        /// Allow override of cell drawing. This is to support grids that have onPaint
        /// overridden to do things like images in header rows and vertical printing
        /// </summary>
        /// <param name="g"></param>
        /// <param name="rowindex"></param>
        /// <param name="columnindex"></param>
        /// <param name="rectf"></param>
        /// <param name="style"></param>
        /// <returns></returns>
        Boolean DrawOwnerDrawCell(Graphics g, int rowindex, int columnindex, RectangleF rectf,
            DataGridViewCellStyle style)
        {
            DGVCellDrawingEventArgs args = new DGVCellDrawingEventArgs(g, rectf, style,
                rowindex, columnindex);
            OnCellOwnerDraw(args);
            return args.Handled;
        }

        /// <summary>
        /// Draw a cell. Used for column and row headers and body cells.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="cellprintarea"></param>
        /// <param name="style"></param>
        /// <param name="cell"></param>
        /// <param name="startlocation"></param>
        /// <param name="cellformat"></param>
        /// <param name="lines"></param>
        void DrawCell(Graphics g, RectangleF cellprintarea, DataGridViewCellStyle style, 
            DataGridViewCell cell, float startlocation, StringFormat cellformat, Pen lines)
        {
            // Draw the cell if it's not overridden by ownerdrawing
            if (!DrawOwnerDrawCell(g, cell.RowIndex, cell.ColumnIndex, cellprintarea, style))
            {
                // save original clipping bounds
                RectangleF clip = g.ClipBounds;

                // fill in the full cell background - using the selected style
                //g.FillRectangle(new SolidBrush(colstyle.BackColor), cellprintarea);
                g.FillRectangle(new SolidBrush(style.BackColor), cellprintarea);

                // reset print area for this individual cell, adjusting 'inward' for cell padding
                RectangleF paddedcellprintarea = new RectangleF(cellprintarea.X + style.Padding.Left,
                    cellprintarea.Y + style.Padding.Top,
                    cellprintarea.Width - style.Padding.Right - style.Padding.Left,
                    cellprintarea.Height - style.Padding.Bottom - style.Padding.Top);

                // set clipping to current print area - i.e. our cell
                g.SetClip(cellprintarea);

                // define the *actual* print area based on the given startlocation. Offset the start by 
                // minus the start location, increase the print area height by the startlocation
                RectangleF actualprint = new RectangleF(paddedcellprintarea.X, paddedcellprintarea.Y - startlocation,
                    paddedcellprintarea.Width, paddedcellprintarea.Height + startlocation);

                // draw content based on cell style, but only for "body" cells
                if (0 <= cell.RowIndex && 0 <= cell.ColumnIndex) {
                    if ("DataGridViewImageCell" == dgv.Columns[cell.ColumnIndex].CellType.Name)
                    {
                        // draw the image for image cells
                        DrawImageCell(g, (DataGridViewImageCell)cell, actualprint);
                    }
                    else if ("DataGridViewCheckBoxCell" == dgv.Columns[cell.ColumnIndex].CellType.Name)
                    {
                        // draw a checkbox for checkbox cells
                        DrawCheckBoxCell(g, (DataGridViewCheckBoxCell)cell, actualprint);
                    }
                    else
                    {
                        
                        g.DrawString(cell.FormattedValue.ToString(), style.Font,
                            new SolidBrush(style.ForeColor), actualprint, cellformat);
                    }
                }
                else
                {
                    
                    g.DrawString(cell.FormattedValue.ToString(), style.Font, 
                        new SolidBrush(style.ForeColor), actualprint, cellformat);
                }

                g.SetClip(clip);

                // draw the borders - default to the dgv's border setting, and use unpadded cell print area
                if (dgv.CellBorderStyle != DataGridViewCellBorderStyle.None)
                    g.DrawRectangle(lines, cellprintarea.X, cellprintarea.Y, cellprintarea.Width, cellprintarea.Height);
            }
        }

        /// <summary>
        /// Draw a body cell that is a checkbox
        /// </summary>
        /// <param name="g"></param>
        /// <param name="checkboxcell"></param>
        /// <param name="rectf"></param>
        void DrawCheckBoxCell(Graphics g, DataGridViewCheckBoxCell checkboxcell, RectangleF rectf)
        {
            // create a non-printing graphics context in which to draw the checkbox control
            Image i = new Bitmap((int)rectf.Width, (int)rectf.Height);
            Graphics tg = Graphics.FromImage(i);

            // determine checked or notchecked (or undetermined for tristate checkboxes)
            CheckBoxState state = CheckBoxState.UncheckedNormal;
            if (checkboxcell.ThreeState)
            {
                if (((CheckState)checkboxcell.EditedFormattedValue) == CheckState.Checked)
                    state = CheckBoxState.CheckedNormal;
                else if (((CheckState)checkboxcell.EditedFormattedValue) == CheckState.Indeterminate)
                    state = CheckBoxState.MixedNormal;
            }
            else
            {
                if ((Boolean)checkboxcell.EditedFormattedValue)
                    state = CheckBoxState.CheckedNormal;
            }
            
            // get the size and location to print the checkbox - currently centered, may change later
            Size size = CheckBoxRenderer.GetGlyphSize(tg, state);
            int x = ((int)rectf.Width - size.Width) / 2;
            int y = ((int)rectf.Height - size.Height) / 2;

            // draw the checkbox in our temporary graphics context
            CheckBoxRenderer.DrawCheckBox(tg, new Point(x, y), state);

            //calculate image drawing origin based on cell alignment
            switch (checkboxcell.InheritedStyle.Alignment)
            {
                case DataGridViewContentAlignment.BottomCenter:
                    rectf.Y += y;
                    break;
                case DataGridViewContentAlignment.BottomLeft:
                    rectf.X -= x;
                    rectf.Y += y;
                    break;
                case DataGridViewContentAlignment.BottomRight:
                    rectf.X += x;
                    rectf.Y += y;
                    break;
                case DataGridViewContentAlignment.MiddleCenter:
                    break;
                case DataGridViewContentAlignment.MiddleLeft:
                    rectf.X -= x;
                    break;
                case DataGridViewContentAlignment.MiddleRight:
                    rectf.X += x;
                    break;
                case DataGridViewContentAlignment.TopCenter:
                    rectf.Y -= y;
                    break;
                case DataGridViewContentAlignment.TopLeft:
                    rectf.X -= x;
                    rectf.Y -= y;
                    break;
                case DataGridViewContentAlignment.TopRight:
                    rectf.X += x;
                    rectf.Y -= y;
                    break;
                case DataGridViewContentAlignment.NotSet:
                    break;
            }

            // now draw the image of the checkbox to our print output
            g.DrawImage(i, rectf);

            // clean up after ourselves
            tg.Dispose();
            i.Dispose();
        }

        /// <summary>
        /// Draw a body cell that has an imbedded image
        /// </summary>
        /// <param name="g"></param>
        /// <param name="imagecell"></param>
        /// <param name="rectf"></param>
        void DrawImageCell(Graphics g, DataGridViewImageCell imagecell, RectangleF rectf)
        {
            // image to draw
            Image img;

            // if we don't actually have a value, then just exit.
            if ((null == imagecell.Value) || (typeof(DBNull) == imagecell.Value.GetType()))
                return;

            // Check on type of image cell value - may not be an actual "image" type
            if ("Image" == imagecell.ValueType.Name)
            {
                // if it's an "image" type, then load it directly
                img = (System.Drawing.Image)imagecell.Value;
            }
            else if ("Byte[]" == imagecell.ValueType.Name)
            {
                // if it's not an "image" type (i.e. loaded from a database to a bound column)
                // convert the underlying byte array to an image
                ImageConverter ic = new ImageConverter();
                img = (Image)ic.ConvertFrom((byte[])imagecell.Value);
            }
            else
                throw new Exception(String.Format("Unknown image cell underlying type: {0} in column {1}",
                    imagecell.ValueType.Name, imagecell.ColumnIndex));

            // clipping bounds. This is the portion of the image to fit into the drawing rectangle
            Rectangle src = new Rectangle();

            // calculate deltas
            int dx = 0;
            int dy = 0;

            // drawn normal size, clipped to cell 
            if ((DataGridViewImageCellLayout.Normal == imagecell.ImageLayout) ||
                (DataGridViewImageCellLayout.NotSet == imagecell.ImageLayout))
            {
                // calculate origin deltas, used to move image
                dx = img.Width - (int)rectf.Width;
                dy = img.Height - (int)rectf.Height;

                // set destination width and height to clip to cell
                if (0 > dx) rectf.Width = src.Width = img.Width; else src.Width = (int)rectf.Width;
                if (0 > dy) rectf.Height = src.Height = img.Height; else src.Height = (int)rectf.Height;

            }
            else if (DataGridViewImageCellLayout.Stretch == imagecell.ImageLayout)
            {
                // stretch image to fit cell size
                src.Width = img.Width;
                src.Height = img.Height;

                // change the origin delta's to 0 so we don't move the image
                dx = 0;
                dy = 0;
            }
            else // DataGridViewImageCellLayout.Zoom
            {
                // scale image to fit in cell
                src.Width = img.Width;
                src.Height = img.Height;

                float vertscale = rectf.Height / src.Height;
                float horzscale = rectf.Width / src.Width;
                float scale;

                // use the smaller scaling factor to ensure the image will fit in the cell
                if (vertscale > horzscale)
                {
                    // use horizontal scale, don't move image horizontally
                    scale = horzscale;
                    dx = 0;
                    dy = (int)((src.Height * scale) - rectf.Height);
                }
                else
                {
                    // use vertical scale, don't move image vertically
                    scale = vertscale;
                    dy = 0;
                    dx = (int)((src.Width * scale) - rectf.Width);
                }

                // set target size to match scaled image
                rectf.Width = src.Width * scale;
                rectf.Height = src.Height * scale;
            }

            //calculate image drawing origin based on origin deltas
            switch (imagecell.InheritedStyle.Alignment)
            {
                case DataGridViewContentAlignment.BottomCenter:
                    if (0 > dy) rectf.Y -= dy; else src.Y = dy;
                    if (0 > dx) rectf.X -= dx / 2; else src.X = dx / 2;
                    break;
                case DataGridViewContentAlignment.BottomLeft:
                    if (0 > dy) rectf.Y -= dy; else src.Y = dy;
                    src.X = 0;
                    break;
                case DataGridViewContentAlignment.BottomRight:
                    if (0 > dy) rectf.Y -= dy; else src.Y = dy;
                    if (0 > dx) rectf.X -= dx; else src.X = dx;
                    break;
                case DataGridViewContentAlignment.MiddleCenter:
                    if (0 > dy) rectf.Y -= dy / 2; else src.Y = dy / 2;
                    if (0 > dx) rectf.X -= dx / 2; else src.X = dx / 2;
                    break;
                case DataGridViewContentAlignment.MiddleLeft:
                    if (0 > dy) rectf.Y -= dy / 2; else src.Y = dy / 2;
                    src.X = 0;
                    break;
                case DataGridViewContentAlignment.MiddleRight:
                    if (0 > dy) rectf.Y -= dy / 2; else src.Y = dy / 2;
                    if (0 > dx) rectf.X -= dx; else src.X = dx;
                    break;
                case DataGridViewContentAlignment.TopCenter:
                    src.Y = 0;
                    if (0 > dx) rectf.X -= dx / 2; else src.X = dx / 2;
                    break;
                case DataGridViewContentAlignment.TopLeft:
                    src.Y = 0;
                    src.X = 0;
                    break;
                case DataGridViewContentAlignment.TopRight:
                    src.Y = 0;
                    if (0 > dx) rectf.X -= dx; else src.X = dx;
                    break;
                case DataGridViewContentAlignment.NotSet:
                    if (0 > dy) rectf.Y -= dy / 2; else src.Y = dy / 2;
                    if (0 > dx) rectf.X -= dx / 2; else src.X = dx / 2;
                    break;
            }

            
            g.DrawImage(img, rectf, src, GraphicsUnit.Pixel);
        }
    }
}
