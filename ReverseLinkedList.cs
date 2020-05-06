using System;

namespace LinkedList_Reverse
{
    /// <summary>
    /// Example:
    /// 1 -> 2 -> 3 -> 4 -> 5 -> Null
    /// 
    /// Result:
    /// 5 -> 4 -> 3 -> 2 -> 1 -> Null
    /// </summary>
    /// 
    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }
        public ListNode(int val)
        {
            Value = val;
        }

        public void Print(ListNode head)
        {
            while (head != null)
            {
                Console.WriteLine(head.Value);
                head = head.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode mynode = new ListNode(1);
            mynode.Next = new ListNode(2);
            mynode.Next.Next = new ListNode(3);
            mynode.Next.Next.Next = new ListNode(4);
            mynode.Next.Next.Next.Next = new ListNode(5);

            //ListNode head = ReverseRecursively(mynode);
            //mynode.Print(head);

            Console.WriteLine("Reverse Iteratively");
            ListNode res = ReverseIteratively(mynode);
            mynode.Print(res);
        }

        public static ListNode ReverseRecursively(ListNode node)
        {
            if (node == null || node.Next == null) // base case
            {
                return node;
            }
            ListNode head = ReverseRecursively(node.Next); // returns 5, therefore, head = 5

            node.Next.Next = node; // when node = 4, node.next = 5, now 5 points at 4 
            node.Next = null; // node 4 points at null

            return head;
        }

        public static ListNode ReverseIteratively(ListNode head)
        {
            ListNode preNode = null;

            while (head != null)
            {
                ListNode tempNode = head.Next; // 2, 3, 4, 5, null
                head.Next = preNode; // null, 1, 2, 3, 4,
                preNode = head; // 1, 2, 3, 4, 5
                head = tempNode; // 2, 3, 4, 5, null
            }

            return preNode;
        }
    }  
}
