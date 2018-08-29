using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var bus_pr = 200;
            var truck_pr = 175;
            var train_pr = 120;
            var total_weight = 0.0;
            var weight_bus = 0.0;
            var weight_truck = 0.0;
            var weight_train = 0.0;
            for (int i = 0; i < n; i++)
            {
                var weight = double.Parse(Console.ReadLine());
                if (weight<= 3)
                {
                    weight_bus += weight;
                }
                else if (weight <= 11)
                {
                    weight_truck += weight;
                }
                else if (weight > 11)
                {
                    weight_train += weight;
                }

            }
            var total_price = weight_bus * bus_pr + truck_pr * weight_truck + train_pr * weight_train;
            total_weight = weight_bus + weight_truck + weight_train;
            Console.WriteLine("{0:F2}",total_price/total_weight);
            Console.WriteLine("{0:F2}%",weight_bus/total_weight*100);
            Console.WriteLine("{0:F2}%", weight_truck / total_weight * 100);
            Console.WriteLine("{0:F2}%", weight_train / total_weight * 100);
        }
    }
}
