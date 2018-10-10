using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_1
{
    class Program
    {
        static void header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void middle()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void bottom()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("(c) SoftUni");
        }
        static void all()
        {
            header();
            middle();
            bottom();
        }
        static void Main(string[] args)
        {
            all();
        }
    }
}
