using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Project
{
    [Serializable]
    public class CalendarDataList : BindingList<CalendarData>
    {
        public void WriteDataToFile()
        {

            FileStream pushData = new FileStream("CalendarData.ser", FileMode.Create, FileAccess.Write);

            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(pushData, this);
            pushData.Close();
           
        }

        public void ReadDataFromFile()
        {

            try
            {
                FileStream extractData = new FileStream("CalendarData.ser", FileMode.Open, FileAccess.Read);
                BinaryFormatter bFormatter = new BinaryFormatter();
                this.Clear();
                var tempList = (CalendarDataList)bFormatter.Deserialize(extractData);
                foreach (CalendarData myCalendar in tempList)
                {
                    this.Add(myCalendar);
                }
                extractData.Close();
            }
            catch (FileNotFoundException exception)
            {
                MessageBox.Show("Exception :  " + exception);
            }
        }
    }
}
