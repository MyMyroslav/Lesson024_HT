using System;
namespace Lesson024_HT_Task4
{
    public class Data
    {
        public DateTime Date { get; set; }
        //public TimeSpan timeSpan { get; set; }
        public Data(DateTime Date)
        {
            this.Date = Date;
        }
    }
}
