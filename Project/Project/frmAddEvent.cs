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
        private void initializeTimeSlot()
        {
            timeslots.Add("07:30-08:30");
            timeslots.Add("08:30-09:30");
            timeslots.Add("09:30-10:30");
            timeslots.Add("10:30-11:30");
            timeslots.Add("11:30-12:30");
            timeslots.Add("12:30-13:30");
            timeslots.Add("13:30-14:30");
            timeslots.Add("14:30-15:30");
            timeslots.Add("15:30-16:30");
            timeslots.Add("16:30-17:30");
            timeslots.Add("17:30-18:30");
            dropDownEvents.DataSource = timeslots;
        }
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

        private void frmAddEvent_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < sudoData.Count();i++ )
            {
                if (sudoData[i].getUser() == currentUser.Username)
                {
                    if (monthCalendarAddEvent.SelectionStart == sudoData[i].getEvent())
                    {
                        setTime(sudoData[i]);
                        
                        break;
                     
                    }
                }
            }
            
                
        }

        private void setTime(CalendarData user)
        {
        
            /*timeslots[1] += user.TimeSlot1;
            timeslots[2] += user.TimeSlot2;
            timeslots[3] += user.TimeSlot3;
            timeslots[4] += user.TimeSlot4;
            timeslots[5] += user.TimeSlot5;
            timeslots[6] += user.TimeSlot6;
            timeslots[7] += user.TimeSlot7;
            timeslots[8] += user.TimeSlot8;
            timeslots[9] += user.TimeSlot9;
            timeslots[10] += user.TimeSlot10;
            timeslots[11] += user.TimeSlot11;*/
        }
    }
}
