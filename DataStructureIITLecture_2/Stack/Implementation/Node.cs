using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_2.Stack.Implementation
{
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }
}
