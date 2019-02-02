using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {

        public static void DateDifference(string dateOne, string dateTwo)
        {
            int[] firstOne = dateOne.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondOne = dateTwo.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            DateTime firstDate = new DateTime(firstOne[0], firstOne[1], firstOne[2]);

            DateTime secondDate = new DateTime(secondOne[0], secondOne[1], secondOne[2]);

            if (firstDate > secondDate)
            {
                Console.WriteLine((firstDate - secondDate).TotalDays);
            } else
            {
                Console.WriteLine((secondDate - firstDate).TotalDays);
            }
        }


    }
}
