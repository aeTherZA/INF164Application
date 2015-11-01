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
            
            panelDelete.Hide();
            pnl2.Show();
            panelEventView.Hide();
            lblCName.Text = currentUser.Username;
            lblCPassword.Text = currentUser.Password;
            lblCEmail.Text = currentUser.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newUer = "", newPass = "", newEmail = "";
            bool allFieldCorrect = true;

            if (tbUserName.Text != "")
            {
                
                newUer = tbUserName.Text;
            }
          
            if (tbPassw.Text != "")
            {
                newPass = tbPassw.Text;
                
            }
            if (tbEmailAddress.Text != "")
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

                
                

                if (newUer != "")
                {
                    DataChanged = true;
                    currentUser.Username = newUer;
                    //Update Calendar User
                    for (int i = 0; i < myCalendar.Count; i++)
                    {
                        if (myCalendar[i].getUser() == currentUser.Username)
                        {
                            myCalendar[i].setUser(newUer);
                        }
                    }
                    lblLogin.Text = "Logged in as " + currentUser.Username;
                }
                if(newPass != "")
                {
                    DataChanged = true;
                    currentUser.Password = newPass;
                }
                if(newEmail != "")
                {
                    DataChanged = true;
                    currentUser.Email = newEmail;
                }

                tbEmailAddress.Text = "";
                tbPassw.Text = "";
                tbValidatePassw.Text = "";
                tbValidateUsername.Text = "";
                tbUserName.Text = "";
                
                //Display new data.
                lblCName.Text = currentUser.Username;
                lblCPassword.Text = currentUser.Password;
                lblCEmail.Text = currentUser.Email;


                
            }
          
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            pnl2.Hide();
            panelEventView.Show();
            panelDelete.Hide();
           
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnl2.Hide();
            panelDelete.Show();
            panelEventView.Hide();
            
            reinitializeDataGridDelete();
          
            
            
            
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
           

            if (dataGridDelete.Rows.Count < 2)
            {
                MessageBox.Show("No Data Available to Delete!");
            }
            else
            {

                //Find index of currently selected object in myCalendar.
                string subject = dataGridDelete.Rows[dataGridDelete.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string time = dataGridDelete.Rows[dataGridDelete.CurrentCell.RowIndex].Cells[2].Value.ToString();
                DateTime eventDate = Convert.ToDateTime(dataGridDelete.Rows[dataGridDelete.CurrentCell.RowIndex].Cells[3].Value);
                clearEvent(eventDate, subject, time);
                reinitializeDataGridDelete();
                dataGridDelete.Refresh();
            }
            
            
        }

       
        private void clearEvent(DateTime even,string sub,string time)
        {
            for(int index = 0; index < myCalendar.Count;index++)
            {
                if(even.Date == myCalendar[index].getEvent().Date)
                {
                    if (time == "07:30" && myCalendar[index].TimeSlot1 == sub)
                    {
                        myCalendar[index].TimeSlot1 = "";
                        myCalendar[index].LocationEvent1 = "";
                    }
                    else if (time == "08:30" && myCalendar[index].TimeSlot2 == sub)
                    {
                        myCalendar[index].TimeSlot2 = "";
                        myCalendar[index].LocationEvent2 = "";
                    }
                    else if (time == "09:30" && myCalendar[index].TimeSlot3 == sub)
                    {
                        myCalendar[index].TimeSlot3 = "";
                        myCalendar[index].LocationEvent3 = "";
                    }
                    else if (time == "10:30" && myCalendar[index].TimeSlot4 == sub)
                    {
                        myCalendar[index].TimeSlot4 = "";
                        myCalendar[index].LocationEvent4 = "";
                    }
                    else if (time == "11:30" && myCalendar[index].TimeSlot5 == sub)
                    {
                        myCalendar[index].TimeSlot5 = "";
                        myCalendar[index].LocationEvent5 = "";
                    }
                    else if (time == "12:30" && myCalendar[index].TimeSlot6 == sub)
                    {
                        myCalendar[index].TimeSlot6 = "";
                        myCalendar[index].LocationEvent6 = "";
                    }
                    else if (time == "13:30" && myCalendar[index].TimeSlot7 == sub)
                    {
                        myCalendar[index].TimeSlot7 = "";
                        myCalendar[index].LocationEvent7 = "";
                    }
                    else if (time == "14:30" && myCalendar[index].TimeSlot8 == sub)
                    {
                        myCalendar[index].TimeSlot8 = "";
                        myCalendar[index].LocationEvent8 = "";
                    }
                    else if (time == "15:30" && myCalendar[index].TimeSlot9 == sub)
                    {
                        myCalendar[index].TimeSlot9 = "";
                        myCalendar[index].LocationEvent9 = "";
                    }
                    else if (time == "16:30" && myCalendar[index].TimeSlot10 == sub)
                    {
                        myCalendar[index].TimeSlot10 = "";
                        myCalendar[index].LocationEvent10 = "";
                    }
                    else if (time == "17:30" && myCalendar[index].TimeSlot11 == sub)
                    {
                        myCalendar[index].TimeSlot11 = "";
                        myCalendar[index].LocationEvent11 = "";
                    }

                }
            }
            
        }
        private void reinitializeDataGridDelete()
        {
            //Clear datagrid.
            do
            {
                foreach (DataGridViewRow row in dataGridDelete.Rows)
                {
                    try
                    {
                        dataGridDelete.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridDelete.Rows.Count > 1);

            //Initialise datagrid with objects.
            for (int i = 0; i < myCalendar.Count; i++)
            {
                if (myCalendar[i].getUser() == currentUser.Username)
                {
                    if (myCalendar[i].TimeSlot1 != "")
                    {
                        dataGridDelete.Rows.Add(myCalendar[i].TimeSlot1, myCalendar[i].LocationEvent1, "07:30", myCalendar[i].getEvent().ToString("D"));
                    }
                    if (myCalendar[i].TimeSlot2 != "")
                    {
                        dataGridDelete.Rows.Add(myCalendar[i].TimeSlot2, myCalendar[i].LocationEvent2, "08:30", myCalendar[i].getEvent().ToString("D"));
                    }
                    if (myCalendar[i].TimeSlot3 != "")
                    {
                        dataGridDelete.Rows.Add(myCalendar[i].TimeSlot3, myCalendar[i].LocationEvent3, "09:30", myCalendar[i].getEvent().ToString("D"));
                    }
                    if (myCalendar[i].TimeSlot4 != "")
                    {
                        dataGridDelete.Rows.Add(myCalendar[i].TimeSlot4, myCalendar[i].LocationEvent4, "10:30", myCalendar[i].getEvent().ToString("D"));
                    }
                    if (myCalendar[i].TimeSlot5 != "")
                    {
                        dataGridDelete.Rows.Add(myCalendar[i].TimeSlot5, myCalendar[i].LocationEvent5, "11:30", myCalendar[i].getEvent().ToString("D"));
                    }
                    if (myCalendar[i].TimeSlot6 != "")
                    {
                        dataGridDelete.Rows.Add(myCalendar[i].TimeSlot6, myCalendar[i].LocationEvent6, "12:30", myCalendar[i].getEvent().ToString("D"));
                    }
                    if (myCalendar[i].TimeSlot7 != "")
                    {
                        dataGridDelete.Rows.Add(myCalendar[i].TimeSlot7, myCalendar[i].LocationEvent7, "13:30", myCalendar[i].getEvent().ToString("D"));
                    }
                    if (myCalendar[i].TimeSlot8 != "")
                    {
                        dataGridDelete.Rows.Add(myCalendar[i].TimeSlot8, myCalendar[i].LocationEvent8, "14:30", myCalendar[i].getEvent().ToString("D"));
                    }
                    if (myCalendar[i].TimeSlot9 != "")
                    {
                        dataGridDelete.Rows.Add(myCalendar[i].TimeSlot9, myCalendar[i].LocationEvent9, "15:30", myCalendar[i].getEvent().ToString("D"));
                    }
                    if (myCalendar[i].TimeSlot10 != "")
                    {
                        dataGridDelete.Rows.Add(myCalendar[i].TimeSlot10, myCalendar[i].LocationEvent10, "16:30", myCalendar[i].getEvent().ToString("D"));
                    }
                    if (myCalendar[i].TimeSlot11 != "")
                    {
                        dataGridDelete.Rows.Add(myCalendar[i].TimeSlot11, myCalendar[i].LocationEvent11, "17:30", myCalendar[i].getEvent().ToString("D"));
                    }
                }
            }

        }
    }
}
