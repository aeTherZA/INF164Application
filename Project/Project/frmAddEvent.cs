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
    public partial class frmAddEvent : Form
    {
        CalendarDataList sudoData = new CalendarDataList();
        Users currentUser;
        public frmAddEvent()
        {
            InitializeComponent();
        }

        private void lblEventName_Click(object sender, EventArgs e)
        {

        }

        public void passData(ref CalendarDataList obj,ref Users user)
        {
            sudoData = obj;
            currentUser = user;
        }
        private void initializeTimeslots()
        {
            for (int i = 0; i < sudoData.Count;i++ )
            {
                if(sudoData[i].getUser() == currentUser.Username)
                {
                    if(sudoData[i].getEvent() == monthCalendarAddEvent.SelectionStart)
                    {
                        if(sudoData[i].TimeSlot1 != "")
                        {
                            dropDownEvents.Items[0] = ("07:30-08:30 - " + sudoData[i].TimeSlot1);
                        }
                        else
                        {
                            dropDownEvents.Items[0] = ("07:30-08:30 - Available");
                        }
                        if(sudoData[i].TimeSlot2 != "")
                        {
                            dropDownEvents.Items[1] = ("08:30-09:30 - " + sudoData[i].TimeSlot2);
                        }
                        else
                        {
                            dropDownEvents.Items[1] = ("08:30-09:30 - Available");
                        }
                        if(sudoData[i].TimeSlot3 != "")
                        {
                            dropDownEvents.Items[2] = ("09:30-10:30 - " + sudoData[i].TimeSlot3);
                        }
                        else
                        {
                            dropDownEvents.Items[2] = ("09:30-10:30 - Available");
                        }
                        if(sudoData[i].TimeSlot4 != "")
                        {
                            dropDownEvents.Items[3] = ("10:30-11:30 - " + sudoData[i].TimeSlot4);
                        }
                        else
                        {
                            dropDownEvents.Items[3] = ("10:30-11:30 - Available");
                        }
                        if(sudoData[i].TimeSlot5 != "")
                        {
                            dropDownEvents.Items[4] = ("11:30-12:30 - " + sudoData[i].TimeSlot5);

                        }
                        else
                        {
                            dropDownEvents.Items[4] = ("11:30-12:30 - Available");
                        }
                        if(sudoData[i].TimeSlot6 != "")
                        {
                            dropDownEvents.Items[5] = ("12:30-13:30 - " + sudoData[i].TimeSlot6);
                        }
                        else
                        {
                            dropDownEvents.Items[5] = ("12:30-13:30 - Available");
                        }
                        if(sudoData[i].TimeSlot7 != "")
                        {
                            dropDownEvents.Items[6] = ("13:30-14:30 - " + sudoData[i].TimeSlot7);
                        }
                        else
                        {
                            dropDownEvents.Items[6] = ("13:30-14:30 - " + sudoData[i].TimeSlot7);
                        }
                        if(sudoData[i].TimeSlot8 != "")
                        {
                            dropDownEvents.Items[7] = ("14:30-15:30 - " + sudoData[i].TimeSlot8);
                        }
                        else
                        {
                            dropDownEvents.Items[7] = ("14:30-15:30 - Available");
                        }
                        if(sudoData[i].TimeSlot9 != "")
                        {
                            dropDownEvents.Items[8] = ("15:30-16:30 - " + sudoData[i].TimeSlot9);
                        }
                        else
                        {
                            dropDownEvents.Items[8] = ("15:30-16:30 - Available");
                        }
                        if(sudoData[i].TimeSlot10 != "")
                        {
                            dropDownEvents.Items[9] = ("16:30-17:30 - " + sudoData[i].TimeSlot10);
                        }
                        else
                        {
                            dropDownEvents.Items[9] = ("16:30-17:30 - Available");
                        }
                        if(sudoData[i].TimeSlot11 != "")
                        {
                            dropDownEvents.Items[10] = ("17:30-18:30 - " + sudoData[i].TimeSlot11);
                        }
                        else
                        {
                            dropDownEvents.Items[10] = ("17:30-18:30 - Available");
                        }
                    }
                }
            }
                
            
            
            
            
            
            
            
            
            
            
            
        }
        private void frmAddEvent_Load(object sender, EventArgs e)
        {
            
        }

     

        private void monthCalendarAddEvent_DateSelected(object sender, DateRangeEventArgs e)
        {
            initializeTimeslots();
            lblCurrentDate.Text = "Currently Selected: " + monthCalendarAddEvent.SelectionStart.ToString("D");
            refreshData();
            
         
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            //Check for Input
            if ((txtBxEventName.Text == "") || (txtBxEventName.Text == "*"))
            {
                txtBxEventName.ForeColor = Color.Yellow;
                lblSubject.ForeColor = Color.Yellow;
                txtBxEventName.Text = "*";
                MessageBox.Show("Fill In Event");
                
            }
            else
            {
                //Check if it exists
                bool exists = false;
                for(int i = 0; i < sudoData.Count;i++)
                {
                    if(sudoData[i].getUser() == currentUser.Username)
                    {
                        if(sudoData[i].getEvent() == monthCalendarAddEvent.SelectionStart)
                        {
                            exists = true;
                            break;
                            
                        }
                    }
                }
                
                    if(exists)
                    {
                        //Modify

                        //Traverse through to find specific day in the data list.
                        for(int index = 0; index < sudoData.Count;index++)
                        {
                            if(sudoData[index].getUser() == currentUser.Username)
                            {
                                if(sudoData[index].getEvent() == monthCalendarAddEvent.SelectionStart)
                                {
                                    //Found the object we need.
                                    
                                    switch(dropDownEvents.SelectedIndex)
                                    {
                                        case 0:
                                            if(sudoData[index].TimeSlot1 == "")
                                            {
                                                sudoData[index].TimeSlot1 = txtBxEventName.Text;
                                            }
                                            break;
                                        case 1:
                                            if (sudoData[index].TimeSlot2 == "")
                                            {
                                                sudoData[index].TimeSlot2 = txtBxEventName.Text;
                                            }
                                            break;
                                        case 2:
                                            if (sudoData[index].TimeSlot3 == "")
                                            {
                                                sudoData[index].TimeSlot3 = txtBxEventName.Text;
                                            }
                                            break;
                                        case 3:
                                            if (sudoData[index].TimeSlot4 == "")
                                            {
                                                sudoData[index].TimeSlot4 = txtBxEventName.Text;
                                            }
                                            break;
                                        case 4:
                                            if (sudoData[index].TimeSlot5 == "")
                                            {
                                                sudoData[index].TimeSlot5 = txtBxEventName.Text;
                                            }
                                            break;
                                        case 5:
                                            if (sudoData[index].TimeSlot6 == "")
                                            {
                                                sudoData[index].TimeSlot6 = txtBxEventName.Text;
                                            }
                                            break;
                                        case 6:
                                            if (sudoData[index].TimeSlot7 == "")
                                            {
                                                sudoData[index].TimeSlot7 = txtBxEventName.Text;
                                            }
                                            break;
                                        case 7:
                                            if (sudoData[index].TimeSlot8 == "")
                                            {
                                                sudoData[index].TimeSlot8 = txtBxEventName.Text;
                                            }
                                            break;
                                        case 8:
                                            if (sudoData[index].TimeSlot9 == "")
                                            {
                                                sudoData[index].TimeSlot9 = txtBxEventName.Text;
                                            }
                                            break;
                                        case 9:
                                            if (sudoData[index].TimeSlot10 == "")
                                            {
                                                sudoData[index].TimeSlot10 = txtBxEventName.Text;
                                            }
                                            break;
                                        case 10:
                                            if (sudoData[index].TimeSlot11 == "")
                                            {
                                                sudoData[index].TimeSlot11 = txtBxEventName.Text;
                                            }
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        //Create new element
                        sudoData.Add(new CalendarData(monthCalendarAddEvent.SelectionStart, currentUser.Username));

                        //Add Selected Timeslot
                        switch (dropDownEvents.SelectedIndex)
                        {
                            case 0:
                                sudoData[sudoData.Count-1].TimeSlot1 = txtBxEventName.Text;

                                break;
                            case 1:
                                sudoData[sudoData.Count - 1].TimeSlot2 = txtBxEventName.Text;

                                break;
                            case 2:
                                sudoData[sudoData.Count - 1].TimeSlot3 = txtBxEventName.Text;

                                break;
                            case 3:
                                sudoData[sudoData.Count - 1].TimeSlot4 = txtBxEventName.Text;

                                break;
                            case 4:
                                sudoData[sudoData.Count - 1].TimeSlot5 = txtBxEventName.Text;

                                break;
                            case 5:
                                sudoData[sudoData.Count - 1].TimeSlot6 = txtBxEventName.Text;
                                break;
                            case 6:
                                sudoData[sudoData.Count - 1].TimeSlot7 = txtBxEventName.Text;
                                break;
                            case 7:
                                sudoData[sudoData.Count - 1].TimeSlot8 = txtBxEventName.Text;
                                break;
                            case 8:
                                sudoData[sudoData.Count - 1].TimeSlot9 = txtBxEventName.Text;
                                break;
                            case 9:
                                sudoData[sudoData.Count - 1].TimeSlot10 = txtBxEventName.Text;
                                break;
                            case 10:
                                sudoData[sudoData.Count - 1].TimeSlot11 = txtBxEventName.Text;
                                break;

                        }
                        
                    }

            }

                refreshData();
                txtBxEventName.Text = "";
                dropDownEvents.SelectedText = "";
                

            }

        private void refreshData()
        {
            bool doesExist = false;
            for (int i = 0; i < sudoData.Count(); i++)
            {
                if (sudoData[i].getUser() == currentUser.Username)
                {
                    if (sudoData[i].getEvent() == monthCalendarAddEvent.SelectionStart)
                    {
                        doesExist = true;

                        if (sudoData[i].TimeSlot1 != "")
                        {
                            dropDownEvents.Items[0] = ("07:30-08:30 - " + sudoData[i].TimeSlot1);
                        }
                        else
                        {
                            dropDownEvents.Items[0] = ("07:30-08:30 - Available");
                        }
                        if (sudoData[i].TimeSlot2 != "")
                        {
                            dropDownEvents.Items[1] = ("08:30-09:30 - " + sudoData[i].TimeSlot2);
                        }
                        else
                        {
                            dropDownEvents.Items[1] = ("08:30-09:30 - Available");
                        }
                        if (sudoData[i].TimeSlot3 != "")
                        {
                            dropDownEvents.Items[2] = ("09:30-10:30 - " + sudoData[i].TimeSlot3);
                        }
                        else
                        {
                            dropDownEvents.Items[2] = ("09:30-10:30 - Available");
                        }
                        if (sudoData[i].TimeSlot4 != "")
                        {
                            dropDownEvents.Items[3] = ("10:30-11:30 - " + sudoData[i].TimeSlot4);
                        }
                        else
                        {
                            dropDownEvents.Items[3] = ("10:30-11:30 - Available");
                        }
                        if (sudoData[i].TimeSlot5 != "")
                        {
                            dropDownEvents.Items[4] = ("11:30-12:30 - " + sudoData[i].TimeSlot5);

                        }
                        else
                        {
                            dropDownEvents.Items[4] = ("11:30-12:30 - Available");
                        }
                        if (sudoData[i].TimeSlot6 != "")
                        {
                            dropDownEvents.Items[5] = ("12:30-13:30 - " + sudoData[i].TimeSlot6);
                        }
                        else
                        {
                            dropDownEvents.Items[5] = ("12:30-13:30 - Available");
                        }
                        if (sudoData[i].TimeSlot7 != "")
                        {
                            dropDownEvents.Items[6] = ("13:30-14:30 - " + sudoData[i].TimeSlot7);
                        }
                        else
                        {
                            dropDownEvents.Items[6] = ("13:30-14:30 - Available");
                        }
                        if (sudoData[i].TimeSlot8 != "")
                        {
                            dropDownEvents.Items[7] = ("14:30-15:30 - " + sudoData[i].TimeSlot8);
                        }
                        else
                        {
                            dropDownEvents.Items[7] = ("14:30-15:30 - Available");
                        }
                        if (sudoData[i].TimeSlot9 != "")
                        {
                            dropDownEvents.Items[8] = ("15:30-16:30 - " + sudoData[i].TimeSlot9);
                        }
                        else
                        {
                            dropDownEvents.Items[8] = ("15:30-16:30 - Available");
                        }
                        if (sudoData[i].TimeSlot10 != "")
                        {
                            dropDownEvents.Items[9] = ("16:30-17:30 - " + sudoData[i].TimeSlot10);
                        }
                        else
                        {
                            dropDownEvents.Items[9] = ("16:30-17:30 - Available");
                        }
                        if (sudoData[i].TimeSlot11 != "")
                        {
                            dropDownEvents.Items[10] = ("17:30-18:30 - " + sudoData[i].TimeSlot11);
                        }
                        else
                        {
                            dropDownEvents.Items[10] = ("17:30-18:30 - Available");
                        }

                       
                    }
                }
              
            }
            if(!doesExist)
            {
                
                        
                           dropDownEvents.Items[0] = ("07:30-08:30 - Available");
                  
                     
                            dropDownEvents.Items[1] = ("08:30-09:30 - Available");
                     
                            dropDownEvents.Items[2] = ("09:30-10:30 - Available");
                     
                            dropDownEvents.Items[3] = ("10:30-11:30 - Available");
                     
                            dropDownEvents.Items[4] = ("11:30-12:30 - Available");
                      
                            dropDownEvents.Items[5] = ("12:30-13:30 - Available");
                      
                            dropDownEvents.Items[6] = ("13:30-14:30 - Available");
                       
                            dropDownEvents.Items[7] = ("14:30-15:30 - Available");
                       
                            dropDownEvents.Items[8] = ("15:30-16:30 - Available");
                      
                            dropDownEvents.Items[9] = ("16:30-17:30 - Available");
                           dropDownEvents.Items[10] = ("17:30-18:30 - Available");
                        
            }
        }

        private void txtBxEventName_Click(object sender, EventArgs e)
        {
            txtBxEventName.ForeColor = Color.Black;
            lblSubject.ForeColor = Color.White;
            txtBxEventName.Text = "";
        }

        }
        
     }
