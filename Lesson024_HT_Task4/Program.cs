using System;

namespace Lesson024_HT_Task4
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2011, 1, 1, 4, 0, 15);

            DateTime date2 = new DateTime(2010, 1, 1, 4, 0, 15);
            TimeSpan date3 = new TimeSpan(36, 0, 0, 0);

            TimeSpan value = date1.Subtract(date2);
            DateTime value2 = date1.Add(date3);

            Console.WriteLine("TimeSpan between date1" +
                           " and date2 is {0} day", value.Days);

            Console.WriteLine("days:" + value2.Day);

            //ПЕРЕВАНТАЖИТИ НЕ ВИХОДИТЬ, ТАК ЯК НЕ МОЖУ ДОСТУПИТИСЬ ДО DateTime методів.
        }
    }
}
