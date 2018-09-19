using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeTests
{
    class SomeTests
    {
        static void Main(string[] args)
        {            
            try
            {
                uint i = uint.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(i));
            }
            catch (OverflowException e)
            {                
                Console.WriteLine("Invalid number");
            }
            
            finally
            {
                Console.WriteLine("bye");
            }
        }
    }
}
