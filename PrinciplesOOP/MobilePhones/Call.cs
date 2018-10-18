using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhones
{
    public class Call
    {
        private DateTime callDate = new DateTime();
        private DateTime callStartTime = new DateTime();
        private TimeSpan callLength = new TimeSpan(0);

        public DateTime CallDate
        {
            get
            {
                return this.callDate;
            }
            set
            {
                this.callDate = value;
            }
        }
        public DateTime CallStartTime
        {
            get { return this.callStartTime; }
            set { this.callStartTime = value; }
        }
        public TimeSpan CallLength
        {
            get { return this.callLength; }
            set { this.callLength = value; }
        }
                
        public Call (DateTime callDate, DateTime start, TimeSpan length)
        {
            this.CallDate = callDate;
            this.CallStartTime = start;
            this.CallLength = length;
        }
        public Call(DateTime callDate, DateTime start) 
            : this (callDate, start, new TimeSpan(0))
        {            
        }
        public Call (DateTime callDate)
            : this (callDate, new DateTime())
        {

        }
        public Call() : this (new DateTime())
        {
        }

        public override string ToString()
        {
            return string.Format("{0:dd:MM:yyyy} // {1:HH:mm:ss} // {2}", this.CallDate, this.CallStartTime, this.CallLength);
        }
    }
}
