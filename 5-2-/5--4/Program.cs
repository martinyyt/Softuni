using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var treated = 0;
            var untreated = 0;
            var docs = 7;
            for (int i = 0; i < days; i++)
            {
                
                if (treated < untreated && (i + 1) % 3 == 0)
                {
                    docs++;
                }
                var patients = int.Parse(Console.ReadLine());
                var day_treated = Math.Min(docs, patients);
                var day_untreated = 0;
                if (docs<patients)
                {
                    day_untreated = patients - docs;
                }
               
                treated += day_treated;
                untreated += day_untreated;
               // Console.WriteLine(treated);
               // Console.WriteLine(untreated);
            }
            Console.WriteLine("Treated patients: {0}.",treated);
            Console.WriteLine("Untreated patients: {0}.",untreated);
        }
    }
}
