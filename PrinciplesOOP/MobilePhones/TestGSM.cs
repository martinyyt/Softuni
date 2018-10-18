using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhones
{
    class TestGSM
    {
        public static void Main()
        {
            List<GSM> gsmList = new List<GSM>();
            for (int i = 0; i < 5; i++)
            {
                gsmList.Add(new GSM());                
            }
            BatteryType test = (BatteryType)0;
            Console.WriteLine(test);
            Console.WriteLine(GSM.NokiaN95);
            Call newcall = new Call();
            Console.WriteLine(newcall);
        }
    }
}
