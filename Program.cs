using System;
using static System.Console;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }

        public void AddNextData(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddNextData(data);
            }
        }

        public void SortTheList(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.SortTheList(data);
            }
        }

        public void Print()
        {
            Write("The number is: " + data + ". ");
            if (next != null)
            {
                next.Print();
            }
        }
    }

    public class ReList
    {
        public Node firstNode;

        public ReList()
        {
            firstNode = null;
        }

        public void AddNextData(int data)
        {
            if (firstNode == null)
            {
                firstNode = new Node(data);
            }
            else
            {
                firstNode.AddNextData(data);
            }
        }

        public void SortTheList(int data)
        {
            if (firstNode == null)
            {
                firstNode = new Node(data);
            }
            else if (data < firstNode.data)
            {
                AddNewData(data);
            }
            else
            {
                firstNode.SortTheList(data);
            }
        }

        public void AddNewData(int data)
        {
            if (firstNode == null)
            {
                firstNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = firstNode;
                firstNode = temp;
            }
        }

        public void Print()
        {
            if (firstNode != null)
            {
                firstNode.Print();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ReList list = new ReList();
            list.SortTheList(6);
            list.SortTheList(7);
            list.SortTheList(115);
            list.SortTheList(89);
            list.SortTheList(90);
            list.SortTheList(66);
            list.Print();

        }
    }
}
