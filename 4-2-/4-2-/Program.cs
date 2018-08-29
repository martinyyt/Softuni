using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var hi = int.Parse(Console.ReadLine());
            var mi = int.Parse(Console.ReadLine());
            var ha = int.Parse(Console.ReadLine());
            var ma = int.Parse(Console.ReadLine());
            var dif = hi * 60 + mi - ha * 60 - ma;
            var difh = dif / 60;
            var difm = dif % 60;
            //Console.WriteLine(dif);
            //Console.WriteLine(difh);
            //Console.WriteLine(difm);
            if (dif == 0)
            {
                Console.WriteLine("On time");
            }
            else if (dif > 0 && dif < 10)
            {
                Console.WriteLine("On time");
                Console.WriteLine(difm + " minutes before the start");
            }
            else if (dif > 9 && dif < 31)
            {
                Console.WriteLine("On time");
                Console.WriteLine(difm + " minutes before the start");
            }
            else if (dif > 30 && dif < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine(difm + " minutes before the start");
            }
            else if (dif > 59)
            {
                Console.WriteLine("Early");
                if (difm < 10)
                    Console.WriteLine(difh + ":0" + difm + " hours before the start");
                else
                    Console.WriteLine(difh + ":" + difm + " hours before the start");
            }
            else if (dif > -10)
            {
                Console.WriteLine("Late");
                Console.WriteLine(Math.Abs(difm) + " minutes after the start");
            }
            else if (dif < -9 && dif > -60)
            {
                Console.WriteLine("Late");
                Console.WriteLine(Math.Abs(difm) + " minutes after the start");
            }
            else
            {
                Console.WriteLine("Late");
                if (Math.Abs( difm) < 10)
                    Console.WriteLine(Math.Abs( difh) + ":0" +Math.Abs( difm) + " hours after the start");
                else
                    Console.WriteLine(Math.Abs( difh) + ":" +Math.Abs( difm) + " hours after the start");
            }
        }
    }
}
