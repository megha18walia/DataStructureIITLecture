using BinarySearchTree.Implementation;
using BinarySearchTree.Interface;
using System;
using Tree;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeData td = new TreeData();
            IBinaryTree tree = new BinaryTreeProcess();
            

            td.CreateTree(1000);
            td.CreateTree(900);
            td.CreateTree(800);
            td.CreateTree(850);
            td.CreateTree(950);
            td.CreateTree(940);
            td.CreateTree(930);
            td.CreateTree(970);
            td.CreateTree(1500);
            td.CreateTree(1250);
            td.CreateTree(1500);
            td.CreateTree(1530);
            td.CreateTree(1560);
            td.CreateTree(990);
            td.CreateTree(96);
            td.CreateTree(75);
            Node root = td.GetRoot();
            

            td.InOrderTraverse(root);
            Console.WriteLine("\n");
            ProcessData(root, tree, td);
            Console.ReadLine();
        }

        public static void ProcessData(Node root, IBinaryTree tree, TreeData td)
        {
            Console.WriteLine("Minimum Node in a tree : " + tree.Minimum(root).data);
            Console.WriteLine("Maximum Node in a tree : " + tree.Maximum(root).data);

            Console.WriteLine("Element Replace");
            td.InOrderTraverse(root);
            Console.WriteLine("\n");
            tree.Replace(root, 930, 910);
            td.InOrderTraverse(root);
            Console.WriteLine("\n");
            tree.Replace(root, 1530, 1540);
            td.InOrderTraverse(root);
            Console.WriteLine("\n");
            tree.Replace(root, 1970, 2000);
            td.InOrderTraverse(root);
            Console.WriteLine("\n");

            Node pre = new Node(0);
            tree.Predecessor(root, 970, ref pre);
            Console.WriteLine($"Predecessor of a node : 970 is " + pre.data);

            pre = new Node(0);
            tree.Predecessor(root, 1500, ref pre);
            Console.WriteLine($"Predecessor of a node : 1500 is " + pre.data);

            pre = new Node(0);
            tree.Predecessor(root, 96, ref pre);
            Console.WriteLine($"Predecessor of a node : 96 is " + pre.data);

            pre = new Node(0);
            tree.Predecessor(root, 910, ref pre);
            Console.WriteLine($"Predecessor of a node : 910 is " + pre.data);

            pre = new Node(0);
            tree.Successon(root, 850, ref pre);
            Console.WriteLine($"Successor of a node : 850 is " + pre.data);

            pre = new Node(0);
            tree.Successon(root, 96, ref pre);
            Console.WriteLine($"Successor of a node : 96 is " + pre.data);

            pre = new Node(0);
            tree.Successon(root, 910, ref pre);
            Console.WriteLine($"Successor of a node : 910 is " + pre.data);

            pre = new Node(0);
            tree.Successon(root, 850, ref pre);
            Console.WriteLine($"Successor of a node : 850 is " + pre.data);

            tree.Delete(root, 910);

        }
    }
}
