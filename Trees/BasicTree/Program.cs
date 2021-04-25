using System;

namespace BasicTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            //Console.WriteLine("Tree PreOrder");
            //tree.PreOrder(tree.Root);

            //Console.WriteLine("Tree InOrder");
            //tree.InOrder(tree.Root);

            //Console.WriteLine("Tree PostOrder");
            //tree.PostOrder(tree.Root);

            var findMax = new FindMaximumElementInBinaryTree();
            var maxValue = findMax.FindMaximum(tree.Root);
            Console.WriteLine($"Maximum element in tree is: {maxValue}");

        }
    }
}
