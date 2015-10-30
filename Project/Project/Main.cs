using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// HEY :) I see the work of the last file i put on drive st


namespace Project
{
    public partial class frmMain : Form
    {
        CalendarDataList myCalendar = new CalendarDataList();
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
            lblLogin.Text = "Logged in as " + currentUser.Username;
            myCalendar.ReadDataFromFile();
            panelEventView.Show();
            pnl2.Hide();

            //--------------------------------------------------------------
            // Set label data to empty load state
            lbl1stSubject.Text = "Subject : ";
            lbl1stStart.Text = "Start : ";
            lbl1stEnd.Text = "End : ";

            lblLastSubject.Text = "Subject : ";
            lblLastStart.Text = "Start : ";
            lblLastEnd.Text = "End : ";

            //--------------------------------------------------------------
            setFirstClassData();
            
        }
        // Ill Check this asap.. im seeing double already :(
        public void setFirstClassData()
        {
            
            bool ClassFound = false;

            if ((!(string.IsNullOrWhiteSpace(textBox1.Text))) || ClassFound == false)
            {
                lbl1stSubject.Text = "Subject : " + textBox1.Text;
                ClassFound = true;
            }

            else if ((!(string.IsNullOrWhiteSpace(textBox2.Text))) || ClassFound == false)
            {
                lbl1stSubject.Text = "Subject : " + textBox2.Text;
                ClassFound = true;
            }

            else if ((!(string.IsNullOrWhiteSpace(textBox3.Text))) || ClassFound == false)
            {
                lbl1stSubject.Text = "Subject : " + textBox3.Text;
                ClassFound = true;
            }

            else if ((!(string.IsNullOrWhiteSpace(textBox4.Text))) || ClassFound == false)
            {
                lbl1stSubject.Text = "Subject : " + textBox4.Text;
                ClassFound = true;
            }

            else if ((!(string.IsNullOrWhiteSpace(textBox5.Text))) || ClassFound == false)
            {
                lbl1stSubject.Text = "Subject : " + textBox5.Text;
                ClassFound = true;
            }

            else if ((!(string.IsNullOrWhiteSpace(textBox6.Text))) || ClassFound == false)
            {
                lbl1stSubject.Text = "Subject : " + textBox6.Text;
                ClassFound = true;
            }

            else if ((!(string.IsNullOrWhiteSpace(textBox7.Text))) || ClassFound == false)
            {
                lbl1stSubject.Text = "Subject : " + textBox7.Text;
                ClassFound = true;
            }

            else if ((!(string.IsNullOrWhiteSpace(textBox8.Text))) || ClassFound == false)
            {
                lbl1stSubject.Text = "Subject : " + textBox8.Text;
                ClassFound = true;
            }

            else if ((!(string.IsNullOrWhiteSpace(textBox9.Text))) || ClassFound == false)
            {
                lbl1stSubject.Text = "Subject : " + textBox9.Text;
                ClassFound = true;
            }

            else if ((!(string.IsNullOrWhiteSpace(textBox10.Text))) || ClassFound == false)
            {
                lbl1stSubject.Text = "Subject : " + textBox10.Text;
                ClassFound = true;
            }

            else if ((!(string.IsNullOrWhiteSpace(textBox11.Text))) || ClassFound == false)
            {
                lbl1stSubject.Text = "Subject : " + textBox11.Text;
                ClassFound = true;
            }
            else
            {
                lbl1stSubject.Text = "Subject : NON FOR DAY";
            }
            
        }

        public void setLastClassData()
        {
            for (int i = 11; i > 0; i--)
            {
                
            }
        }


        private void lnklblMainLogout_Click(object sender, EventArgs e)
        {
            myCalendar.WriteDataToFile();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            //Reset Data
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";

            for(int i = 0; i < myCalendar.Count();i++)
            {
                if(myCalendar[i].getUser() == currentUser.Username)
                {
                    if(myCalendar[i].getEvent() == monthCalendar.SelectionStart)
                    {
                        textBox1.Text = myCalendar[i].TimeSlot1;
                        textBox2.Text = myCalendar[i].TimeSlot2;
                        textBox3.Text = myCalendar[i].TimeSlot3;
                        textBox4.Text = myCalendar[i].TimeSlot4;
                        textBox5.Text = myCalendar[i].TimeSlot5;
                        textBox6.Text = myCalendar[i].TimeSlot6;
                        textBox7.Text = myCalendar[i].TimeSlot7;
                        textBox8.Text = myCalendar[i].TimeSlot8;
                        textBox9.Text = myCalendar[i].TimeSlot9;
                        textBox10.Text = myCalendar[i].TimeSlot10;
                        textBox11.Text = myCalendar[i].TimeSlot11;

                    }
                    
                }
            }
            setFirstClassData();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            frmAddEvent newEvent = new frmAddEvent();
            newEvent.passData(ref myCalendar,ref currentUser);
            newEvent.ShowDialog();
        }

        private void lbl1stSubject_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateUserData_Click(object sender, EventArgs e)
        {
            panelEventView.Hide();
            pnl2.Show();
            lblCName.Text = currentUser.Username;
            lblCPassword.Text = currentUser.Password;
            lblCEmail.Text = currentUser.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newUer, newPass, newEmail;
            bool allFieldCorrect = true;

            if (tbUserName.Text == "")
            {
                newUer = currentUser.Username;
            }
            else
            {
                newUer = tbUserName.Text;
            }

            if (tbPassw.Text == "")
            {
                newPass = currentUser.Password;
            }
            else
            {
                newPass = tbPassw.Text;
            }

            if (tbEmailAddress.Text == "")
            {
                newEmail = currentUser.Email;
            }
            else
            {
                newEmail = tbEmailAddress.Text;
            }

            if (newUer != tbValidateUsername.Text)
            {
                allFieldCorrect = false;
                MessageBox.Show("ERROR : The username fields do not match.");
            }

            if (newPass != tbValidatePassw.Text)
            {
                allFieldCorrect = false;
                MessageBox.Show("ERROR : The password fields do not match.");
            }

            if (allFieldCorrect)
            {
                //Update the data
            }
          
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            panelEventView.Show();
            pnl2.Hide();
        }
    }
}
