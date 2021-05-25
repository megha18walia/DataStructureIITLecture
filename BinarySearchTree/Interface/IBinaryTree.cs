using System;
using System.Collections.Generic;
using System.Text;
using Tree;

namespace BinarySearchTree.Interface
{
    public interface IBinaryTree
    {
        Node Minimum(Node root);
        Node Maximum(Node root);
        void Replace(Node root, int first, int second);
        void Delete(Node root, int data);
        void Predecessor(Node root, int data, ref Node pre);
        void Successon(Node root, int data, ref Node pre);


    }
}
