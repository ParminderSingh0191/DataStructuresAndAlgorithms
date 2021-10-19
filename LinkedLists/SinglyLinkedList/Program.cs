using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList();

            linkedList.AddNodeToTheEnd(1);
            linkedList.AddNodeToTheEnd(2);
            linkedList.AddNodeToTheEnd(3);
            linkedList.AddNodeToTheEnd(4);
            linkedList.AddNodeToTheEnd(5);

            linkedList.Print();
            linkedList.DeleteNodeWithValue(2);

            Console.ReadKey();
        }

    }

    public class Node
    {
        public int Data { get; private set; }

        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
        }
    }

    public class LinkedList
    {
        private Node head;

        public void AddNodeToTheEnd(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new Node(data);
        }

        public void AddNodeToTheBeginning(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }

            var newHead = new Node(data);
            newHead.Next = head;
            head = newHead;
        }

        public void DeleteNodeWithValue(int data)
        {
            if (head == null)
            {
                return;
            }

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;

            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }

                current = current.Next;
            }
        }

        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("There is nothing to print because head not is empty.");
            }

            Node current = head;
            while (current.Next != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }

            if (current.Next == null)
            {
                Console.Write(current.Data);
            }
        }
    }
}
