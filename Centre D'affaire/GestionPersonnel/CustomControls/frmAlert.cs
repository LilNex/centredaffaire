using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Centre_D_affaire.Properties;

namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    public partial class frmAlert : Form
    {

        public frmAlert()
        {
            InitializeComponent();
            //timer.Elapsed += OnTimedEvent;
        }

        public enum errorType
        {
            Info, 
            Error,
        }

        public void showError(string Message, errorType ErrorType)
        {
            lblMessage.Text = Message;
            switch (ErrorType)
            {
                case errorType.Error:
                    this.BackColor = Color.Red;
                    pcbIcon.Image = (Resources.icons8_error_60px);

                    break;
                case errorType.Info:
                    this.BackColor = Color.FromArgb(37, 58, 79);
                    pcbIcon.Image = Resources.icons8_info_96px;
                    break;
            }
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork;
            bw.RunWorkerAsync();
            SystemSounds.Asterisk.Play();
            this.BringToFront();
            this.Show();
            
            Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
            Top = Screen.PrimaryScreen.Bounds.Top + Screen.PrimaryScreen.Bounds.Height - 148;

        }

        public void closeError()
        {
            this.Visible = false;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            this.Visible = false;
        }
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            System.Threading.Thread.Sleep(5000);
            closeError();
        }
    }
}
