using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            // ред n-1 е с паузи и @
            // нечетен ред е *, четен е -
        
            var wingnumb = n - 1;
            char wingchar = '*';
            string middle = "";
            var odd = "odd";
            var even = "even";
            string leftwing = string.Empty;
            string rightwing = string.Empty;
            for (int i = 0; i < 2*(n-2)+1; i++)
            {
                var line = i + 1;
                string evod = string.Empty;
                
                 if (line%2==0)
                {
                    evod = even;
                    wingchar = '-';
                    
                }
                else
                {
                    evod = odd;
                    wingchar = '*';
                    
                }
                if (line< (2 * (n - 2) + 1)/2)
                {
                    middle = "\\ /";
                }
                else if (line > (2 * (n - 2) + 1) / 2)
                {
                    middle = "/ \\";
                }
                if (line == n - 1)
                {
                    wingchar = ' ';
                    middle = " @ ";
                }
                Console.WriteLine("{0}{1}{0}",new string(wingchar,n-2),middle);

            }

        }
    }
}
