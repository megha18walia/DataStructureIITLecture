using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_4.Dictionary.Implementation
{
    public class Node
    {
        public string phoneNumber;
        public string name;
        public int age;
        public Node next;
        public Node prev;

        public Node(string pNo, string name, int age)
        {
            this.phoneNumber = pNo;
            this.name = name;
            this.age = age;
            this.next = null;
            this.prev = null;
        }
    }
}
