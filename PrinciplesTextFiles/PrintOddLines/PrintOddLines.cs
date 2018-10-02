using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrintOddLines
{
    class PrintOddLines
    {
        static void Main(string[] args)
        {
            bool odd = false;
            int lineCounter = 0;
            
            string path = @"..\..\TextDoc1.txt";
            try
            {
                StreamReader reader = new StreamReader(path, Encoding.Default);

                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line!=null)
                    {
                        lineCounter++;
                        odd = lineCounter % 2 == 1;
                        if (odd)
                        {
                            Console.WriteLine(line);
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FNF");
            }
            
        }
    }
}
