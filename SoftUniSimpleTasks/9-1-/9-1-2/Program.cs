using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_2
{
    class Program
    {
        static int DateWeight(DateTime date)
        {
            var day1 = date.Day/10;
            var day2 = date.Day % 10;
            var month1 = date.Month / 10;
            var month2 = date.Month % 10;
            var year1 = date.Year / 1000;
            var year2 = date.Year / 100 % 10;
            var year3 = date.Year / 10 % 10;
            var year4 = date.Year % 10;

            var weight = day1 * (day2 + month1 + month2 + year1 + year2 + year3 + year4) +
                day2 * (month1 + month2 + year1 + year2 + year3 + year4) +
                month1 * (month2 + year1 + year2 + year3 + year4) + month2 * (year1 + year2 + year3 + year4) +
                year1 * (year2 + year3 + year4) + year2 * (year3 + year4) + year3 * year4;
            return weight;
        }

        static void Main(string[] args)
        {

            //DateTime date = new DateTime(2007, 3, 17);
            //string date2 = date.ToString("dd-MM-yyyy");
            //Console.WriteLine("{0:dd-MM-yyyy}", date);
            //Console.WriteLine(date2);
            //Console.WriteLine(date.Day);
            //Console.WriteLine(DateWeight(date));

            var startYear = int.Parse(Console.ReadLine());
            var endYear = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var startDate = new DateTime(startYear,1,1);
            var endDate = new DateTime(endYear, 12, 31);
            var counter = 0;

            for (DateTime i = startDate; i <= endDate; i=i.AddDays(1))
            {
                var weight = DateWeight(i);
                if (weight==magicNumber)
                {
                    Console.WriteLine("{0:dd-MM-yyyy}", i);
                    counter++;
                }
            }

            if (counter==0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
