using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeStructure
{
    class TestBinarySearchTree
    {
        static void Main()
        {
            var tree = new BinarySearchTree<string>();
            tree.Insert("first");
            tree.Insert("second");
            tree.Insert("third");
            tree.Insert("aaaaa");
            tree.PrintTreeDFS();

            Console.WriteLine(tree.Contains("second")); 
            Console.WriteLine(tree.Contains("fourth"));
            tree.Remove("second");
            Console.WriteLine(tree.Contains("second"));
            tree.PrintTreeDFS();
            
        }
    }
}
