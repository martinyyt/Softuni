using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLinkedList
{
    class SelectionSortLinkedList

    {
        static void SelectionSort(LinkedList<int> numbers)
        {

            int temp = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers.ElementAt(i) > numbers.ElementAt(j))
                    {
                        LinkedListNode<int> currenti = numbers.Find(numbers.ElementAt(i));
                        LinkedListNode<int> currentj = numbers.FindLast(numbers.ElementAt(j)); //important to find last element!!!
                        temp = currenti.Value;
                        currenti.Value = currentj.Value;
                        currentj.Value = temp;

                    }
                }
            }
        }
        static void Main(string[] args)
        {

            List<int> numberslist = new List<int>() { 5, 8, 6, 4, 2, 65, 5, 8, 6, 3, 2, 15, 8, 5, 4, 2, 0, 69, 4, 52, 48, 145, 2, 54, 86, 5, 5 };
            LinkedList<int> numbers = new LinkedList<int>(numberslist);


            SelectionSort(numbers);

            foreach (var numb in numbers)
            {
                Console.WriteLine(numb);
            }

        }
    }
}
