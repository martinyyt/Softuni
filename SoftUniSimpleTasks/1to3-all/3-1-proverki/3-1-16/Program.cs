using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n<20)
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");

                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    case 10:
                        Console.WriteLine("ten");
                        break;
                    case 11:
                        Console.WriteLine("eleven");
                        break;
                    case 12:
                        Console.WriteLine("twelve");
                        break;
                    case 13:
                        Console.WriteLine("thirteen");
                        break;
                    case 14:
                        Console.WriteLine("fourteen");
                        break;
                    case 15:
                        Console.WriteLine("fifteen");
                        break;
                    case 16:
                        Console.WriteLine("sixteen");
                        break;
                    case 17:
                        Console.WriteLine("seventeen");

                        break;
                    case 18:
                        Console.WriteLine("eighteen");
                        break;
                    case 19:
                        Console.WriteLine("nineteen");
                        break;
                    case 0:
                        Console.WriteLine("zero");
                        break;
                }
            }
            else if (n<100)
            {
                double a = n/10;
                double b = n % 10;
                var a1 = Math.Floor(a);
                var b1 = Math.Floor(b);
                var ed = "";
                var des = "";
                switch (a1)
                    {
                    case 2: 
                    des = "twenty";
                    break;
                    case 3:
                        des = "thirty";
                        break;
                    case 4:
                        des = "fourty";
                        break;
                    case 5:
                        des = "fifty";
                        break;
                    case 6:
                        des = "sixty";
                        break;
                    case 7:
                        des = "seventy";
                        break;
                    case 8:
                        des = "eighty";
                        break;
                    case 9:
                        des = "ninety";
                        break;
                }
                switch (b1)
                {
                    case 1:
                        ed = " one";
                        break;
                    case 2:
                        ed = " two";
                        break;
                    case 3:
                        ed = " three";
                        break;
                    case 4:
                        ed = " four";
                        break;
                    case 5:
                        ed = " five";
                        break;
                    case 6:
                        ed = " six";
                        break;
                    case 7:
                        ed = " seven";
                        break;
                    case 8:
                        ed = " eight";
                        break;
                    case 9:
                        ed = " nine";
                        break;
                    case 0:
                        ed = "";
                        break;
                    
                }
                if (b1 == 0)
                {
                    Console.WriteLine(des);
                }
                else
                {
                    Console.WriteLine(des + ed);
                }
            }
            else
            {
                Console.WriteLine("one hundred");
            }
        }
    }
}
