using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Test
{
    class Test
    {
         static public int a;
         static void Main(string[] args)
        {
            int a=5;
            Console.WriteLine(Test.a);
            // Console.WriteLine(this.a); // Must be non static
            Console.WriteLine(a);

            int[] arr = new int[5];
            arr = new int[6];
        }
    }
}
