using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure
{
    class TestFunctionality
    {
        static void Main()
        {
            // Create the tree
            Tree<int> tree =
              new Tree<int>(7,
                new Tree<int>(19,
                  new Tree<int>(1),
                  new Tree<int>(12),
                  new Tree<int>(31)),
                new Tree<int>(21),
                new Tree<int>(14,
                  new Tree<int>(23),
                  new Tree<int>(6))
              );

            // Traverse and print the tree using DFS
            tree.PrintDFS();
        }
    }
}
