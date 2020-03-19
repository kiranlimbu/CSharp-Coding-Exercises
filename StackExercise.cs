using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode155
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack myStack = new MinStack();
            myStack.Push(2);
            myStack.Push(5);
            myStack.Push(3);
            myStack.Push(1);

            int minVal = myStack.GetMin();
            Console.WriteLine(minVal);

        }

        public class MinStack
        {
            /** initialize your data structure here. */
            LinkedList<int> obj;
            public MinStack()
            {
                obj = new LinkedList<int>();
            }

            public void Push(int x)
            {
                obj.AddFirst(x);
            }

            public void Pop()
            {
                if (obj.Any()) // checks if the sequence has any element
                {
                    obj.RemoveFirst();
                }
                else
                {
                    throw new Exception("Stack is empty");
                }
                
            }

            // Peek
            public int Top()
            {
                if (obj.Any())
                {
                    return obj.First();
                }
                else
                {
                    return 0;
                }
                
            }

            public int GetMin()
            {
                if (!obj.Any()) return 0;

                int num = obj.First.Value;
                foreach(int item in obj)
                {
                    if(item < num)
                    {
                        num = item;
                    }
                    
                }
                return num;
            }
        }

    }
}
