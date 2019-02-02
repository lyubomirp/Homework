using System;
using System.Globalization;
using System.Linq;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();

            string endDate = Console.ReadLine();

            DateTime start = DateTime.ParseExact(startDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            

            DateTime[] holidays = {
                new DateTime ( 2016, 1, 1),
                new DateTime ( 2016, 3, 3),
                new DateTime ( 2016, 5, 1),
                new DateTime ( 2016, 5, 6),
                new DateTime ( 2016, 5, 24),
                new DateTime ( 2016, 9, 6),
                new DateTime ( 2016, 9, 22),
                new DateTime ( 2016, 11, 1),
                new DateTime ( 2016, 12, 24),
                new DateTime ( 2016, 12, 25),
                new DateTime ( 2016, 12, 26)

            };


            DateTime end = DateTime.ParseExact(endDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workingDays = 0;






            for (var i = start; i <= end; i = i.AddDays(1))
            {
                DateTime temp = new DateTime(2016, i.Month, i.Day);
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday || holidays.Contains(i))
                {
                    workingDays+=0;
                } else
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
