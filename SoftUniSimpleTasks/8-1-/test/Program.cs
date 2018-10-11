using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i1 = 0; i1 < 9; i1++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    for (int i3 = 0; i3 < 9; i3++)
                    {
                        for (int i4 = 0; i4 < 9; i4++)
                        {
                            for (int i5 = 0; i5 < 9; i5++)
                            {
                                for (int i6 = 0; i6 < 9; i6++)
                                {
                                    for (int i7 = 0; i7 < 9; i7++)
                                    {
                                        for (int i8 = 0; i8 < 9; i8++)
                                        {
                                            for (int i9 = 0; i9 < 9; i9++)
                                            {
                                                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}",i1,i2,i3,i4,i5,i6,i7,i8,i9);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
