using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Linked_List
{
    public class LinkedList_Demo
    {

        private Node head;
        private int size;

        public LinkedList_Demo()
        {
            head = null;
            size = 0;
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
            size++;

        }


        public void Delete(int key)
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty. Deletion failed.");
                return;
            }

            if (head.Data == key)
            {
                head = head.Next;
                size--;
                return;
            }
            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == key)
                {
                    current.Next = current.Next.Next;
                    size--;
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Node with key" +key +" not found. Deletion failed.");
        }
        public Node Search(int key)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == key)
                {
                    Console.WriteLine("found key: "+current.Data);    
                    return current; // Found the node with the given key
                }
                current = current.Next;
            }
            return null; // Node with the key not found
        }
        public int Size()
        {
            return size;
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


    }

    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void TestDeleteAndSize()
        {
            LinkedList_Demo linkedList = new LinkedList_Demo();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(40);
            linkedList.Add(70);
            linkedList.Display();

            // Search for a node with value 40
            Node nodeToDelete = linkedList.Search(40);
            Assert.IsNotNull(nodeToDelete);

            // Delete the node with value 40
            linkedList.Delete(40);
            // Check if the deletion was successful
            Node deletedNode = linkedList.Search(40);
            Assert.IsNull(deletedNode);

            // Check the size of the linked list
            int listSize = linkedList.Size();
            Console.WriteLine("Size of the list: "+listSize);
            Assert.AreEqual(3, listSize);

            // Display the final sequence
            Console.WriteLine("Final Sequence:");
            linkedList.Display();
        }


    }
}

