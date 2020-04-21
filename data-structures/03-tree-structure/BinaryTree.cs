using System.Text;

namespace _01_time_complexity
{
    /// <summary>
    /// Binary Tree Logic
    /// </summary>
    public class BinaryTree
    {
        static int maxSum = 0;
        public static StringBuilder path = new StringBuilder();
        public static Node maxLeaf = null;

        /// <summary>
        /// This method is applying PreOrder Traversal of binary tree to get the max sum
        /// PreOrder Traversal - It starts from root then left then right
        /// </summary>
        /// <param name="root">Root of the tree</param>
        /// <param name="sum">Sum</param>
        public static int MaxSumLeafToRoot(Node root, int sum)
        {
            if (root == null)
                return 0;

            sum += root.Data;

            if (root.Left == null && root.Right == null && sum > maxSum)
            {
                maxLeaf = root;
                maxSum = sum;
            }
            MaxSumLeafToRoot(root.Left, sum);
            MaxSumLeafToRoot(root.Right, sum);

            return maxSum;
        }

        public static bool PathToMaxLeaf(Node rootNode, Node maxLeaf)
        {
            if (rootNode == null) return false;

            if (rootNode == maxLeaf || PathToMaxLeaf(rootNode.Left, maxLeaf) || PathToMaxLeaf(rootNode.Right, maxLeaf))
            {
                path.Append($"{rootNode.Data},");
                return true;
            }
            else
                return false;
        }
    }
}
