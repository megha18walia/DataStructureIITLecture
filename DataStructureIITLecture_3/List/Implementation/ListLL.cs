using DataStructureIITLecture_3.Position.Interface;
using DataStructureIITLecture_3.Queue.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_3.List.Implementation
{
    public class ListLL : Interface.IList
    {
        Node head;
        IPosition position;
        Node tail;
        public ListLL(Node head, IPosition pos)
        {
            this.head = head;
            this.position = pos;
            Node temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }

            tail = temp;
        }

        public void Traverse()
        {
            Node temp = head;
            for (temp = head; temp.next != null; temp = temp.next)
                Console.Write(temp.data + "-->");

            Console.Write(temp.data);
            Console.WriteLine("");
        }
        public Node After(int p)
        {
            Node temp = position.GetElementByPosition(head, p);
            return temp?.next ?? null;
        }

        public Node Before(int p)
        {
            Node temp = position.GetElementByPosition(head, p);
            return temp?.prev ?? null;
        }

        public Node First()
        {
            Node temp = position.GetElementByPosition(head, 1);
            return temp ?? null;
        }

        public void InsertAfter(int p, int num)
        {
            Node temp = position.GetElementByPosition(head, p);
            Node n = new Node(num);

            if (temp == null)
            {
                Console.WriteLine("Position not found hence element cannot be inserted");
            }
            else if(temp == tail)
            {
                temp.next = n;
                n.prev = tail;
                tail = temp;
            }
            else
            {
                n.prev = temp;
                n.next = temp.next;
                temp.next = n;             
            }           
        }

        public void InsertBefore(int p, int num)
        {
            Node temp = position.GetElementByPosition(head, p);
            Node n = new Node(num);

            if (temp == null)
            {
                Console.WriteLine("Position not found hence element cannot be inserted");
            }
            else if (temp == head)
            {
                head.prev = n;
                n.next = head;
                head = n;
            }
            else
            {
                n.prev = temp.prev;
                n.next = temp;
                temp.prev.next = n;
                temp.prev = n;

            }
        }

        public void InsertFirst(int num)
        {
            Node n = new Node(num);
            head.prev = n;
            n.next = head;
            head = n;
        }

        public void InsertLast(int num)
        {
            Node n = new Node(num);
            tail.next = n;
            n.prev = tail;
            tail = n;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public bool IsFirst(int p)
        {
            Node n = position.GetElementByPosition(head, p);
            return n.prev == null;

        }

        public bool IsLast(int p)
        {
            Node n = position.GetElementByPosition(head, p);
            return n.next == null;
        }

        public Node Last()
        {
            return tail;
        }

        public int Remove(int p)
        {
            Node n = position.GetElementByPosition(head, p);
            int data = n.data;

            if (n == head)
            {
                head = head.next;
                head.prev = null;
            }
            else if (n == tail)
            {
                tail = n.prev;
                tail.next = null;
            }
            else
            {
                n.prev.next = n.next;
                n.next.prev = n.prev;
            }

            return data;

        }

        public int Size()
        {
            int size = 0;
            Node temp = head;

            for(temp = head; temp!= null; temp = temp.next)
            {
                size++;
            }

            return size;
        }

        public void SwapElements(int p, int q)
        {
            Node first = position.GetElementByPosition(head, p);
            Node second = position.GetElementByPosition(head, q);

            int temp = first.data;
            first.data = second.data;
            second.data = temp;
        }
    }
}
