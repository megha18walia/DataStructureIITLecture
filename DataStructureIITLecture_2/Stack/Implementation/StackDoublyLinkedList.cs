using DataStructureIITLecture_2.Stack.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_2.Stack.Implementation
{
    
    public class StackDoublyLinkedList : IStack
    {
        Node head;
        Node tail;

        public StackDoublyLinkedList()
        {
            head = null;
            tail = null;
        }
        public bool IsEmpty()
        {
            return head == null;
        }

        public int Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            else if (head == tail)
            {
                Node temp = tail;
                tail = null;
                head = null;
                return temp.data;
            }
            else
            {
                Node temp = tail;
                tail = tail.prev;
                tail.next = null;
                return temp.data;
            }

        }

        public void Push(int num)
        {
            Node temp = new Node(num);
            if (head == null)
            {
                head = temp;
                tail = temp;

            }
            else
            {
                tail.next = temp;
                temp.prev = tail;
                tail = temp;
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
                return tail.data;
            }
        }
    }
}
