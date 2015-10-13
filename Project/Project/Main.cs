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
           
            lblMainUser.Text = "Welcome " + currentUser.Username;
            lblEmail.Text = currentUser.Email;
            lblName.Text = currentUser.Username;
            lblDatejoined.Text = Convert.ToString(currentUser.SignupDate);
        }

        private void lnklblMainLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBxChangemail_Click(object sender, EventArgs e)
        {
            txtBxChangemail.Text = "";
            txtBxChangemail.ForeColor = Color.Black;
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
            currentUser.Email = txtBxChangemail.Text;
            DataChanged = true;
            MessageBox.Show("Email Updated Successfully!");
            lblEmail.Text = currentUser.Email;
            txtBxChangemail.ForeColor = Color.Gray;
            txtBxChangemail.Text = "Email Address";
        }
    }
}
