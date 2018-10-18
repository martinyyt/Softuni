using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTypes
{
    class Worker : Human, IComparable
    {
        private double workHours;
        private double earnings;

        public double WorkHours
        {
            get { return this.workHours; }
            set { this.workHours = value; }
        }
        public double Earnings
        {
            get => this.earnings;
            set => this.earnings = value;
        }

        public Worker(double earnings, double workHours, string firstName, string thirdName) : base(firstName, thirdName)
        {
            Earnings = earnings;
            WorkHours = workHours;
        }
        public override string ToString()
        {
            return string.Format($"{FirstName} {ThirdName}\n" +
                $"For {WorkHours} hours he earned {Earnings}");
        }

        public double GetEarningsPerHour()
        {
            return this.Earnings / this.WorkHours;
        }

        public int CompareTo(object obj)
        {
            Worker worker = (Worker)obj;
            return Earnings.CompareTo(worker.Earnings);            
        }
    }
}
