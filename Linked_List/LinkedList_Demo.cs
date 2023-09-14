using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linked_List
{
    internal class LinkedList_Demo
    {
        public Node head;
       /* public void addNode(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine(data + " is inserted into the linkedlist");
        }*/


        public void appendNode(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else 
            {
                Node current = head;
                while (current.Next != null) 
                {
                    current = current.Next; ;
                }
                current.Next = node;
            }
            Console.WriteLine(data + " is appended to the linkedlist");
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                Node tempNode = head;
                while (tempNode != null)
                {
                    Console.Write(tempNode.data + "-->");
                    tempNode = tempNode.Next;
                }
            }
        }
    }
}
