using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList_Doubly
{
    class ListNode
    {
        public int value;
        public ListNode next;
        public ListNode pre;
        public ListNode(int x) { value = x; }        
    }

    class DoublyLinkedList : IEnumerable<ListNode>
    {
        public ListNode head;
        public ListNode tail;
        public int Length;

        public IEnumerator<ListNode> GetEnumerator()
        {
            ListNode cur = head;

            while (cur != null)
            {
                yield return cur;
                cur = cur.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable GetEnumeratorReverse()
        {
            ListNode cur = tail;
            
            while (cur != null)
            {
                yield return cur;
                cur = cur.pre;
            }

        }

        public void AddToEnd(int x)
        {
            ListNode tempNode = new ListNode(x);
            if (tail == null)
            {
                head = tempNode;
            }
            else
            { // connect the final nodes
                tempNode.pre = tail;
                tail.next = tempNode;
            }
            // set new tail
            tail = tempNode;
            Length++;
        }

        public void AddToFront(int x)
        {
            ListNode tempNode = new ListNode(x);
            tempNode.next = head;

            if (head == null)
            {
                tail = tempNode;
            }
            else
            {
                head.pre = tempNode;
            }

            head = tempNode;
            Length++;
        }

        public bool Contains(int x)
        {
            ListNode cur = head;

            while (cur != null)
            {
                if (cur.value == x)
                {
                    return true;
                }
                cur = cur.next;
            }

            return false;
        }

        public string Find(int x)
        {
            int count = 0;
            ListNode cur = head;

            while (cur != null)
            {
                count++;
                if (cur.value == x)
                {
                    return $"Integer {x} is at Node: {count}";
                }
                cur = cur.next;
            }

            return "Not Found";
        }

        // delete if the target val exist and return true
        public string Delete(int x) 
        {
            ListNode cur = head;

            while (cur != null)
            {
                if (cur.value == x)
                {
                    // move in from the end
                    if (cur.next == null)
                    {
                        // delete last item in the list
                        tail = cur.pre;
                    }
                    else
                    {
                        cur.next.pre = cur.pre;
                    }

                    // start from the front
                    if (cur.pre == null)
                    {
                        head = cur.next;
                    }
                    else
                    {
                        // tie nodes back together
                        cur.pre.next = cur.next;
                    }

                    cur = null;
                    Length--;
                    return "Done";
                }

                cur = cur.next;
            }

            return "Integer not in the List";
        }

        public string DeleteFirstNode()
        {
            if (head != null)
            {
                head = head.next;
                
                // empty list
                if (head == null)
                {
                    tail = null;
                }
                Length--;
                return "Done";
            }

            return "List is empty";
        }

        public string DeleteLastNode()
        {
            if (tail != null)
            {
                tail = tail.pre;
                tail.next = null;

                // empty list
                if (tail == null)
                {
                    head = null;
                    
                }
                Length--;
                return "Done";
            }

            return "List is empty";
        }

        public void Print()
        {
            while (head != null)
            {
                Console.Write(head.value + " => ");
                head = head.next;
            }
            if (head == null) Console.WriteLine("List is empty!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList myNode = new DoublyLinkedList();
            myNode.AddToEnd(2);
            myNode.AddToEnd(3);
            myNode.AddToEnd(42);
            myNode.AddToEnd(14);
            myNode.AddToFront(4);
            myNode.AddToEnd(32);
            myNode.AddToEnd(9);
            myNode.AddToFront(5);

            Console.WriteLine("Initial List:"); // print list
            foreach (var item in myNode)
            {
                Console.Write(item.value + " => ");
            }

            Console.WriteLine("\n\nRevered List:"); // print in reverse order
            foreach (ListNode item in myNode.GetEnumeratorReverse())
            {
                Console.Write(item.value + " => ");
            }

            Console.WriteLine("\n\nLength:"); // length
            Console.WriteLine(myNode.Length);

            Console.WriteLine("\nContains: 9"); // contains
            bool result = myNode.Contains(9);
            Console.WriteLine(result);

            Console.WriteLine("\nFind: 32"); // find
            Console.WriteLine(myNode.Find(32));

            Console.WriteLine("\nDelete: 32"); // delete
            Console.WriteLine(myNode.Delete(32));

            Console.WriteLine("\nFind: 32"); // find
            Console.WriteLine(myNode.Find(32));

            myNode.AddToFront(1); // add to front
            myNode.AddToEnd(99); // add to last

            Console.WriteLine("\nUpdated List:"); // print updated list
            foreach (var item in myNode)
            {
                Console.Write(item.value + " => ");
            }

            Console.WriteLine("\n\nDelete First Node:"); // delete first node
            Console.WriteLine(myNode.DeleteFirstNode());

            Console.WriteLine("\nUpdated List:"); // print updated list
            foreach (var item in myNode)
            {
                Console.Write(item.value + " => ");
            }

            int len = myNode.Length;
            for (int i = 0; i < len; i++)
            {
                myNode.DeleteLastNode();
            }


            Console.WriteLine("\n\nDisplay list:"); // print list after changes
            myNode.Print();
            Console.WriteLine();
           
            
        }
    }
}
