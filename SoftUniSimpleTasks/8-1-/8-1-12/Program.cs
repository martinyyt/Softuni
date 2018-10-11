using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //10:40-11:10 START
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var count = 0;
            for (int x1 = -n; x1 < n; x1++)
            {
                for (int x2 = x1+1; x2 <=n; x2++)
                {
                    for (int y1 = -n; y1 <n; y1++)
                    {
                        for (int y2 = y1+1; y2 <= n; y2++)
                        {
                            var vis = Math.Abs(x1 - x2);
                            var shir = Math.Abs(y1 - y2);
                            if (vis*shir>=m)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}",x1,y1,x2,y2, vis * shir);
                                count++;
                            }
                        }
                    }
                }
            }
            if (count==0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
