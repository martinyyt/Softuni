﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal speed = decimal.Parse(Console.ReadLine());
            if (speed <=10)
            {
                Console.WriteLine("slow");
            }
            else if (speed<=50)
            {
                Console.WriteLine("average");
            }
            else if (speed<=150)
            {
                Console.WriteLine("fast");
            }
            else if (speed <=1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
