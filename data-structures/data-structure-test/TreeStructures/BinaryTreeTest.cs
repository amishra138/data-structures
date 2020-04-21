using _01_time_complexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace data_structure_test.TreeStructures
{
    [TestClass]
    public class BinaryTreeTest
    {
        [TestMethod]
        public void Test_BinaryTree_RootToLeafMaxSum()
        {
            //Tree Structure is 
            //                          5
            //              3                       6
            //          4       2           1               8
            //      9       11          4       2       9       6

            //Adding 1st level tree data
            Node rootNode = new Node(5)
            {
                Left = new Node(3),
                Right = new Node(6)
            };

            //Adding 2nd level tree data
            rootNode.Left.Left = new Node(4);
            rootNode.Left.Right = new Node(2);

            rootNode.Right.Left = new Node(1);
            rootNode.Right.Right = new Node(8);

            //Adding 3rd level data
            rootNode.Left.Left.Left = new Node(9);
            rootNode.Left.Left.Right = new Node(11);

            rootNode.Right.Left.Left = new Node(4);
            rootNode.Right.Left.Right = new Node(2);

            rootNode.Right.Right.Left = new Node(9);
            rootNode.Right.Right.Right = new Node(6);

            int expectedValue = 28;
            int actualValue = BinaryTree.MaxSumLeafToRoot(rootNode, 0);

            BinaryTree.PathToMaxLeaf(rootNode, BinaryTree.maxLeaf);

            var path = BinaryTree.path.ToString();

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
