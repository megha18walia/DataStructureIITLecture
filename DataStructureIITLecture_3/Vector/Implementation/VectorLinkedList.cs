using DataStructureIITLecture_3.LinkedList.Interface;
using DataStructureIITLecture_3.Queue.Implementation;
using DataStructureIITLecture_3.Vector.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_3.Vector.Implementation
{
    public class VectorLinkedList : IVector
    {
        Node head;
        public VectorLinkedList(Node head)
        {
            this.head = head;
        }
        public int ElementAtRank(int rank)
        {
            Node temp = head;
            int tempRank = 0;
            int d = -1;

            if (temp == null)
                Console.WriteLine("Rank does not exist");

            for (tempRank = 1; tempRank < rank && temp.next != null; tempRank++)
            {
                temp = temp.next;
            }

            if (temp.next == null && tempRank == rank)
                d = temp.data;
            else if (temp.next == null && tempRank < rank)
                Console.WriteLine("Rank not found");
            else
                d = temp.data;

            return d;
        }

        public void InsertAtRank(int rank, int num)
        {
            int tempRank = 0;
            Node temp = head;
            Node n = new Node(num);

            if (rank == 1)
            {
                if (head != null)
                    n.next = head;

                head = n;
                return;
            }

            for (tempRank = 2; tempRank < rank && temp.next != null; tempRank++)
            {
                temp = temp.next;
            }

            if(temp.next == null && tempRank == rank)
            {
                temp.next = n;
            }
            else if(temp.next == null && tempRank < rank)
            {
                Console.WriteLine("Cannot Insert at tis rank");
            }
            else
            {
                n.next = temp.next;
                temp.next = n;
            }                   
        }

        public int RemoveAtRank(int rank)
        {
            int d = -1;
            Node temp = head;
            int tempRank = 0;

            if (temp == null)
                Console.WriteLine("Vector is Empty");

            if(rank == 1)
            {
                d = head.data;
                head = head.next;
                return d;
            }

            for(tempRank = 2; tempRank < rank && temp.next != null; tempRank++)
            {
                temp = temp.next;
            }

            if (temp.next == null )
                Console.WriteLine("Element not found");
            else
            {
                d = temp.next.data;
                temp.next = temp.next.next;
            }

            return d;

        }

        public void ReplaceAtRank(int rank, int num)
        {
            Node temp = head;
            int tempRank = 0;

            for(tempRank = 1; tempRank < rank && temp.next != null; tempRank++)
            {
                temp = temp.next;
            }

            if(temp.next == null && tempRank < rank )
            {
                Console.WriteLine("Rank not found");
            }
            else
            {
                temp.data = num;
            }
        }
    }
}
