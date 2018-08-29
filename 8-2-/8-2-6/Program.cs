using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //11:20-12:00 plus 13:00-13:40
            char let1 = char.Parse( Console.ReadLine());
            char let2 = char.Parse(Console.ReadLine());
            char let_miss = char.Parse(Console.ReadLine());
            var count = 0;
            for (int i = let1; i <= let2; i++)
            {
                for (int j = let1; j <= let2; j++)
                {
                    for (int h = let1; h <= let2; h++)
                    {
                        if (!(i==let_miss||j==let_miss||h==let_miss))
                        {
                            Console.Write("{0}{1}{2} ",(char) i, (char)j, (char)h);
                            count++;
                        }
                    }
                }
            }
            
            Console.WriteLine(count);
        }
    }
}
