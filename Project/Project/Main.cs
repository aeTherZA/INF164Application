using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmMain : Form
    {
        Users currentUser;
        int index;
        bool DataChanged = false;
        public frmMain()
        {
            InitializeComponent();
        }

        public void passUser(Users user,int pos)
        {
            if (user != null)
            {
                currentUser = user;
                index = pos;
            }
            else
            {
                index = 0;
                MessageBox.Show("Invalid user, exiting...");
                this.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblLogin.Text = "Welcome " + currentUser.Username;
            
        }

        private void lnklblMainLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBxChangemail_Click(object sender, EventArgs e)
        {
            
        }

        public void retrieveNew(ref List<Users> toModify,int pos)
        {
            toModify[pos] = currentUser;
        }

        public bool dataChanged()
        {
            if(DataChanged)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void btnChangeMail_Click(object sender, EventArgs e)
        {
            
        }

        private void lnklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("You have logged out");
            this.Close();
        }
    }
}
