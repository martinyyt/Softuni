using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());
            //var m = int.Parse(Console.ReadLine());
            var mina = Math.Min(Math.Min( x, y), z);
            var maxc = Math.Max(Math.Max(x, y), z);
            var midb = 0;
            if (x==mina)
            {
                midb = Math.Min(y, z);
            }
            else if (y == mina)
            {
                midb = Math.Min(x, z);
            }
            else
            {
                midb = Math.Min(x, y);
            }
            if (mina+midb==maxc)
            {
                Console.WriteLine("{0} + {1} = {2}",mina,midb,maxc);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
