using System;
using System.Collections.Generic;

namespace april4
{
    class Node
    {
        public int Val;
        public Node next;

        public Node(int x) { Val = x; }
        
        public void AddToEnd(int x)
        {
            if (next == null) next = new Node(x);
            else next.AddToEnd(x);
        }

        // leaner search
        public bool GetTagert(int target)
        {
            Node result = new Node(this.Val);

            while (next != null)
            {
                if (result.Val == target) return true;
                result = this.next;
                next = next.next;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Node myList = new Node(91);
            myList.AddToEnd(2);
            myList.AddToEnd(5);
            myList.AddToEnd(8);
            myList.AddToEnd(12);
            myList.AddToEnd(16);
            myList.AddToEnd(23);
            myList.AddToEnd(38);
            myList.AddToEnd(56);
            myList.AddToEnd(72);

            Console.WriteLine(myList.GetTagert(8));
            Console.WriteLine(myList.GetTagert(12));
            Console.WriteLine(myList.GetTagert(16));
            Console.WriteLine(myList.GetTagert(38));
            Console.WriteLine(myList.GetTagert(72));
            Console.WriteLine(myList.GetTagert(10));
            Console.WriteLine(myList.GetTagert(53));
            Console.WriteLine(myList.GetTagert(44));
        }
    }
    
}
