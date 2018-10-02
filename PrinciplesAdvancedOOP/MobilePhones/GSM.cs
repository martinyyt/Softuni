using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhones
{
    class GSM
    {
        private string model = null;
        private string manufacturer = null;
        private int price = 0;
        private string owner = null;
        private Battery deviceBattery = null;
        private Display deviceDisplay = null;
        private List<Call> deviceCallList = new List<Call>();

        public string Model { get => model; set => model = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public int Price { get => price; set => price = value; }
        public string Owner { get => owner; set => owner = value; }
        public Battery DeviceBattery { get => deviceBattery; set => deviceBattery = value; }
        public Display DeviceDisplay { get => deviceDisplay; set => deviceDisplay = value; }
        internal List<Call> DeviceCallList { get => deviceCallList; set => deviceCallList = value; }

        public GSM(string model, string manufacturer, int price, string owner, Battery deviceBattery, Display deviceDisplay)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            DeviceBattery = deviceBattery;
            DeviceDisplay = deviceDisplay;
        }

        public GSM()
        {
            Model = null;
            Manufacturer = null;
            Price = 0;
            Owner = null;
            DeviceBattery = new Battery();
            DeviceDisplay = new Display();
        }

        public static GSM NokiaN95 = new GSM("n95", "nokia", 50, "goshko", new Battery("somebat", 15, 22,BatteryType.NiMH), new Display(65000, 240, 120));

        static void PrintInfoN95()
        {
            
            Console.WriteLine("model: "+NokiaN95.Model);
            Console.WriteLine("manufacturer: "+NokiaN95.Manufacturer);
            Console.WriteLine("price BGN: "+NokiaN95.Price);
            Console.WriteLine("owner: " + NokiaN95.Owner);
            Console.WriteLine();
            Console.WriteLine("BatteryInfo\n" + NokiaN95.DeviceBattery);
            Console.WriteLine();
            Console.WriteLine("DisplayInfo\n" + NokiaN95.DeviceDisplay);
        }

        public override string ToString()
        {
            return string.Format("Model: {0}\n" +
                "Manufacturer: {1}\n" +
                "Price BGN: {2}\n" +
                "Owner: {3}\n\n" +
                "Battery Info\n"+this.DeviceBattery+"\n\n"+
                "Display Info\n"+this.deviceDisplay,this.Model,this.Manufacturer,this.Price,this.Owner);
        }
    }
}
