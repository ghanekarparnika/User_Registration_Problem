using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int item;
        public Node leftc;
        public Node rightc;
        public int data;
        public Node(int data)
        {
            this.item = data;
            this.leftc = null;
            this.rightc = null;
        }
    }
}
