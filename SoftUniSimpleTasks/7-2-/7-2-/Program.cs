using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var char1 = i + 1;
                //Console.Write(char1);
                for (int j = 0; j < n; j++)
                {
                    var char2 = j+1;
                    //Console.Write(char2);
                    for (int q = 0; q < l; q++)
                    {
                        var char3 = q+97;
                        //Console.Write((char)char3);
                        for (int w = 0; w < l; w++)
                        {
                            var char4 = w + 97;
                            //Console.Write((char)char4);
                            for (int e = Math.Max(char1,char2); e < n; e++)
                            {
                                var char5 = e + 1;
                                //Console.Write(char5);
                                
                                    Console.Write("{0}{1}{2}{3}{4} ",char1,char2,(char)char3,(char)char4,char5);
                                
                            }
                        }
                    }
                }
            }
        }
    }
}
