using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_8
{
    class Program
    {
        static string PrintName(string name)
        {
            //var helloName = string("Hello,{0} !", PrintName(name);
            return name;
        }
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!",PrintName(name));
        }
    }
}
