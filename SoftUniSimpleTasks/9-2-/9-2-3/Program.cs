﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var secretNumber = int.Parse(Console.ReadLine());
            var bullsCount = int.Parse(Console.ReadLine());
            var cowsCount = int.Parse(Console.ReadLine());
            var counter = 0;

            var n1 = secretNumber / 1000;
            var n2 = secretNumber / 100 % 10;
            var n3 = secretNumber / 10 % 10;
            var n4 = secretNumber %10;
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);

            for (int i1 = 1; i1 < 10; i1++)
            {
                for (int i2 = 1; i2 < 10; i2++)
                {
                    for (int i3 = 1; i3 < 10; i3++)
                    {
                        for (int i4 = 1; i4 < 10; i4++)
                        {
                            var n1Check = i1;
                            var n2Check = i2;
                            var n3Check = i3;
                            var n4Check = i4;
                            var n1Work = n1;
                            var n2Work = n2;
                            var n3Work = n3;
                            var n4Work = n4;
                            var currentCows = 0;
                            var currentBulls = 0;

                            if (n1Check == n1Work)
                            {
                                currentBulls++;
                                n1Check = -1;
                                n1Work = -2;
                            }

                            if (n2Check == n2Work)
                            {
                                currentBulls++;
                                n2Check = -3;
                                n2Work = -4;
                            }

                            if (n3Check == n3Work)
                            {
                                currentBulls++;
                                n3Check = -5;
                                n3Work = -6;
                            }

                            if (n4Check == n4Work)
                            {
                                currentBulls++;
                                n4Check = -7;
                                n4Work = -8;
                            }//do tuk sa bikowete

                            if (n1Check == n2Work && n1Check > 0)
                            {
                                currentCows++;
                                n1Check = -1;
                                n2Work = -1;
                            }
                            else if (n1Check == n3Work && n1Check > 0)
                            {
                                currentCows++;
                                n1Check = -1;
                                n3Work = -1;
                            }
                            else if (n1Check == n4Work && n1Check > 0)
                            {
                                currentCows++;
                                n1Check = -1;
                                n4Work = -1;
                            } //kraj s n1

                            if (n2Check == n1Work && n2Check > 0)
                            {
                                currentCows++;
                                n2Check = -1;
                                n1Work = -1;
                            }
                            else if (n2Check == n3Work && n2Check > 0)
                            {
                                currentCows++;
                                n2Check = -1;
                                n3Work = -1;
                            }
                            else if (n2Check == n4Work && n2Check > 0)
                            {
                                currentCows++;
                                n2Check = -1;
                                n4Work = -1;
                            }                           

                            if (n3Check == n1Work && n3Check > 0)
                            {
                                currentCows++;
                                n3Check = -1;
                                n1Work = -1;
                            }
                            else if (n3Check == n2Work && n3Check > 0)
                            {
                                currentCows++;
                                n3Check = -1;
                                n2Work = -1;
                            }
                            else if (n3Check == n4Work && n3Check > 0)
                            {
                                currentCows++;
                                n3Check = -1;
                                n4Work = -1;
                            }

                            if (n4Check == n1Work && n4Check > 0)
                            {
                                currentCows++;
                                n4Check = -1;
                                n1Work = -1;
                            }
                            else if (n4Check == n2Work && n4Check > 0)
                            {
                                currentCows++;
                                n4Check = -1;
                                n2Work = -1;
                            }
                            else if (n4Check == n3Work && n4Check > 0)
                            {
                                currentCows++;
                                n4Check = -1;
                                n3Work = -1;
                            }

                            if (currentBulls==bullsCount&&currentCows==cowsCount)
                            {
                                Console.Write("{0}{1}{2}{3} ",i1,i2,i3,i4);
                                counter++;
                            }
                        }
                    }
                }
            }

            if (counter==0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
