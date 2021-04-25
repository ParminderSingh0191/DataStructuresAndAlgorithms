using System;

namespace BasicTree
{
    public class Tree
    {
        public Node Root { get; set; }

        public Tree()
        {
            Root = null;
        }

        static Node newNode(int data)
        {
            Node node = new Node();

            node.Data = data;

            node.Left = null;
            node.Right = null;

            return node;
        }

        // A utility function to insert a new
        // Node with given key in BST
        public Node Insert(int data)
        {
            // Create a new Node containing
            // the new element
            Node newnode = newNode(data);

            // Pointer to start traversing from root and
            // traverses downward path to search
            // where the new node to be inserted
            Node rootNode = Root;

            // Pointer y maintains the trailing
            // pointer of x
            Node trailingPointer = null;

            while (rootNode != null)
            {
                trailingPointer = rootNode;
                if (data < rootNode.Data)
                    rootNode = rootNode.Left;
                else
                    rootNode = rootNode.Right;
            }

            // If the root is null i.e the tree is empty
            // The new node is the root node
            if (trailingPointer == null)
            {
                trailingPointer = newnode;
                Root = trailingPointer;
            }

            // If the new key is less then the leaf node key
            // Assign the new node to be its left child
            else if (data < trailingPointer.Data)
                trailingPointer.Left = newnode;

            // else assign the new node its right child
            else
                trailingPointer.Right = newnode;

            // Returns the pointer where the
            // new node is inserted
            return trailingPointer;
        }

        public void PreOrder(Node root)
        {
            // Data
            // Left Node
            // Right Node
            if(root != null)
            {
                Console.WriteLine(root.Data);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
        }

        public void InOrder(Node root)
        {
            // Left Node
            // Data
            // Right Node
            if(root != null)
            {
                InOrder(root.Left);
                Console.WriteLine(root.Data);
                InOrder(root.Right);
            }
        }

        public void PostOrder(Node root)
        {
            // Left Node
            // Right Node
            // Data
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                Console.WriteLine(root.Data);
            }
        }
    }
}
