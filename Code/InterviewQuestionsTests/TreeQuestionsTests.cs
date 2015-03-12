using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class TreeQuestionsTests
    {
        [TestMethod]
        public void InOrderTraversalBasicTest()
        {
            var root = new TreeNode(5);
            root.Left = new TreeNode(3);
            root.Left.Left = new TreeNode(2);
            root.Left.Right = new TreeNode(4);

            root.Right = new TreeNode(8);
            root.Right.Left = new TreeNode(6);
            root.Right.Right = new TreeNode(9);

            var traversedNodes = TreeQuestions.TraverseInOrder(root);

            Assert.AreEqual(2, traversedNodes.Dequeue().Key);
            Assert.AreEqual(3, traversedNodes.Dequeue().Key);
            Assert.AreEqual(4, traversedNodes.Dequeue().Key);
            Assert.AreEqual(5, traversedNodes.Dequeue().Key);
            Assert.AreEqual(6, traversedNodes.Dequeue().Key);
            Assert.AreEqual(8, traversedNodes.Dequeue().Key);
            Assert.AreEqual(9, traversedNodes.Dequeue().Key);
        }

        [TestMethod]
        public void PreOrderTraversalBasicTest()
        {
            var root = new TreeNode(5);
            root.Left = new TreeNode(3);
            root.Left.Left = new TreeNode(2);
            root.Left.Right = new TreeNode(4);

            root.Right = new TreeNode(8);
            root.Right.Left = new TreeNode(6);
            root.Right.Right = new TreeNode(9);

            var traversedNodes = TreeQuestions.TraversePreOrder(root);

            Assert.AreEqual(5, traversedNodes.Dequeue().Key);
            Assert.AreEqual(3, traversedNodes.Dequeue().Key);
            Assert.AreEqual(2, traversedNodes.Dequeue().Key);
            Assert.AreEqual(4, traversedNodes.Dequeue().Key);
            Assert.AreEqual(8, traversedNodes.Dequeue().Key);
            Assert.AreEqual(6, traversedNodes.Dequeue().Key);
            Assert.AreEqual(9, traversedNodes.Dequeue().Key);
        }

        [TestMethod]
        public void PostOrderTraversalBasicTest()
        {
            var root = new TreeNode(5);
            root.Left = new TreeNode(3);
            root.Left.Left = new TreeNode(2);
            root.Left.Right = new TreeNode(4);

            root.Right = new TreeNode(8);
            root.Right.Left = new TreeNode(6);
            root.Right.Right = new TreeNode(9);

            var traversedNodes = TreeQuestions.TraversePostOrder(root);

            Assert.AreEqual(2, traversedNodes.Dequeue().Key);
            Assert.AreEqual(4, traversedNodes.Dequeue().Key);
            Assert.AreEqual(3, traversedNodes.Dequeue().Key);
            Assert.AreEqual(6, traversedNodes.Dequeue().Key);
            Assert.AreEqual(9, traversedNodes.Dequeue().Key);
            Assert.AreEqual(8, traversedNodes.Dequeue().Key);
            Assert.AreEqual(5, traversedNodes.Dequeue().Key);
        }

        [TestMethod]
        public void BreadthFirstTraversalBasicTest()
        {
            var root = new TreeNode(5);
            root.Left = new TreeNode(3);
            root.Left.Left = new TreeNode(2);
            root.Left.Right = new TreeNode(4);

            root.Right = new TreeNode(8);
            root.Right.Left = new TreeNode(6);
            root.Right.Right = new TreeNode(9);

            var traversedNodes = TreeQuestions.BreadthFirstTraversal(root);

            Assert.AreEqual(5, traversedNodes.Dequeue().Key);
            Assert.AreEqual(3, traversedNodes.Dequeue().Key);
            Assert.AreEqual(8, traversedNodes.Dequeue().Key);
            Assert.AreEqual(2, traversedNodes.Dequeue().Key);
            Assert.AreEqual(4, traversedNodes.Dequeue().Key);
            Assert.AreEqual(6, traversedNodes.Dequeue().Key);
            Assert.AreEqual(9, traversedNodes.Dequeue().Key);
        }
    }
}
