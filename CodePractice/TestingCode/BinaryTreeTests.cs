using CodePractice.Tree;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingCode
{
    public class BinaryTreeTests
    {
        [Test]
        public void TestTraversal()
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            Console.WriteLine("Preorder traversal "
                              + "of binary tree is ");
            BinaryTreeService.Preorder(tree.root);

            Console.WriteLine("\nInorder traversal "
                              + "of binary tree is ");
            BinaryTreeService.Inorder(tree.root);

            Console.WriteLine("\nPostorder traversal "
                              + "of binary tree is ");
            BinaryTreeService.Postorder(tree.root);
        }
    }
}
