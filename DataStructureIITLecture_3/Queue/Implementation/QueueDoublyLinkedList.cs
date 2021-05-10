using DataStructureIITLecture_3.Queue.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_3.Queue.Implementation
{
    public class QueueDoublyLinkedList : IQueue
    {
        Node front;
        Node rear;

        public QueueDoublyLinkedList()
        {
            front = null;
            rear = null;
        }

        public int Dequeue()
        {
            int data = -1;
            if(front == null)
            {
                Console.WriteLine("Queue is empty");
            }    
            else if(front == rear)
            {
                data = front.data;
                front = null;
                rear = null;
            }
            else
            {
                data = front.data;
                front = front.next;
            }
            return data;
        }

        public void Enqueue(int num)
        {
            Node n = new Node(num);
            if(front == null)
            {
                front = n;
                rear = n;
            }
            else if(front == rear)
            {
                rear.next = n;
                n.prev = rear;
                rear = n;
                front.next = rear;

            }
            else
            {
                rear.next = n;
                n.prev = rear;
                rear = n;
            }
        }

        public bool IsEmpty()
        {
            if (front == null)
                return true;
            else
                return false;
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
