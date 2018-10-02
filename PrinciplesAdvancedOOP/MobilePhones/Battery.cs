using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhones
{
    public enum BatteryType
    {
        unknown, LiIon, NiMH, NiCd
    }
    public class Battery
    {
        private string model = null;
        private int idleTime = 0;
        private int hoursTalk = 0;
        private BatteryType type=0;

        public Battery(string model, int idleTime, int hoursTalk, BatteryType type)
        {
            Model = model;
            IdleTime = idleTime;
            HoursTalk = hoursTalk;
            this.Type = type;
        }

        public Battery()
        {
            Model = null;
            IdleTime = 0;
            HoursTalk = 0;
            Type = 0;
        }

        public string Model { get => model; set => model = value; }
        public int IdleTime { get => idleTime; set => idleTime = value; }
        public int HoursTalk { get => hoursTalk; set => hoursTalk = value; }
        public BatteryType Type { get => type; set => type = value; }

        public void PrintBatteryInfo()
        {
            Console.WriteLine(this.Model);
            Console.WriteLine(this.IdleTime);
            Console.WriteLine(this.HoursTalk);
            Console.WriteLine(this.Type);
        }

        public override string ToString()
        {
            return string.Format("Model: {0}\n" +
                "Idle Time: {1}\n" +
                "Hours Talk: {2}\n" +
                "Battery Type: {3}",this.Model,this.IdleTime,this.HoursTalk,this.Type);
        }
    }
}
