using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SpiralToN
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()); // трябваше да вкарам index=n-1, щеше да спести главоболия
            int counter = 0;
            int[,] matrix = new int[n, n];
            var numb = 1;

            while (counter<n) // zapochva ot "0", можеше да стане с for цикъл по-лесно
            {
                for (int right = counter; right <= (n-1-counter); right++)
                {
                    matrix[counter, right] = numb;
                    numb++;
                }

                
                for (int down = counter + 1; down <= (n - 1 - counter); down++)
                {
                    matrix[down, (n - 1 - counter)] = numb;
                    numb++;
                }

                for (int left = (n - 1 - counter - 1); left >= counter; left--)
                {
                    matrix[(n - 1 - counter), left] = numb;
                    numb++;
                }
                                

                for (int up = (n - 1 - counter - 1); up >= counter+1; up--)
                {
                    matrix[up, counter] = numb;
                    numb++;
                }
                counter++;
                //break;

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            

        }
    }
}
