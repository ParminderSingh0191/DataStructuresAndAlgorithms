using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }

    public class Node
    {
        internal int data;
        internal Node Next;

        public Node(int data)
        {
            this.data = data;
            Next = null;
        }
    }
}
