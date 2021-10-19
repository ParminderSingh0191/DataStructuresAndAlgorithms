using System;
using System.Collections;
using System.Collections.Generic;

namespace DoublyLinkedList.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new DoublyLinkedList();

            linkedList.AddNodeAtTheEnd(1);
            linkedList.AddNodeAtTheEnd(2);
            linkedList.AddNodeAtTheEnd(3);

            linkedList.AddNodeAtTheBeginning(4);

            linkedList.DeleteANodeWithValue(2);
        }
    }

    public class Node
    {
        public int Data { get; private set; }

        public Node Next { get; set; }

        public Node Previous { get; set; }

        public Node(int data)
        {
            Data = data;
        }
    }

    public class DoublyLinkedList
    {
        private Node HeadNode;

        public void AddNodeAtTheEnd(int data)
        {
            if (HeadNode == null)
            {
                HeadNode = new Node(data);
                return;
            }

            Node currentNode = HeadNode;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = new Node(data);
            currentNode.Next.Previous = currentNode;
        }

        public void AddNodeAtTheBeginning(int data)
        {
            if (HeadNode == null)
            {
                HeadNode = new Node(data);
                return;
            }

            var newHead = new Node(data);
            newHead.Next = HeadNode;
            HeadNode.Previous = newHead;
            HeadNode = newHead;
        }

        public void DeleteANodeWithValue(int data)
        {
            if (HeadNode == null)
            {
                Console.WriteLine("There is nothing to delete");
                return;
            }

            if (HeadNode.Data == data)
            {
                HeadNode = HeadNode.Next;
                HeadNode.Previous = null;

                return;
            }

            var current = HeadNode;

            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    current.Next.Previous = current;

                    return;
                }

                current = current.Next;
            }
        }
    }
}
