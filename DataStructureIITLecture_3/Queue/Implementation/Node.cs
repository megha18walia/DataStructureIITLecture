using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_3.Queue.Implementation
{
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int data = 0)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }
}
