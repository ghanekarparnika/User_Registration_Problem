using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public interface INode<T> : IComparable<T>
    {
        T Key { get; }
        INode<T> Left { get; set; }
        INode<T> Right { get; set; }
        int CompareTo(INode<T> other);
    }
}
