//Console.WriteLine("Hello, World!");
/*Ability to create a Stack of 56->30->70
- Use LinkedList to do the Stack Operations
- Here push will internally call add method on LinkedList.
- So 70 will be added first then 30 and then 56 to make 56 on top of the Stack*/

using Stack_Implementation;

Stack_Using_LinkedList<int> stack = new Stack_Using_LinkedList<int>();
stack.Push(70);
stack.Push(30);
stack.Push(56);

Console.WriteLine("Top of the stack: " + stack.Peek()); // Output: 56

