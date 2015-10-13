using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        List<Users> userDB = new List<Users>();
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Open Data File.
            try
            {
                StreamReader file = new StreamReader("data.txt");

                if (new FileInfo("data.txt").Length == 0)
                {
                    btnLogin.Enabled = false;
                    MessageBox.Show("Please proceed to creating an account, no data present.");

                }
                else
                {

                    populateDB(ref userDB, ref file);
                    
                }
                file.Close();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
                txtBxUser.Text = "Unavailable";
                btnLogin.Enabled = false;
                lnklblSignUp.Enabled = false;
                txtBxPass.Enabled = false;
                txtBxUser.Enabled = false;

            }
            catch (Exception GeneralException)
            {
                MessageBox.Show("Something went wrong: " + GeneralException.Message);
            }
        }

        void populateDB(ref List<Users> users, ref StreamReader stream)
        {
            string line, username, password, email;
            string datejoined;

            while ((line = stream.ReadLine()) != null)
            {
                string[] data = line.Split(' ');
                username = data[0];
                password = data[1];
                email = data[2];
                datejoined = data[3];

                users.Add(new Users(username, password, email, datejoined));

                
            }


        }

        private void lnklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool stop = false;
            frmRegister register = new frmRegister();
            register.setDB(ref userDB);
            register.ShowDialog();
            register.updateDBList(ref userDB);

            register.mustWrite(ref stop);
            if(stop == false)
            {
                //WriteToFile
                WriteToFile(ref userDB);
            }
            
        }

        private void WriteToFile(ref List<Users> users) //For initialisation only.
        {
            StreamWriter write = new StreamWriter("data.txt");
            String dataStream;

            if (new FileInfo("data.txt").Length == 0)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    dataStream = users[i].Username + " " + users[i].Password + " " + users[i].Email + " " + Convert.ToString(users[i].SignupDate);
                    write.WriteLine(dataStream);
                }
                MessageBox.Show("Account Created Successfully, you may now login!");
                write.Close();
            }
            else
            {
               
         
                    dataStream = users[(users.Count) - 1].Username + " " + users[(users.Count) - 1].Password + " " + users[(users.Count) - 1].Email + " " + users[(users.Count) - 1].SignupDate;
                    write.BaseStream.Seek(0, SeekOrigin.End);
                    write.WriteLine(dataStream);
                    MessageBox.Show("Account Created Successfully, you may now login!");


            }
            write.Close();
        }

        private bool CheckDuplicates(ref List<Users> users)
        {
            bool isPresent = false;
            for(int i = 0; i < users.Count;i++)
            {
                if(users[(users.Count)-1].Username == users[i].Username)
                {
                    isPresent = true;
                    break; 
                }
            }
            return isPresent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (txtBxUser.Text == "" || txtBxUser.Text == "*")
            {
                lblUser.ForeColor = Color.Red;
                txtBxUser.ForeColor = Color.Red;
                txtBxUser.Text = "*";
                count++;

            }
            else
            {
                txtBxUser.ForeColor = Color.Black;
                
            }
            if(txtBxPass.Text == "" || txtBxPass.Text == "*")
            {
                lblPass.ForeColor = Color.Red;
                txtBxPass.ForeColor = Color.Red;
                txtBxPass.Text = "*";
                count++;
            }
            else
            {
                txtBxPass.ForeColor = Color.Black;
                
            }
            if (count > 0)
            {
                //Display something about Missing fields.
            }
            else
            {
                int index = 0;
                bool authenticated = false;
                //Check for the username.
                for(;index < userDB.Count;index++)
                {
                    if(userDB[index].Username == txtBxUser.Text)
                    {
                        if(userDB[index].Password == txtBxPass.Text)
                        {
                            MessageBox.Show("Authenticated!");
                            authenticated = true;
                            break;
                            
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password!");
                            break;
                        }

                    }
                }

                if(authenticated)
                {
                    frmMain main = new frmMain();
                    main.passUser(userDB[index],index);
                    main.ShowDialog();
                    if(main.dataChanged())
                    {
                        main.retrieveNew(ref userDB,index);
                        writeLine(ref userDB);
                    }
                }

                


            }
        }

        private void txtBxUser_MouseDown(object sender, MouseEventArgs e)
        {
            lblUser.ForeColor = Color.Black;
            txtBxUser.ForeColor = Color.Black;
            txtBxUser.Text = "";
        }

        private void txtBxPass_MouseDown(object sender, MouseEventArgs e)
        {
            lblPass.ForeColor = Color.Black;
            txtBxPass.ForeColor = Color.Black;
            txtBxPass.Text = "";
        }

        private void writeLine(ref List<Users> data) //For updating of data only
        {
            StreamWriter write = new StreamWriter("data.txt");
            String dataStream;

            if (new FileInfo("data.txt").Length == 0)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    dataStream = data[i].Username + " " + data[i].Password + " " + data[i].Email + " " + Convert.ToString(data[i].SignupDate);
                    write.WriteLine(dataStream);
                }
                
                write.Close();
            }
           
            write.Close();
        }

        

        

    }
}
