using System.Diagnostics;

namespace Stacks
{
    class Stack
    {
        public static void Main(string[] args)
        {
            Stack newStack = new Stack();
            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);

            Debug.WriteLine(newStack.Pop());
            Debug.WriteLine(newStack.Pop());
            Debug.WriteLine(newStack.Pop());
        }

        const int MAX = 1000;
        object[] stack = new object[MAX];
        int top;

        //Define a constructor:
        public Stack()
        {
            top = -1;
        }


        //Method to add to the stack:
        public void Push(object obj)
        {
            if(top < MAX)
            {
                stack[++top] = obj;
            }
        }

        //Method to get the last object in a stack and remove it:
        public object Pop()
        {
            if (top >= 0)
            {
                object o = stack[top];
                top--;
                return o;
            }
            else
            {
                return -1;
            }
        }

        //Method to get the last object in the stack: 
        public object Peek()
        {
            return stack[top];
        }
    }
}