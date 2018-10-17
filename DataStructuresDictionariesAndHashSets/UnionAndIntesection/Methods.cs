using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionAndIntesection
{
    internal class Methods
    {
        public static void GenerateFOne(HashSet<int> fOne, int maxNumber)
        {
            int CalculateElement(int prevoius)
            {
                return 2 * prevoius + 3;
            }
            //int k = 0;
            int currentElement = 1;

            while (currentElement < maxNumber)
            {
                fOne.Add(currentElement);
                currentElement = CalculateElement(currentElement);
            }
        }
        public static void GenerateFTwo(HashSet<int> fTwo, int maxNumber)
        {
            int CalculateElement(int prevoius)
            {
                return 3 * prevoius + 1;
            }
            int currentElement = 2;

            while (currentElement < maxNumber)
            {
                fTwo.Add(currentElement);
                currentElement = CalculateElement(currentElement);
            }
        }
        public static void GenerateFThree(HashSet<int> fThree, int maxNumber)
        {
            int CalculateElement(int prevoius)
            {
                return 2 * prevoius - 1;
            }
            int currentElement = 2;

            while (currentElement < maxNumber)
            {
                fThree.Add(currentElement);
                currentElement = CalculateElement(currentElement);
            }
        }
    }
}
