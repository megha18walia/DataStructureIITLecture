using DataStructureIITLecture_3.LinkedList.Interface;
using DataStructureIITLecture_3.Queue.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_3.LinkedList.Implementation
{
    public class SingleLinkedList : IILinkedList
    {
        Node head;
        public Node CreateList(int[] input)
        {
            Node temp = head;
            for (int i = 0; i < input.Length; i++)
            {
                Node n = new Node(input[i]);
                if (head == null)
                {
                    head = n;
                    temp = head;
                }
                else
                {
                    temp.next = n;
                    temp = temp.next;
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
