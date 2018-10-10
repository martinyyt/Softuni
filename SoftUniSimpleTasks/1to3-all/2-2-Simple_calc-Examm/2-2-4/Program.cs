using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var bc = int.Parse(Console.ReadLine());
            var ch = Double.Parse(Console.ReadLine());
            var intr = Double.Parse(Console.ReadLine());
            var bgn_bc = bc * 1168;
            var bgn_ch = ch * 0.15 * 1.76;
            Console.WriteLine(((bgn_bc+bgn_ch)/1.95)*(100-intr)/100);
        }
    }
}
