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
    public partial class frmRegister : Form
    {
        List<Users> sudoDB = new List<Users>();
        bool doNotWrite = false;
        public frmRegister()
        {
            InitializeComponent();
            
        }
        internal void setDB(ref List<Users> users)
        {
            sudoDB.AddRange(users);
        }
        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Check that all boxes are filled.
            int count = 0;

            if (txtBxRegisterEmail.Text == "" || txtBxRegisterEmail.Text == "*")
                {
                    lblEmail.ForeColor = Color.Red;
                    txtBxRegisterEmail.ForeColor = Color.Red;
                    txtBxRegisterEmail.Text = "*";
                    count++;
                    
                    
                }
                else
                {
                    txtBxRegisterEmail.ForeColor = Color.Black;
                    
                   

                }
                if (txtBxRegisterUser.Text == "" || txtBxRegisterUser.Text == "*")
                {
                    lblUsername.ForeColor = Color.Red;
                    txtBxRegisterUser.ForeColor = Color.Red;
                    txtBxRegisterUser.Text = "*";
                    count++;
                    
                    
                }
                else
                {
                    txtBxRegisterUser.ForeColor = Color.Black;
                   
                    

                }
                if (txtBxRegisterPass.Text == "" || txtBxRegisterPass.Text == "*")
                {
                    lblPass.ForeColor = Color.Red;
                    txtBxRegisterPass.ForeColor = Color.Red;
                    txtBxRegisterPass.Text = "*";
                    count++;
                    
                }
                else
                {
                    txtBxRegisterPass.ForeColor = Color.Black;
                    
                    
                }

            if(count > 0)
            {
                //Display something about Missing fields.
                doNotWrite = true;
            }
            else
            {
               //Add the given details into the list.
                bool test = exists(ref sudoDB, txtBxRegisterUser.Text);
                if (test)
                {
                    MessageBox.Show("Username already exists");
                    txtBxRegisterUser.Text = "";
                    txtBxRegisterPass.Text = "";
                    doNotWrite = true;
                }
                else
                {
                    sudoDB.Add(new Users(txtBxRegisterUser.Text, txtBxRegisterPass.Text, txtBxRegisterEmail.Text, Convert.ToString(DateTime.Now)));
                    this.Close();
                }
                
                
            }

            
           

            
        }

        private void txtBxRegisterUser_MouseDown(object sender, MouseEventArgs e)
        {


            lblUsername.ForeColor = Color.Black;
                txtBxRegisterUser.ForeColor = Color.Black;
                txtBxRegisterUser.Text = "";
            
          
        }

        private void txtBxRegisterPass_MouseDown(object sender, MouseEventArgs e)
        {
            lblPass.ForeColor = Color.Black;
                txtBxRegisterPass.ForeColor = Color.Black;
                txtBxRegisterPass.Text = "";
            
        }

        private void txtBxRegisterEmail_MouseDown(object sender, MouseEventArgs e)
        {
            lblEmail.ForeColor = Color.Black;
                txtBxRegisterEmail.ForeColor = Color.Black;
                txtBxRegisterEmail.Text = "";
            
        }

   
        internal void updateDBList(ref List<Users> users)
        {
            users = new List<Users>();
            users.AddRange(sudoDB);
        }

        public void mustWrite(ref bool choice)
        {
            choice = doNotWrite;
        }

        private bool exists(ref List<Users> users,string possibleusername)
        {
            bool doesExist = false;
            for(int i = 0; i < users.Count;i++)
            {
                if(possibleusername == users[i].Username)
                {
                    doesExist = true;
                    break;
                }
            }
            return doesExist;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            
        }
    }


}
