using DataStructureIITLecture_3.Queue.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_3.Queue.Implementation
{
    public class QueueCircularLinkedList : IQueue
    {
        Node head;
        public QueueCircularLinkedList()
        {
            head = null;
        }
        public int Dequeue()
        {
            int d = -1;

            if (head == null)
                Console.WriteLine("Queue is empty");
            else if(head.next == head)
            {
                d = head.data;
                head = null;
            }
            else
            {
                d = head.data;
                head.data = head.next.data;
                head.next = head.next.next;
            }
            return d;
        }

        public void Enqueue(int num)
        {
            Node n = new Node(num);
            if(head == null)
            {
                head = n;
                head.next = head;
            }
            else
            {
                Node temp = new Node(head.data);
                head.data = num;
                temp.next = head.next;
                head.next = temp;
                head = temp;
            }
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public bool IsFull()
        {
            return false;
        }

        public int Size()
        {
            return -1;
        }
    }
}
