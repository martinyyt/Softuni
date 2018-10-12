using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeStructure
{
    public class BinaryTree<T>
    {
        /// <summary> Constructs a binary tree </summary> 
        /// <param name="value">the value of the tree node</param> 
        /// <param name="leftChild">the left child of the tree</param> 
        /// <param name="rightChild">the right child of the tree</param> 
        public BinaryTree(T value, BinaryTree<T> leftChild,
            BinaryTree<T> rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        /// <summary> Constructs a binary tree with no children </summary> 
        /// <param name="value">the value of the tree node</param> 
        public BinaryTree(T value)
            : this(value, null, null)
        {
        }

        /// <summary> The value stored in the current node </summary> 
        public T Value { get; set; }

        /// <summary> The left child of the current node </summary> 
        public BinaryTree<T> LeftChild { get; private set; }

        /// <summary> The right child of the current node </summary> 
        public BinaryTree<T> RightChild { get; private set; }

        /// <summary> Traverses binary tree in in-order; left-root-right </summary> 
        public void PrintInOrder()
        {
            /// 1. Visit the left child 
            if (this.LeftChild != null)
            {
                this.LeftChild.PrintInOrder();
            }

            // 2. Visit the root of this subtree 
            Console.Write(this.Value + " ");

            // 3. Visit the right child 
            if (this.RightChild != null)
            {
                this.RightChild.PrintInOrder();
            }
        }
        /// <summary> Traverses binary tree in pre-order; root-left-right </summary>
        public void PrintPreOrder() // To do by myself!!! / 1. visit root / 2. visit left child / 3. visit right child
        {
            //visit root
            Console.Write(this.Value + " ");
            // visit left child
            if (this.LeftChild != null)
            {
                this.LeftChild.PrintPreOrder();
            }
            // visit right child
            if (this.RightChild != null)
            {
                this.RightChild.PrintPreOrder();
            }
        }
        /// <summary> Traverses binary tree in post-order;left-right-root </summary>
        public void PrintPostOrder() // To do by myself!!! / 1. visit left child / 2. visit right child / 3. visit root
        {
            // visit left child
            if (this.LeftChild != null)
            {
                this.LeftChild.PrintPostOrder();
            }
            // visit right child
            if (this.RightChild != null)
            {
                this.RightChild.PrintPostOrder();
            }
            //visit root
            Console.Write(this.Value + " ");
        }
    }
}
