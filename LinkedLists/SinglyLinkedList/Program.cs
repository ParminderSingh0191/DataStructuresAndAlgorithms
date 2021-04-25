using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = new Node(100);
            var node2 = node1.InsertNext(200);
            var node3 = node2.InsertNext(300);
            var node4 = node3.InsertNext(400);
            var node5 = node4.InsertNext(500);

            node1.Traverse(null);
        }

    }

    public class Node
    {
        private int data;
        private Node Next;

        public Node(int data)
        {
            this.data = data;
            Next = null;
        }

        public Node InsertNext(int value)
        {
            var node = new Node(value);

            if(Next == null)
            {
                node.Next = null;
                Next = node;
            }
            else
            {
                var temp = Next;
                node.Next = temp;
                Next = node;
            }

            return node;
        }

        public void Traverse(Node node)
        {
            if(node == null)
            {
                node = this;
            }

            while(node != null)
            {
                Console.WriteLine(node.data);
                node = node.Next;
            }
        }
    }
}
