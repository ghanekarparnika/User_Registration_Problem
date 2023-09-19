// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//UC1-Lets create a simple Linked List of 56, 30 and 70

using Linked_List;
using System.Collections.Generic;



//UC-5Ability to delete the last element in the LinkedList of sequence 56->30->70 - Write popLast method
//- Note there is new tail
//- Final Sequence: 56->30

LinkedList_Demo linkedList = new LinkedList_Demo();
linkedList.Add(56);
linkedList.Add(30);
linkedList.Add(70);

Console.WriteLine("Original LinkedList:");
linkedList.Display();

linkedList.PopLast();

Console.WriteLine("Updated LinkedList:");
linkedList.Display();
