using DataStructureIITLecture_2.Stack.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_2.Stack.Implementation
{
    public class StackCircularLinkedList : IStack
    {
        Node head;
        public StackCircularLinkedList()
        {
            head = null;
        }
        public bool IsEmpty()
        {
            return head == null;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            else if (head.next == head)
            {
                int n = head.data;
                head = null;
                return n;
            }
            else
            {
                int val = head.data;
                head.data = head.next.data;
                head.next = head.next.next;
                return val;
            }

        }

        public void Push(int num)
        {
           if(IsEmpty())
            {
                head = new Node(num);
                head.next = head;
            }
           else
            {
                Node n = new Node(head.data);
                n.next = head.next;
                head.data = num;
                head.next = n;              
            }
           

        }

        public int Top()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            else
            {
                return head.data;
            }
        }
    }
}
