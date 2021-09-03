using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Tree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            this.left = this.right = null;
        }
    }

    public class BinaryTree
    {
        public Node root;

        public BinaryTree()
        { }

        public BinaryTree(int data)
        {
            root = new Node(data);
        }

        public void InsertIterative(int data)
        {
            var newNode = new Node(data);

            if(root == null)
            {
                root = newNode;
                return;
            }

            var tmp = root;

            while(true)
            {
                if(tmp.data > data)
                {
                    if (tmp.right == null)
                    {
                        tmp.right = newNode;
                        break;
                    }
                    else
                    {
                        tmp = tmp.right;
                    }
                }
                if (tmp.data < data)
                {
                    if (tmp.left == null)
                    {
                        tmp.left = newNode;
                        break;
                    }
                    else
                    {
                        tmp = tmp.left;
                    }
                }
            }
        }

        public Node SearchIterative(int val)
        {
            if(root == null)
            {
                return root;
            }

            var tmp = root;

            while(tmp != null)
            {
                if(tmp.data == val)
                {
                    return tmp;
                }

                if(tmp.data > val)
                {
                    tmp = tmp.left;
                }
                else
                {
                    tmp = tmp.right;
                }
            }

            return null;
        }
    }
}
