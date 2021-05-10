using DataStructureIITLecture_3.LinkedList.Interface;
using DataStructureIITLecture_3.Queue.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_3.LinkedList.Implementation
{
    public class DoublyLinkedList : IILinkedList
    {
        Node head;
        Node tail;
        public Node CreateList(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Node n = new Node(input[i]);
                if (head == null)
                {
                    head = n;
                    tail = n;
                }
                else
                {
                    tail.next = n;
                    n.prev = tail;
                    tail = tail.next;
                }
            }

            return head;
        }

        public void Traverse()
        {
            Node temp = head;
            for (temp = head; temp.next != null; temp = temp.next)
                Console.Write(temp.data + "-->");

            Console.Write(temp.data);
            Console.WriteLine("");
        }
    }
}
