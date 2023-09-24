using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation
{
    internal class Stack_Using_LinkedList<T>
    {
        private LinkedList<T> linkedList = new LinkedList<T>();
        public void Push(T data)
        {
            linkedList.AddLast(data);
        }
        public T Peek()
        {
            if (linkedList.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return linkedList.Last.Value;
        }
    }
}
