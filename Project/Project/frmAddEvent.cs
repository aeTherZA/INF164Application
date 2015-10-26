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
        List<string> timeslots = new List<string>();
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
            
        }
        private void frmAddEvent_Load(object sender, EventArgs e)
        {
            
        }

     

        private void monthCalendarAddEvent_DateSelected(object sender, DateRangeEventArgs e)
        {
            bool inDataBase = false;
            bool hasBeenDone = false;
            lblCurrentDate.Text = "Currently Selected: " + monthCalendarAddEvent.SelectionStart.ToString("D");
            for(int i = 0; i < sudoData.Count();i++)
            {
                if(sudoData[i].getUser() == currentUser.Username)
                {
                    if(sudoData[i].getEvent() == monthCalendarAddEvent.SelectionStart)
                    {
                        inDataBase = true;
                        
                        if(sudoData[i].TimeSlot1 == "")
                        {
                            dropDownEvents.Items[0] += " - Available";
                        }
                        else
                        {
                            dropDownEvents.Items[0] += " -" + sudoData[i].TimeSlot1;
                        }
                        if (sudoData[i].TimeSlot2 == "")
                        {
                            dropDownEvents.Items[1] += " - Available";
                        }
                        else
                        {
                            dropDownEvents.Items[1] += " -" + sudoData[i].TimeSlot2;
                        }
                        if (sudoData[i].TimeSlot3 == "")
                        {
                            timeslots[2] += " - Available";
                        }
                        else
                        {
                            timeslots[2] += " -" + sudoData[i].TimeSlot3;
                        }
                        if (sudoData[i].TimeSlot4 == "")
                        {
                            timeslots[3] += " - Available";
                        }
                        else
                        {
                            timeslots[3] += " -" + sudoData[i].TimeSlot4;
                        }
                        if (sudoData[i].TimeSlot5 == "")
                        {
                            timeslots[4] += " - Available";
                        }
                        else
                        {
                            timeslots[4] += " -" + sudoData[i].TimeSlot5;
                        }
                        if (sudoData[i].TimeSlot6 == "")
                        {
                            timeslots[5] += " - Available";
                        }
                        else
                        {
                            timeslots[5] += " -" + sudoData[i].TimeSlot6;
                        }
                        if (sudoData[i].TimeSlot7 == "")
                        {
                            timeslots[6] += " - Available";
                        }
                        else
                        {
                            timeslots[6] += " -" + sudoData[i].TimeSlot7;
                        }
                        if (sudoData[i].TimeSlot8 == "")
                        {
                            timeslots[7] += " - Available";
                        }
                        else
                        {
                            timeslots[7] += " -" + sudoData[i].TimeSlot8;
                        }
                        if (sudoData[i].TimeSlot9 == "")
                        {
                            timeslots[8] += " - Available";
                        }
                        else
                        {
                            timeslots[8] += " -" + sudoData[i].TimeSlot9;
                        }
                        if (sudoData[i].TimeSlot10 == "")
                        {
                            timeslots[9] += " - Available";
                        }
                        else
                        {
                            timeslots[9] += " -" + sudoData[i].TimeSlot10;
                        }
                        if (sudoData[i].TimeSlot11 == "")
                        {
                            timeslots[10] += " - Available";
                        }
                        else
                        {
                            timeslots[10] += " -" + sudoData[i].TimeSlot11;
                        }
                 }
                }
            }
                    if(inDataBase == false)
                    {
                        if (hasBeenDone == false)
                        {
                            for (int y = 0; y < 11; y++)
                            {

                                dropDownEvents.Items[y] += " - Available";
                                dropDownEvents.Refresh();
                            }
                            hasBeenDone = true;
                        }
                       
                        
                    }

                    
                    
                }
            }
        }
