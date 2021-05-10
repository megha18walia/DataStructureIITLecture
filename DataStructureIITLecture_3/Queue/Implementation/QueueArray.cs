using DataStructureIITLecture_3.Queue.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_3.Queue.Implementation
{
    public class QueueArray : IQueue
    {
        int[] input;
        int front = -1;
        int rear = -1;
        int n = 0;

        public QueueArray(int n)
        {
            input = new int[n];
            this.n = n;
        }
        public int Dequeue()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Nothing to remove");
                return -1;
            }
            else if(front == rear)
            {
                int n2 = input[front];
                front = -1;
                rear = -1;
                return n2;
            }
            else
            {
                int n1 = input[front];
                front = (front + 1) % n; ;
                return n1;
            }
        }

        public void Enqueue(int num)
        {
            if (IsEmpty())
            {
                input[0] = num;
                front = 0;
                rear = 0;
            }
            else 
            {
                if (IsFull())
                    Console.WriteLine("Queue is full");
                else
                {
                    rear = (rear + 1) % n;
                    input[rear] = num;                   
                }
            }
        }

        public bool IsEmpty()
        {
            return front == -1;
        }

        public int Size()
        {
            if (rear > front)
                return rear - front + 1;
            else
                return n - (front - rear - 1);
        }

        public bool IsFull()
        {
            return (front == 0 && rear == n - 1) || (front % n) - (rear % n) == 1;
        }
    }
}
