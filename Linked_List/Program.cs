// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//UC1-Lets create a simple Linked List of 56, 30 and 70

using Linked_List;
using System.Collections.Generic;

/*Ability to delete 40 from the Linked List sequence of 56->30->40->70 and show the size of LinkedList is 3

- Write MSTest Test Case as demonstrated in class
-Search LinkedList to find node with key value 40
- Delete the node
- Implement size() and show the Linked List size is 3
- Final Sequence: 56->30->70*/

// Main method is used for running tests
var testClass = new LinkedListTests();
testClass.TestDeleteAndSize();