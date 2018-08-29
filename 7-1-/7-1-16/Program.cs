using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_16
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numb = 1;
            //var step = -1;
            for (int i = 0; i < n; i++)
            {
                var pos = 1;
                var step = 1;
                numb = i + 1;
                if (numb==n)
                {
                    step = -1;
                }
                while (pos<=n)
                {
                    if (pos==n)
                    {
                        Console.WriteLine(numb);
                        break;
                    }
                    
                        Console.Write(numb + " ");
                    
                    pos++;
                    numb+=step;
                    if (numb == n || numb == 1)
                    {
                        step *= -1;
                    }


                }

                //Console.WriteLine();
            }
            
        }
    }
}
