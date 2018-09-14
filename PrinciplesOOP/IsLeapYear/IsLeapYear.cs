using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsLeapYear
{
    class IsLeapYear
    {
        static void Main(string[] args)
        {
            DateTime year = new DateTime(2004,11,18);
            Console.WriteLine(year.DayOfWeek);
            Console.WriteLine(DateTime.IsLeapYear(year.Year) ); 
        }
    }
}
