using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateMethods

{
    class DateMethods
    {
        static void Main(string[] args)
        {
            //DiffernceByTwoDates();

            NextSixHours();

            

        }

        static void NextSixHours() // 5.5.2000 7:5:23
        {
            DateTime exactTime = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy H:m:s", CultureInfo.InvariantCulture);
            Console.WriteLine(exactTime);
            exactTime=exactTime.AddHours(6.5);
            Console.WriteLine(exactTime.ToString("d.M.yyyy H:m:s"));
        }

        static void DiffernceByTwoDates()
        {
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            TimeSpan diff = end - start;
            int diffDays = Math.Abs( diff.Days);
            Console.WriteLine(diffDays + " days");
        }

    }

}
