using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //14:40 do 17:40 za parvite 11, 12-ta utre!!
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            
                if (b-a<3)
                {
                    Console.WriteLine("No");
                    
                }
                
                else
                {
                    //n1, n2, n3, n4
                    for (int n1 = a; n1 <=b; n1++)//4 7
                    {
                        if (b-n1<3)
                        {
                            break;
                        }
                        for (int n2 = n1+1; n2 <= b; n2++)//5 7
                        {
                            if (b - n2 < 2)
                            {
                                break;
                            }
                            for (int n3 = n2+1; n3 <= b; n3++)//6 7
                            {
                                if (b - n3 < 1)
                                {
                                    break;
                                }
                                for (int n4 = n3+1; n4 <= b; n4++)//7 7
                                {
                                    if (b - n4 < 0)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("{0} {1} {2} {3}",n1,n2,n3,n4);
                                    }
                                }
                            }
                        }
                    }
                }
            
        }
    }
}
