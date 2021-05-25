using System;
using System.Collections.Generic;
using System.Text;
using Tree.Interface;

namespace Tree.Implementation
{
    public class TreeTraverse : ITraverse
    {
        public void InOrder(Node root)
        {
            if (root == null)
                return;

            InOrder(root.left);
            Console.Write(root.info ?? root.data + "  ");
            InOrder(root.right);

        }

        public void PostOrder(Node root)
        {
            if (root == null)
                return;

            PostOrder(root.left);
            PostOrder(root.right);
            Console.Write(root.info + "  ");
        }

        public void PreOrder(Node root)
        {
            if (root == null)
                return;

            Console.Write(root.info + "  ");
            PreOrder(root.left);
            PreOrder(root.right);
        }

        public void PrintExpression(Node root)
        {
            if (root == null)
                return;

            if (root.left != null)
                Console.Write("( ");
            PrintExpression(root.left);
            Console.Write(root.info + " ");
            PrintExpression(root.right);
            if (root.right != null)
                Console.Write(" )");
        }


    }
}
