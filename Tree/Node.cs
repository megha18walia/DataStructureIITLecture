using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class Node
    {
        public string info;
        public int data;
        public Node left;
        public Node right;

        public Node(string info)
        {
            this.info = info;
            this.left = null;
            this.right = null;
        }

        public Node(int info)
        {
            this.data = info;
            this.left = null;
            this.right = null;
        }

    }
}
