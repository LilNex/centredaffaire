using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Centre_D_affaire.GestionParking
{
    //test mod
    public class info
    {
        private static string username;
        private  string password;
        private  int telephone;
        private  string email;
        private  string username2;
        private  string password2;

        private string carname;
        private string cartype;
        private int time;

        private int spotNumber;
        private string spotName;

        private string methode;
        private string holderName;
        private string ExperitionDate;
        private double cardNumber;
        private int cvvCode;

        private string time2;
        private string date;
        private string cost;
        public info() { }

        public info(string date,string time2, int time, int spotnum,string carnum,string cost,string payment)
        {
            this.date = date;
            this.time2 = time2;
            this.time = time;
            this.spotNumber = spotnum;
            this.carname = carnum;
            this.cost = cost;
            this.methode = payment;
        }

        public info(string cn, string ct, int time)
        {
            this.carname = cn;
            this.cartype = ct;
            this.Time = time;
        }

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

        public info (int sn, string sname)
        {
            this.spotNumber = sn;
            this.spotName = sname;
        }

        public info(string pm, string hm, string ed, double cn, int cd)
        {
            this.methode = pm;
            this.holderName = hm;
            this.ExperitionDate = ed;
            this.cardNumber = cn;
            this.cvvCode = cd;
        }

        public static string User
        {
            get { return username  ; }
            set { username = value; }
        }
        // or:  public static string Username { get => username; set => username = value; }
        //public static int Telephonee { get => telephone; set => telephone = value; }
        //public static string Passwordd { get => password; set => password = value; }
        //public static string Emaill { get => email; set => email = value; }


        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        public string Username2 { get => username2; set => username2 = value; }
        public string Password2 { get => password2; set => password2 = value; }


        public string Methode { get => methode; set => methode = value; }
        public string HolderName { get => holderName; set => holderName = value; }
        public string ExperitionDate1 { get => ExperitionDate; set => ExperitionDate = value; }
        public double CardNumber { get => cardNumber; set => cardNumber = value; }
        public int CvvCode { get => cvvCode; set => cvvCode = value; }


        public int SpotNumber { get => spotNumber; set => spotNumber = value; }
        public string SpotName { get => spotName; set => spotName = value; }


        public string Carname { get => carname; set => carname = value; }
        public string Cartype { get => cartype; set => cartype = value; }
        public int Time { get => time; set => time = value; }
    }
}
