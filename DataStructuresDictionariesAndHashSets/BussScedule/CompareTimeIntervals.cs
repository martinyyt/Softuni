using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussScedule
{
    class CompareTimeIntervals
    {
        static void Main()
        {
            TimeInterval targetInterval = new TimeInterval(8, 60, 9, 15);
            List<TimeInterval> allIntervals = new List<TimeInterval> { new TimeInterval(8, 24, 8, 33), new TimeInterval(8, 20, 9, 00)
            , new TimeInterval(8, 32, 8, 37), new TimeInterval(9, 00, 9, 15)};

            HashSet<TimeInterval> validArrivals = new HashSet<TimeInterval>();

            HashSet<TimeInterval> validDepartures = new HashSet<TimeInterval>();

            foreach (var interval in allIntervals)
            {
                Console.WriteLine(interval);
                if ((interval.ArriveHour * 60 + interval.ArriveMinute) >= (targetInterval.ArriveHour * 60 + targetInterval.ArriveMinute))
                {
                    validArrivals.Add(interval);
                }
                if ((interval.LeaveHour * 60 + interval.LeaveMinute) <= (targetInterval.LeaveHour * 60 + targetInterval.LeaveMinute))
                {
                    validDepartures.Add(interval);
                }
            }
            Console.WriteLine();

            HashSet<TimeInterval> validIntervals = new HashSet<TimeInterval>(validArrivals.Intersect(validDepartures));
            foreach (var interval in validIntervals)
            {
                Console.WriteLine(interval);
            }
            Console.WriteLine();
        }
    }
}
