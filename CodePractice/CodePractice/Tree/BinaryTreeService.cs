using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Tree
{
    public class BinaryTreeService
    {
        public static Node Search(Node root, int val)
        {
            if (root == null || root.data == val)
                return root;

            if (root.data > val)
                return Search(root.left, val);

            return Search(root.right, val);
        }

        public static Node Insert(Node root, int data)
        {
            if(root == null)
            {
                root = new Node(data);
                return root;
            }

            if(root.data > data)
            {
                root.left = Insert(root.left, data);
            }

            root.right = Insert(root.right, data);

            return root;
        }

        #region traversal

        public static void Inorder(Node root)
        {
            if (root == null)
                return;

            Inorder(root.left);
            Console.WriteLine(root.data);
            Inorder(root.right);
        }

        public static void Preorder(Node root)
        {
            if (root == null)
                return;

            Console.WriteLine(root.data);
            Preorder(root.left);
            Preorder(root.right);
        }

        public static void Postorder(Node root)
        {
            if (root == null)
                return;

            Postorder(root.left);
            Postorder(root.right);
            Console.WriteLine(root.data);
        }

        #endregion


    }
}
