using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionParking
{
    class info
    {
        private string username;
        private string password;
        private int telephone;
        private string email;
        private string username2;
        private string password2;
        public info(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public info(string _username2, string _password2, string _email, int _telephone)
        {
            this.Username2 = _username2;
            this.Password2 = _password2;
            this.Email = _email;
            this.Telephone = _telephone;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        public string Username2 { get => username2; set => username2 = value; }
        public string Password2 { get => password2; set => password2 = value; }
    }
}
