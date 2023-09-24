using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class SortedLinkedList<T> where T : IComparable<T>
    {
        private class Node
        {
            public T Data { get; }
            public Node Next { get; set; }
            public Node(T data)
            {
               Data = data;
            }
        }

        private Node head;

        public void Add(T data) 
        {
            Node newNode= new Node(data);
            if (head == null || data.CompareTo(head.Data) <=0) 
            {
                newNode.Next = head;
                head = newNode;
            }
            else 
            {
                Node current = head;
                while(current.Next != null && data.CompareTo(current.Next.Data) >0)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            Console.WriteLine(data+" is inserted");
        }

        public void Display()
        {
            Console.WriteLine("sorted linkedlist: ");
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
