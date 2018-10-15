using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure
{
    /// <summary> Represents a tree data structure </summary> 
    /// <typeparam name="T">the type of the values in the tree</typeparam> 
    public class Tree<T>
    {
        // The root of the tree 
        private TreeNode<T> root;

        /// <summary> Constructs the tree </summary> 
        /// <param name="value">the value of the node</param> 
        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.root = new TreeNode<T>(value);
        }

        /// <summary> Constructs the tree </summary> 
        /// <param name="value">the value of the root node</param> 
        /// <param name="children">the children of the root node</param> 
        public Tree(T value, params Tree<T>[] children)
          : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        /// <summary> The root node or null if the tree is empty </summary> 
        public TreeNode<T> Root => this.root;

        /// <summary> Traverses and prints tree in Depth First Search (DFS) order </summary> 
        /// <param name="root">the root of the tree to be traversed</param> 
        /// <param name="spaces">the spaces used for representation 
        /// of the parent-child relation</param> 
        private void PrintDFS(TreeNode<T> root, string spaces)
        {
            if (this.root == null)
            {
                return;
            }
            
            Console.WriteLine(spaces + root.Value);

            TreeNode<T> child = null;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                PrintDFS(child, spaces + "   ");
            }
        }

        /// <summary> Traverses and prints tree in Depth First Search (DFS) order </summary> 
        public void PrintDFS() => this.PrintDFS(this.root, string.Empty);
                
        /// <summary> Traverses and finds the occurances of TreeNode value </summary> 
        public int CountOccurances(TreeNode<T> obj) // is this OK???
        {
            if (this.root == null)
            {
                return 0;
            }

            int counter = 0;

            TreeNode<T> child = this.root;
            Stack<TreeNode<T>> children = new Stack<TreeNode<T>>();
            children.Push(child);
            while (children.Count > 0)
            {
                child = children.Pop();
                if (child.Value.Equals(obj.Value))
                {
                    counter++;
                }
                for (int i = 0; i < child.ChildrenCount; i++)
                {
                    children.Push(child.GetChild(i));
                }
            }
            return counter;
        }
    }
}
