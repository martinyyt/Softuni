using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var newd = d;
            var newm = m;
            var totaldays = 31;
            if (m==2)
            {
                totaldays=28;
            }
            else if (m==4||m==6||m==9||m==11)
            {
                totaldays = 30;
            }
            if (d + 5 <= totaldays)
            {
                newd = d + 5;
            }
            else
            {
                newd = (d + 5) % totaldays;
            }
            //Console.WriteLine("nov den"+newd);
            if ((d + 4) / totaldays>0)
            {
                if (m + 1 == 12)
                {
                    newm = m + 1;
                }
                else
                {


                    newm = (m + 1) % 12;
                }
            }
            //Console.WriteLine("naov m"+newm);
            if (newm<10)
            {
                Console.WriteLine("{0}.0{1}",newd,newm);
            }
            else
            {
                Console.WriteLine("{0}.{1}", newd, newm);
            }
        }
    }
}
