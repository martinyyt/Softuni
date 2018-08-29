using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());
            int sum = sec1 + sec2 + sec3;
            double div = sum / 60;
            var min = Math.Floor(div);
            int sec = sum % 60;
            //Console.WriteLine(div);
            //Console.WriteLine(sec);
            if (sec < 10)
            {
                Console.WriteLine(min+":0"+sec);
            }
            else
            {
                Console.WriteLine(min + ":" + sec);
            }
        }
    }
}
