using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNumbers
{
    class ReadNumbers
    {
        

        static void Main(string[] args)
        {
            numb = 1;
            for (int i = 0; i < 10; i++)
            {
                ReadNumber(numb, 100);
            }
            string ass= "";
            string bdd="df";
            ass.Equals(bdd, StringComparison.OrdinalIgnoreCase);
        }

        static int numb;
        static void ReadNumber(int start, int end)
        {
            try
            {
               numb = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Not integer");
                throw e;
            }

            if (numb < start||numb>end)
            {
                Exception NumberNotInRange=new Exception("Not in range");
                throw NumberNotInRange;
            }
            
        }
    }
}
