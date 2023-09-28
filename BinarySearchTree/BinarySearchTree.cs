using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private INode<T> root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Add(T key) 
        {
            root = AddRecursive(root, key);
        }

        private INode<T> AddRecursive(INode<T> current, T key)
        {
            if (current == null)
            {
                return new MyNode<T>(key);
            }

            if (key.CompareTo(current.Key) < 0)
            {
                current.Left = AddRecursive(current.Left, key);
            }
            else if (key.CompareTo(current.Key) > 0)
            {
                current.Right = AddRecursive(current.Right, key);
            }

            return current;
        }


        public void Display()
        {
            InOrderTraversal(root);
        }


        private void InOrderTraversal(INode<T> node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.Write(node.Key + " ");
                InOrderTraversal(node.Right);
            }
        }



        public bool Search(T key)
        {
            return SearchRecursive(root, key);
        }



        private bool SearchRecursive(INode<T> current, T key)
        {
            if (current == null)
            {
                // The key is not found in the current subtree
                return false;
            }

            // Compare the key with the current node's key
            int comparison = key.CompareTo(current.Key);

            if (comparison == 0)
            {
                // The key matches the current node's key, so it's found
                return true;
            }
            else if (comparison < 0)
            {
                // If the key is less than the current node's key, search in the left subtree
                return SearchRecursive(current.Left, key);
            }
            else
            {
                // If the key is greater than the current node's key, search in the right subtree
                return SearchRecursive(current.Right, key);
            }
        }
    }
}
