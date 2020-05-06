using System;

namespace LeetCode5400
{
    class ListNode
    {
        public int Value;
        public ListNode Next;
        public ListNode(int val) { Value = val; }

        public void Print()
        {
            Console.Write(Value + "=>");
            if (Next != null) Next.Print();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            ListNode myNode = new ListNode(5);
            myNode.Next = new ListNode(1);
            myNode.Next.Next = new ListNode(4);
            myNode.Next.Next.Next = new ListNode(2);
            myNode.Next.Next.Next.Next = new ListNode(3);
            //BubbleSort(myNode);

            ListNode mergeSort = MergeSort(myNode);
            mergeSort.Print();

        }

        public static void BubbleSort(ListNode head)
        {
            ListNode i;
            ListNode j;

            for (i = head; i.Next != null; i = i.Next)
            {
                for (j = head; j.Next != null; j = j.Next)
                {
                    if (j.Value > j.Next.Value)
                    {
                        int temp = j.Value;
                        j.Value = j.Next.Value;
                        j.Next.Value = temp;
                    }
                }
            }

            head.Print();
        }

        public static ListNode MergeSort(ListNode head)
        {
            if (head == null || head.Next == null)
                return head;

            ListNode slowNode = head;
            ListNode fastNode = head;
            ListNode preNode = null;

            while (fastNode != null && fastNode.Next != null)
            {
                preNode = slowNode;
                slowNode = slowNode.Next;
                fastNode = fastNode.Next.Next;               
            }

            preNode.Next = null; // break LinkedList into two half
            ListNode firstHalf = MergeSort(head); // recursion
            ListNode secondHalf = MergeSort(slowNode); // slowNode is the beginning of second half
            return merge(firstHalf, secondHalf);
        }

        public static ListNode merge(ListNode lst1, ListNode lst2)
        {
            ListNode helper = new ListNode(0);
            ListNode result = helper;

            // sort nodes
            while (lst1 != null && lst2 != null)
            {
                if (lst1.Value < lst2.Value)
                {
                    result.Next = lst1;
                    lst1 = lst1.Next;
                }
                else
                {
                    result.Next = lst2;
                    lst2 = lst2.Next;
                }
                result = result.Next;
            }

            // if there is still some nodes left, put it in result
            if (lst1 != null)
            {
                result.Next = lst1;
            }

            if (lst2 != null)
            {
                result.Next = lst2;
            }

            return helper.Next;
        }
    }

}
