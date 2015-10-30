using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.ComponentModel;


namespace Project
{
    [Serializable]
    public class CalendarData
    {
        private string user;
        private DateTime EventDate;
        private string event1;
        private string event2;
        private string event3;
        private string event4;
        private string event5;
        private string event6;
        private string event7;
        private string event8;
        private string event9;
        private string event10;
        private string event11;

        [DisplayName("7:30-8:30")]
        public string TimeSlot1
        {
            get { return event1; }
            set { event1 = value; }
        }
        [DisplayName("8:30-9:30")]
        public string TimeSlot2
        {
            get { return event2; }
            set { event2 = value; }
        }
        [DisplayName("9:30-10:30")]
        public string TimeSlot3
        {
            get { return event3; }
            set { event3 = value; }
        }
        [DisplayName("10:30-11:30")]
        public string TimeSlot4
        {
            get { return event4; }
            set { event4 = value; }
        }
        [DisplayName("11:30-12:30")]
        public string TimeSlot5
        {
            get { return event5; }
            set { event5 = value; }
        }
        [DisplayName("13:30-14:30")]
        public string TimeSlot6
        {
            get { return event6; }
            set { event6 = value; }
        }
        [DisplayName("14:30-15:30")]
        public string TimeSlot7
        {
            get { return event7; }
            set { event7 = value; }
        }
        [DisplayName("15:30-16:30")]
        public string TimeSlot8
        {
            get { return event8; }
            set { event8 = value; }
        }
        [DisplayName("16:30-17:30")]
        public string TimeSlot9
        {
            get { return event9; }
            set { event9 = value; }
        }
        [DisplayName("17:30-18:30")]
        public string TimeSlot10
        {
            get { return event10; }
            set { event10 = value; }
        }
        [DisplayName("18:30-19:30")]
        public string TimeSlot11
        {
            get { return event11; }
            set { event11 = value; }
        }

        public CalendarData(DateTime time,string username)
        {
            user = username;
            EventDate = time;
            event1 = "";
            event2 = "";
            event3 = "";
            event4 = "";
            event5 = "";
            event6 = "";
            event7 = "";
            event8 = "";
            event9 = "";
            event10 = "";
            event11 = "";
        }

        public DateTime getEvent()
        {
            return EventDate;
        }
        public void setEvent(DateTime val)
        {
            EventDate = val;
        }

        public string getUser()
        {
            return user;
        }
        public void setUser(string str)
        {
            user = str;
        }
   
        

    }
}
