using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();

            //the stack is empty

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.WriteLine(myStack.Peek());

            int topNumber = myStack.Pop();

            Console.WriteLine(myStack.Peek());

        }
    }
}
