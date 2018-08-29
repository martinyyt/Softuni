using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_13
{
    class Program
    {
        static void Main(string[] args)
        {
                        String birthstring = Console.ReadLine();
            DateTime birthdate = DateTime.ParseExact(birthstring,"dd-MM-yyyy",null);
            DateTime days1k = birthdate.AddDays(1000);
            Console.WriteLine(days1k.ToString("dd-MM-yyyy"));  

        }
    }
}
