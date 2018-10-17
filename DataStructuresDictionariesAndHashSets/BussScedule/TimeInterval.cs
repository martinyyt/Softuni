using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussScedule
{
    class TimeInterval
    {
        private int arriveHour = 0;
        private int arriveMinute = 0;
        private int leaveHour = 0;
        private int leaveMinute = 0;

        public TimeInterval(int arriveHour, int arriveMinute, int leaveHour, int leaveMinute)
        {
            ArriveHour = arriveHour;
            ArriveMinute = arriveMinute;
            LeaveHour = leaveHour;
            LeaveMinute = leaveMinute;
        }

        public int ArriveHour { get => arriveHour; set => arriveHour = value; }
        public int ArriveMinute { get => arriveMinute; set => arriveMinute = value; }
        public int LeaveHour { get => leaveHour; set => leaveHour = value; }
        public int LeaveMinute { get => leaveMinute; set => leaveMinute = value; }

        public override int GetHashCode()
        {
            return ((this.LeaveHour*7 +this.LeaveMinute)*13 +this.ArriveHour)*23+ this.ArriveMinute;
        }
        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            TimeInterval interval = (TimeInterval)obj;
            if ((this.ArriveHour + this.ArriveMinute * 60) == (interval.ArriveHour + interval.ArriveMinute * 60)
                && (LeaveHour + 60 * LeaveMinute) == (interval.LeaveHour + interval.LeaveMinute * 60))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return string.Format("{0}:{1:D2} - {2}:{3:d2}",arriveHour,arriveMinute,leaveHour,leaveMinute);
        }
    }
}
