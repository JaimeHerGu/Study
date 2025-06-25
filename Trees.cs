using System;

namespace TreesExample
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    class BinaryTree
    {
        public TreeNode Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void InOrderRec(TreeNode node)
        {
            if (node == null)
                return;

            // Traverse the left subtree
            InOrderRec(node.Left);
            // Visit the node
            Console.Write(node.Value + " ");
            // Traverse the right subtree
            InOrderRec(node.Right);
        }

        public void InOrderTraversal()
        {
            InOrderRec(Root);
        }

        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            // Manually creating a binary tree
            tree.Root = new TreeNode(1);
            tree.Root.Left = new TreeNode(2);
            tree.Root.Right = new TreeNode(3);
            tree.Root.Left.Left = new TreeNode(4);
            tree.Root.Left.Right = new TreeNode(5);

            Console.WriteLine("In-order traversal of the binary tree:");
            tree.InOrderTraversal(); // Output: 4 2 5 1 3
        }
    }
}