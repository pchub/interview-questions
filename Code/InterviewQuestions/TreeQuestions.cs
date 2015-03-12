using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class TreeNode
    {
        public TreeNode(int key)
        {
            this.Key = key;
        }

        public int Key { get; private set; }

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }

        public TreeNode Parent { get; set; }
    }

    public static class TreeQuestions
    {
        public static TreeNode GetNextNode(TreeNode node)
        {
            if (node.Right != null)
            {
                node = node.Right;
                while (true)
                {
                    if (node.Left == null) return node;
                    node = node.Left;
                }
            }
            else if (node.Parent != null)
            {
                if(node.Parent.Right == node) return null;
                while (true)
                {
                    
                }
            }
            else
            {
                return null;
            }
        }

        public static Queue<TreeNode> TraverseInOrder(TreeNode root)
        {
            if (root == null) return null;

            var currentQueue = new Queue<TreeNode>();
            var leftTree = TraverseInOrder(root.Left);
            if (leftTree != null)
            {
                foreach (var treeNode in leftTree)
                {
                    currentQueue.Enqueue(treeNode);
                }
            }

            currentQueue.Enqueue(root);

            var rightTree = TraverseInOrder(root.Right);
            if (rightTree != null)
            {
                foreach (var treeNode in rightTree)
                {
                    currentQueue.Enqueue(treeNode);
                }
            }

            return currentQueue;
        }

        public static Queue<TreeNode> TraversePreOrder(TreeNode root)
        {
            if (root == null) return null;

            var currentQueue = new Queue<TreeNode>();

            currentQueue.Enqueue(root);

            var leftTree = TraversePreOrder(root.Left);
            if (leftTree != null)
            {
                foreach (var treeNode in leftTree)
                {
                    currentQueue.Enqueue(treeNode);
                }
            }

            var rightTree = TraversePreOrder(root.Right);
            if (rightTree != null)
            {
                foreach (var treeNode in rightTree)
                {
                    currentQueue.Enqueue(treeNode);
                }
            }

            return currentQueue;
        }

        public static Queue<TreeNode> TraversePostOrder(TreeNode root)
        {
            if (root == null) return null;

            var currentQueue = new Queue<TreeNode>();

            var leftTree = TraversePostOrder(root.Left);
            if (leftTree != null)
            {
                foreach (var treeNode in leftTree)
                {
                    currentQueue.Enqueue(treeNode);
                }
            }

            var rightTree = TraversePostOrder(root.Right);
            if (rightTree != null)
            {
                foreach (var treeNode in rightTree)
                {
                    currentQueue.Enqueue(treeNode);
                }
            }

            currentQueue.Enqueue(root);

            return currentQueue;
        }

        public static Queue<TreeNode> BreadthFirstTraversal(TreeNode root)
        {
            var traversedNodes = new Queue<TreeNode>();
            var helperQueue = new Queue<TreeNode>();
            helperQueue.Enqueue(root);

            while (helperQueue.Count > 0)
            {
                var node = helperQueue.Dequeue();

                traversedNodes.Enqueue(node);

                if (node.Left != null) helperQueue.Enqueue(node.Left);
                if (node.Right != null) helperQueue.Enqueue(node.Right);
            }

            return traversedNodes;
        }
    }
}
