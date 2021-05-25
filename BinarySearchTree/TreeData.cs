using System;
using System.Collections.Generic;
using System.Text;
using Tree;
using Tree.Implementation;
using Tree.Interface;

namespace BinarySearchTree
{
    public class TreeData
    {
        public Node root;

        ITraverse treeTraverse;
        public void CreateTree(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
                return;
            }
            else
            {
                InsertTree(node, root);
            }
        }

        private void InsertTree(Node node, Node rootData)
        {
            if(rootData.left == null && rootData.data > node.data )
            {
                rootData.left = node;
                return;
            }

            if (rootData.right == null && rootData.data < node.data)
            {
                rootData.right = node;
                return;
            }

            if(rootData.data > node.data)
            {
                InsertTree(node, rootData.left);
            }
            else if (rootData.data < node.data)
            {
                InsertTree(node, rootData.right);
            }


        }

        public void InOrderTraverse(Node root)
        {
            treeTraverse = new TreeTraverse();
            treeTraverse.InOrder(root);

        }

        public Node GetRoot()
        {
            return root;
        }
    }
}
