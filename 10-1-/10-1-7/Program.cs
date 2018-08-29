using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _10_1_7
{
    class Program
    {
        static int getmax(int x, int y)
        {
            if (x>y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        static char getmax(char x, char y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        static string getmax(string x, string y)
        {
            if (string.Compare(x,y)>0)
            //if (x.CompareTo(y)>0)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type=="int")
            {
                var x = int.Parse(Console.ReadLine());
                var y = int.Parse(Console.ReadLine());
                Console.WriteLine(getmax(x, y));
            }
            if (type == "char")
            {
                var x = char.Parse(Console.ReadLine());
                var y = char.Parse(Console.ReadLine());
                Console.WriteLine(getmax(x, y));
            }
            if (type == "string")
            {
                var x = Console.ReadLine();
                var y = Console.ReadLine();
                Console.WriteLine(getmax(x, y));
            }
        }
    }
}
