using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnionAndIntesection
{
    class UnionAndIntesection
    {
        static void Main(string[] args)
        {
            int maxValue = 100000;
            HashSet<int> fOne = new HashSet<int>();
            HashSet<int> fTwo = new HashSet<int>();
            HashSet<int> fThree = new HashSet<int>();
            Methods.GenerateFOne(fOne, maxValue);
            Methods.GenerateFTwo(fTwo, maxValue);
            Methods.GenerateFThree(fThree, maxValue);

            HashSet<int> intersectionFOneFThree=new HashSet<int>(fOne.Intersect(fThree));
            foreach (var item in intersectionFOneFThree)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            SortedSet<int> unionAll = new SortedSet<int>(fOne.Union(fTwo.Union(fThree)));
            foreach (var numb in unionAll)
            {
                Console.WriteLine(numb);
            }

            Console.WriteLine(   maxValue.CompareTo(50000000));
        }
    }
}
