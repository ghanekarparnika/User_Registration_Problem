using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linked_List
{
    public class LinkedList_Demo
    {

        private Node head;

        public LinkedList_Demo()
        {
            head = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

        }
        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        public void PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty. Nothing to delete.");
                return;
            }

            if (head.Next == null)
            {
                head = null;
                return;
            }

            Node current = head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            current.Next = null;
        }

        public Node Search(int key)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == key)
                {
                    return current; // Found the node with the given key
                }
                current = current.Next;
            }
            return null; // Node with the key not found
        }

    }
  



}

