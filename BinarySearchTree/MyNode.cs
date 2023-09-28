using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class MyNode<T> : INode<T> where T : IComparable<T>
    {
       public T Key { get; private set; }

        public INode<T> Left { get; set; }

        public INode<T> Right { get; set; }

        public MyNode(T key)
        {
            Key = key;
            Left = null;
            Right = null;
        }

        public int CompareTo(INode<T> other)
        {
            return Key.CompareTo(other.Key);
        }

        public int CompareTo(T? other)
        {
            throw new NotImplementedException();
        }
    }
}
