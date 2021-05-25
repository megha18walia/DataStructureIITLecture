using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tree
{
    public class TreeData
    {
        public Node root;
        public Node CreateSimpleTree()
        {
            root = new Node("a");
            root.left = new Node("b");
            root.left.left = new Node("f");
            root.right = new Node("c");
            root.right.left = new Node("d");
            root.right.right = new Node("e");
            root.right.right.left = new Node("g");
            root.right.right.right = new Node("h");

            return root;
        }

        public Node CreateExpressionTree(Node root)
        {
            root = new Node("*");
            root.left = new Node("+");
            root.left.left = new Node("1");
            root.left.right = new Node("2");
            root.right = new Node("+");
            root.right.left = new Node("3");
            root.right.right = new Node("+");
            root.right.right.left = new Node("4");
            root.right.right.right = new Node("5");

            return root;
        }

        public Node CreateTreePrefixInfix(string pre, string inf)
        {
            char[] prefix = pre.ToCharArray();
            char[] infix = inf.ToCharArray();
            int i;

            if (prefix.Length == 0)
                return null ;

            if (infix.Length == 0)
                return null;

            Node root = new Node(prefix[0].ToString());

          

            for (i = 0; i< infix.Length; i++)
            {
                if(infix[i] == prefix[0])
                {
                    break;
                }
            }

            string preLeft = pre.Substring(1, i);
            string preRight = pre.Substring(i + 1);
            string inLeft = inf.Substring(0, i);
            string inRight = inf.Substring(i + 1);

            root.left = CreateTreePrefixInfix(preLeft, inLeft);
            root.right = CreateTreePrefixInfix(preRight, inRight);

            return root;
        }

        public Node CreateTreePostfixInfix(string post, string inf)
        {
            char[] postfix = post.ToCharArray();
            char[] infix = inf.ToCharArray();
            int i;

            int last = postfix.Length - 1;

            if (postfix.Length == 0)
                return null;

            if (infix.Length == 0)
                return null;

            Node root = new Node(postfix[last].ToString());

            for (i = 0; i < infix.Length; i++)
            {
                if (infix[i] == postfix[last])
                {
                    break;
                }
            }

            string postLeft = post.Substring(0, i);
            string postRight = post.Substring(i, last - i);
            string inLeft = inf.Substring(0, i);
            string inRight = inf.Substring(i + 1);

            root.left = CreateTreePostfixInfix(postLeft, inLeft);
            root.right = CreateTreePostfixInfix(postRight, inRight);

            return root;
        }


    }
}
