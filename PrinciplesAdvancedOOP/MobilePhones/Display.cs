using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhones
{
    public class Display
    {
        private int colors = 0;
        private int sizeHeigth = 0;
        private int sizeWidth = 0;

        public Display(int colors, int sizeHeigth, int sizeWidth)
        {
            this.colors = colors;
            this.sizeHeigth = sizeHeigth;
            this.sizeWidth = sizeWidth;
        }

        public Display()
        {
            this.colors = 0;
            this.sizeHeigth = 0;
            this.sizeWidth = 0;
        }


        public int Colors { get => colors; set => colors = value; }

        public string SizeHW
        {
            get
            {
                return string.Format(sizeHeigth + "x" + sizeWidth);
            }
        }

        public void PrintDisplayInfo()
        {
            Console.WriteLine(this.Colors);
            Console.WriteLine(this.SizeHW);
        }

        public override string ToString()
        {
            return string.Format("Colsors: {0}\n" +
                "Size: {1}",this.Colors,this.SizeHW);
        }
    }
}
