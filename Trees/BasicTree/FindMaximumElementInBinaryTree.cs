namespace BasicTree
{
    public class FindMaximumElementInBinaryTree
    {
        // Find maximum element in left subtree
        // Find maximum element in right subtree
        // Compare them with root data and select the one which is maximum
        // TimeComplexity O(n)
        // SpaceComplexity O(n)
        public int FindMaximum(Node rootNode)
        {
            int max = 0;
            if(rootNode != null)
            {
                int rootValue = rootNode.Data;
                int left = FindMaximum(rootNode.Left);
                int right = FindMaximum(rootNode.Right);

                if (left > right)
                {
                    max = left;
                }
                else
                {
                    max = right;
                }

                if(rootValue > max)
                {
                    max = rootValue;
                }
            }

            return max;
        }
    }
}
