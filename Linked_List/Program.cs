// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//UC1-Lets create a simple Linked List of 56, 30 and 70

using System.Collections.Generic;

LinkedList<int> list = new LinkedList<int>();
list.AddFirst(56);
list.AddLast(30);
list.AddLast(70);
Console.Write("Created Linked List: ");

foreach (int data in list)
{
    Console.Write(data+"-->");
}
