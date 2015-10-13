using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{
    public class Users
    {
        private string username;
        private string password;
        private string email;
        private DateTime signupdate;

        public Users(string user,string pass,string mail,string datejoined)
        {
            username = user;
            password = pass;
            email = mail;
            signupdate = Convert.ToDateTime(datejoined).Date;
            
        }

        public string Username
        {
            get { return username; }
        }
        public string Password
        {
            set { password = value;}
            get { return password; }
        }
        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public DateTime SignupDate
        {
            set { signupdate = value; }
            get { return signupdate; }
        }

        public void writeChanges(ref StreamWriter file,int index)
    {

    }
        
    }
}
