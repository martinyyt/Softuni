using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeStructure
{
    class TestBinaryTree
    {
        static void Main()
        {
            BinaryTree<int> binaryTree =
      new BinaryTree<int>(14,
          new BinaryTree<int>(19,
              new BinaryTree<int>(23),
              new BinaryTree<int>(6,
                  new BinaryTree<int>(10),
                  new BinaryTree<int>(21))),
          new BinaryTree<int>(15,
              new BinaryTree<int>(3),
              null));
 
            binaryTree.PrintInOrder();
            Console.WriteLine("in-order");
            binaryTree.PrintPostOrder();
            Console.WriteLine("post-order");
            binaryTree.PrintPreOrder();
            Console.WriteLine("pre-order");
        }
    }
}
