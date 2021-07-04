using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionSalleDeSport
{
    public partial class FormGestionnaire : Form
    {
        public FormGestionnaire()
        {
            InitializeComponent();

        }
        private Form activeForm;

        private void OpenChildForm(UserControl  childForm, object btnSender)
        {
            if (activeForm != null)
            activeForm.Close();
            
            
            
            
            childForm.Dock = DockStyle.Fill;
            this.PAnelDesktop.Controls.Add(childForm);
            this.PAnelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }




     

        private void BTNEntraineur_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UCgestionEntraineur(), sender);
            Panel2.BackgroundColor = Color.FromArgb(128, 0, 128);
        }

        private void BTNMembre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UCgestionMemebre(), sender);
            Panel2.BackgroundColor = Color.FromArgb(30  ,144 ,255) ;


        }

        private void BTNPackage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UCgestionPackage(), sender);
            Panel2.BackgroundColor = Color.FromArgb(255, 215, 0);


        }

     
        private void BTNVendeur_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UcGestionVendeur(), sender);
            Panel2.BackgroundColor = Color.FromArgb(255, 140, 0);
        }

        private void btnPaiment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UCGestionPaiment(), sender);
            Panel2.BackgroundColor = Color.FromArgb(0, 250, 154);
        }

      
        

        private void BTNAchat_Click(object sender, EventArgs e)
        {

            OpenChildForm(new UCgetionAchats(), sender);
            Panel2.BackgroundColor = Color.FromArgb(128, 0, 0);
        }

        private void BTNutilisateur_Click(object sender, EventArgs e)
        {
            FormSignIn frm = new FormSignIn();
            frm.Show(); 
            
        }

        private void BTNfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNstatistique_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserControl1(), sender);
            Panel2.BackgroundColor = Color.FromArgb(210, 180, 140);

        }

        private void BTNPrésence_Click(object sender, EventArgs e)
        {
            OpenChildForm(new uccPresence(), sender);
            Panel2.BackgroundColor = Color.FromArgb(255, 140, 0);
        }

      

        private void BTNQuitter_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnSeconnecter f = new btnSeconnecter();
            f.Show();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }



        }

        private void BTNredire_Click(object sender, EventArgs e)
        {
            
        }

        private void FormGestionnaire_Load(object sender, EventArgs e)
        {
            PAnelDesktop.BackgroundImage = Properties.Resources.image;
            
        }

        private void PAnelDesktop_Click(object sender, EventArgs e)
        {

        }
    }
}
