using BinarySearchTree.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Tree;

namespace BinarySearchTree.Implementation
{
    public class BinaryTreeProcess : IBinaryTree
    {
        public void Delete(Node root, int data)
        {
            Node prevNode = new Node(0);
            Node n = Search(root, data, ref prevNode);
            if (n == null)
            {
                Console.WriteLine($"Node {data} not found");
                return;
            }
            else if (n.left == null && n.right == null)
            {
                if(prevNode.left != null && prevNode.left.data == data)
                {
                    prevNode.left = null;
                }
                else if(prevNode.right != null && prevNode.right.data == data)
                {
                    prevNode.right = null;
                }

                return;

            }
            else if(n.left != null && n.right == null )
            {
                n.data = n.left.data;
                n.left = null;
                return;
            }
            else if (n.right != null && n.left == null)
            {
                n.data = n.right.data;
                n.right = null;
                return;
            }
            else
            {
                //TODO complete this later
            }




        }

        public Node Maximum(Node root)
        {
            if (root.right == null)
                return root;

            return Maximum(root.right);
        }

        public Node Minimum(Node root)
        {
            if (root.left == null)
                return root;

            return Minimum(root.left);
        }

        public void Predecessor(Node root, int data, ref Node pre)
        {
          if(root.data < data)
            {
                pre = root;
                Predecessor(root.right, data, ref pre);
            }
          else if(root.data == data)
            {
                if(root.left == null && root.right == null)
                {
                    return;
                }

                if(root.left == null)
                {
                    Node min = Minimum(root.right);
                    pre = pre.data < min.data ? pre : min;                   
                }
                else
                {
                    pre = Minimum(root.left);
                }
                return;
            }
          else if(root.data > data)
            {
                Predecessor(root.left, data, ref pre);
            }
        }

        public void Replace(Node root, int first, int second)
        {
            Node prevRoot = new Node(0);
            Node n = Search(root, first, ref prevRoot);
            if (n == null)
            {
                Console.WriteLine($"Node {first} not found");
                return;
            }
            else
            {
                n.data = second;
            }
        }

        private Node Search(Node root, int first, ref Node prev)
        {
            if (root == null)
            {
                Console.WriteLine($"{first} element not found in the tree");
                return null;
            }

            if (root.data == first)
            {               
                return root;
            }

            if (first < root.data)
            {
                prev = root;
                return Search(root.left, first, ref prev);
            }

            if (first > root.data)
            {
                prev = root;
                return Search(root.right, first, ref prev);
            }

            return null;
        }

        public void Successon(Node root, int data, ref Node suc)
        {
            if (root.data > data)
            {
                suc = root;
                Successon(root.left, data, ref suc);
            }
            else if (root.data == data)
            {
                if(root.left == null && root.right == null)
                {
                    return;
                }
                if (root.right != null)
                {
                    Node min = Minimum(root.right);
                    suc = suc.data < min.data ? suc : min;
                    return;
                }
            }
            else if (root.data < data)
            {
                Successon(root.right, data, ref suc);
            }
        }
    }
}
