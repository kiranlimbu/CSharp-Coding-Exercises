using System;

namespace LinkedListNode
{
    public class Node
    {
        public int val;
        public Node next;

        // constructor
        public Node(int x) { val = x; next = null; }

        // create method to display
        public void Print()
        {
            Console.Write(val + "->");
            // recursive
            if (next != null) next.Print();
        }

        // create method to add sorted
        public void AddSorted(int val)
        {
            if (next == null) next = new Node(val);
            else if (val < next.val)
            {
                Node temp = new Node(val);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(val);
            }

        }

        // create method to add
        public void AddToEnd(int val)
        {
            if (next == null) next = new Node(val);
            else next.AddToEnd(val);
        }
    }

    // create class with headNode
    public class MyList
    {
        // property
        public Node headNode;
        // constructor
        public MyList()
        {
            headNode = null;
        }

        // create method to add
        public void AddToEnd(int val)
        {
            if (headNode == null) headNode = new Node(val);
            else headNode.AddToEnd(val);
        }

        // create method to addSorted
        public void AddSorted(int val)
        {
            if (headNode == null) headNode = new Node(val);
            else if (val < headNode.val)
            {
                Node temp = new Node(val);
                temp.next = headNode;
                headNode = temp;
                // you could simply write
                // AddToBeginning(val);
            }
            else
            {
                headNode.AddSorted(val);
            }
        }

        // create method to add to beginning
        public void AddToBeginning(int val)
        {
            if (headNode == null) headNode = new Node(val);
            else
            {
                Node temp = new Node(val);
                temp.next = headNode;
                headNode = temp;
            }
        }

        // create method to display. uses attribues from Node class
        public void Print()
        {
            if (headNode != null) headNode.Print();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using basic structure");
            // basic structure
            Node myNode = new Node(7);
            myNode.next = new Node(11);
            myNode.next.next = new Node(8);
            myNode.next.next.next = new Node(1);
            myNode.Print();

            Console.WriteLine("\n\nUsing method");
            // add using method
            Node myNode1 = new Node(7);
            myNode1.AddToEnd(11);
            myNode1.AddToEnd(8);
            myNode1.AddToEnd(1);
            myNode1.Print();

            Console.WriteLine("\n\nUsing method in MyList Class");
            // add using MyList class, AddToEnd method
            MyList myNode2 = new MyList(); // this constructor does not take parameter
            myNode2.AddToEnd(7);
            myNode2.AddToEnd(11);
            myNode2.AddToEnd(8);
            myNode2.AddToEnd(1);
            myNode2.Print(); // this Print method still uses attributes from Node class Print

            Console.WriteLine("\n\nUsing Add to Beginning method");
            // add using AddToBeginning Method
            MyList myNode3 = new MyList(); // this constructor does not take parameter
            // use add to beginning method
            myNode3.AddToBeginning(7);
            myNode3.AddToBeginning(11);
            myNode3.AddToBeginning(8);
            myNode3.AddToBeginning(1);
            myNode3.Print();

            Console.WriteLine("\n\nUsing Sorted method");
            // add sorted
            MyList myNode4 = new MyList();
            myNode4.AddSorted(7);
            myNode4.AddSorted(11);
            myNode4.AddSorted(8);
            myNode4.AddSorted(1);
            myNode4.Print();


            Console.ReadLine();
        }
    }
}
