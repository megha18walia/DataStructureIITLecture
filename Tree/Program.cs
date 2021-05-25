using System;
using Tree.Implementation;
using Tree.Interface;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeData tree = new TreeData();
            Node root = tree.CreateSimpleTree();
            TraverseTree(root);

            Node rootdata = tree.CreateTreePrefixInfix("abfcdegh", "fbadcgeh");
            TraverseTree(rootdata);

            Node rootDataPost = tree.CreateTreePostfixInfix("fbdgheca", "fbadcgeh");
            TraverseTree(rootDataPost);


            Console.WriteLine("Expression");
            ITraverse traverse = new TreeTraverse();
            traverse.PrintExpression(root);
            Console.WriteLine("");

            Console.ReadLine();

        }

        static void TraverseTree(Node root)
        {
            Console.WriteLine("Pre Order");
            ITraverse traverse = new TreeTraverse();
            traverse.PreOrder(root);
            Console.WriteLine("");

            Console.WriteLine("Post Order");
            traverse.PostOrder(root);
            Console.WriteLine("");

            Console.WriteLine("In Order");
            traverse.InOrder(root);
            Console.WriteLine("");
        }
    }
}
