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
            refresh();
            panelEventView.Show();
            lbl1stSubject.Text = firstClass(ref myCalendar);
            lblLastSubject.Text = lastClass(ref myCalendar);
            pnl2.Hide();
          
            
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
            myCalendar.WriteDataToFile();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            frmAddEvent newEvent = new frmAddEvent();
            newEvent.passData(ref myCalendar,ref currentUser);
            newEvent.ShowDialog();
            newEvent.retrieveData(ref myCalendar);
            
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

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            refresh();
            lbl1stSubject.Text = firstClass(ref myCalendar);
            lblLastSubject.Text = lastClass(ref myCalendar);
        }

        private void refresh()
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

            for (int i = 0; i < myCalendar.Count(); i++)
            {
                if (myCalendar[i].getUser() == currentUser.Username)
                {
                    if (myCalendar[i].getEvent() == monthCalendar.SelectionStart)
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
        }
        private string firstClass(ref CalendarDataList obj)
        {
            
            for (int i = 0; i < obj.Count; i++)
            {
                if (obj[i].getUser() == currentUser.Username)
                {
                    if (obj[i].getEvent() == monthCalendar.SelectionStart)
                    {
                        if(obj[i].TimeSlot1 != "")
                        {
                            lbl1stStart.Text = "Start - 07:30";
                            lbl1stEnd.Text = "End - 08:30";
                            lbl1stLocation.Text = obj[i].LocationEvent1;
                            return obj[i].TimeSlot1;
                        }
                        if (obj[i].TimeSlot2 != "")
                        {
                            lbl1stStart.Text = "Start - 08:30";
                            lbl1stEnd.Text = "End - 09:30";
                            lbl1stLocation.Text = obj[i].LocationEvent2;
                            return obj[i].TimeSlot2;
                        }
                        if (obj[i].TimeSlot3 != "")
                        {
                            lbl1stStart.Text = "Start - 09:30";
                            lbl1stEnd.Text = "End - 10:30";
                            lbl1stLocation.Text = obj[i].LocationEvent3;
                            return obj[i].TimeSlot3;
                        }
                        if (obj[i].TimeSlot4 != "")
                        {
                            lbl1stStart.Text = "Start - 10:30";
                            lbl1stEnd.Text = "End - 11:30";
                            lbl1stLocation.Text = obj[i].LocationEvent4;
                            return obj[i].TimeSlot4;
                        }
                        if (obj[i].TimeSlot5 != "")
                        {
                            lbl1stStart.Text = "Start - 11:30";
                            lbl1stEnd.Text = "End - 12:30";
                            lbl1stLocation.Text = obj[i].LocationEvent5;
                            return obj[i].TimeSlot5;
                        }
                        if (obj[i].TimeSlot6 != "")
                        {
                            lbl1stStart.Text = "Start - 12:30";
                            lbl1stEnd.Text = "End - 13:30";
                            lbl1stLocation.Text = obj[i].LocationEvent6;
                            return obj[i].TimeSlot6;
                        }
                        if (obj[i].TimeSlot7 != "")
                        {
                            lbl1stStart.Text = "Start - 13:30";
                            lbl1stEnd.Text = "End - 14:30";
                            lbl1stLocation.Text = obj[i].LocationEvent7;
                            return obj[i].TimeSlot7;
                        }
                        if (obj[i].TimeSlot8 != "")
                        {
                            lbl1stStart.Text = "Start - 14:30";
                            lbl1stEnd.Text = "End - 15:30";
                            lbl1stLocation.Text = obj[i].LocationEvent8;
                            return obj[i].TimeSlot8;
                        }
                        if (obj[i].TimeSlot9 != "")
                        {
                            lbl1stStart.Text = "Start - 15:30";
                            lbl1stEnd.Text = "End - 16:30";
                            lbl1stLocation.Text = obj[i].LocationEvent9;
                            return obj[i].TimeSlot9;
                        }
                        if (obj[i].TimeSlot10 != "")
                        {
                            lbl1stStart.Text = "Start - 16:30";
                            lbl1stEnd.Text = "End - 17:30";
                            lbl1stLocation.Text = obj[i].LocationEvent10;
                            return obj[i].TimeSlot10;

                        }
                        if (obj[i].TimeSlot11 != "")
                        {
                            lbl1stStart.Text = "Start - 17:30";
                            lbl1stEnd.Text = "End - 18:30";
                            lbl1stLocation.Text = obj[i].LocationEvent11;
                            return obj[i].TimeSlot11;
                        }
                    }
                   
                }
                
                
            }
            return "Nothing Scheduled";
        }
        private string lastClass(ref CalendarDataList obj)
        {
            
            for(int i = obj.Count-1;i >= 0;i--)
            {
                if(obj[i].getUser() == currentUser.Username)
                {
                    if(obj[i].getEvent() == monthCalendar.SelectionStart)
                    {
                        if (obj[i].TimeSlot11 != "")
                        {
                            lblLastStart.Text = "Start - 17:30";
                            lblLastEnd.Text = "End - 18:30";
                            lblLastLocation.Text = obj[i].LocationEvent11;
                            return obj[i].TimeSlot11;
                        }
                        if (obj[i].TimeSlot10 != "")
                        {
                            lblLastStart.Text = "Start - 16:30";
                            lblLastEnd.Text = "End - 17:30";
                            lblLastLocation.Text = obj[i].LocationEvent10;
                            return obj[i].TimeSlot10;
                        }
                        if (obj[i].TimeSlot9 != "")
                        {
                            lblLastStart.Text = "Start - 15:30";
                            lblLastEnd.Text = "End - 16:30";
                            lblLastLocation.Text = obj[i].LocationEvent9;
                            return obj[i].TimeSlot9;
                        }
                        if (obj[i].TimeSlot8 != "")
                        {
                            lblLastStart.Text = "Start - 14:30";
                            lblLastEnd.Text = "End - 15:30";
                            lblLastLocation.Text = obj[i].LocationEvent8;
                            return obj[i].TimeSlot8;
                        }
                        if (obj[i].TimeSlot7 != "")
                        {
                            lblLastStart.Text = "Start - 13:30";
                            lblLastEnd.Text = "End - 14:30";
                            lblLastLocation.Text = obj[i].LocationEvent7;
                            return obj[i].TimeSlot7;
                        }
                        if (obj[i].TimeSlot6 != "")
                        {
                            lblLastStart.Text = "Start - 12:30";
                            lblLastEnd.Text = "End - 13:30";
                            lblLastLocation.Text = obj[i].LocationEvent6;
                            return obj[i].TimeSlot6;
                        }
                        if (obj[i].TimeSlot5 != "")
                        {
                            lblLastStart.Text = "Start - 11:30";
                            lblLastEnd.Text = "End - 12:30";
                            lblLastLocation.Text = obj[i].LocationEvent5;
                            return obj[i].TimeSlot5;
                        }
                        if (obj[i].TimeSlot4 != "")
                        {
                            lblLastStart.Text = "Start - 10:30";
                            lblLastEnd.Text = "End - 11:30";
                            lblLastLocation.Text = obj[i].LocationEvent4;
                            return obj[i].TimeSlot4;
                        }
                        if (obj[i].TimeSlot3 != "")
                        {
                            lblLastStart.Text = "Start - 09:30";
                            lblLastEnd.Text = "End - 10:30";
                            lblLastLocation.Text = obj[i].LocationEvent3;
                            return obj[i].TimeSlot3;
                        }
                        if (obj[i].TimeSlot2 != "")
                        {
                            lblLastStart.Text = "Start - 08:30";
                            lblLastEnd.Text = "End - 09:30";
                            lblLastLocation.Text = obj[i].LocationEvent2;
                            return obj[i].TimeSlot2;
                        }
                        if (obj[i].TimeSlot1 != "")
                        {
                            lblLastStart.Text = " Start - 07:30";
                            lblLastEnd.Text = "End - 08:30";
                            lblLastLocation.Text = obj[i].LocationEvent1;
                            return obj[i].TimeSlot1;
                        }
                    }
                }
            }
            return "Nothing Scheduled";

        }
    }
}
