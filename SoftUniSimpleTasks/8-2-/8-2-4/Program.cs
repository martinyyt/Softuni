using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //11:20-12:00 start 13:00
            var stud = int.Parse(Console.ReadLine());
            
            var two = 0;
            var sum_two = 0.0;
            var three = 0;
            var sum_three = 0.0;
            var four = 0;
            var sum_four = 0.0;
            var five = 0;
            var sum_five = 0.0;

            var avg = 0.0;
            var count = 0;
            var sum_all = 0.0;

            for (int i = 0; i < stud; i++)
            {
                var grade = double.Parse(Console.ReadLine());
                if (grade<3)
                {
                    two++;
                    sum_two += grade;
                }
                else if (grade<4)
                {
                    three++;
                    sum_three += grade;
                }
                else if (grade<5)
                {
                    four++;
                    sum_four += grade;
                }
                else
                {
                    five++;
                    sum_five += grade;
                }
                count++;
                sum_all += grade;
            }
            //Console.WriteLine(two);
            Console.WriteLine("Top students: {0:F2}%",(double)five/count*100);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", (double)four /count*100);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", (double)three /count*100);
            Console.WriteLine("Fail: {0:F2}%", (double)two /count*100);
            Console.WriteLine("Average: {0:F2}",sum_all/count);

        }
    }
}
