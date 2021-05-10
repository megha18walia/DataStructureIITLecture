using DataStructureIITLecture_3.LinkedList.Implementation;
using DataStructureIITLecture_3.LinkedList.Interface;
using DataStructureIITLecture_3.List.Implementation;
using DataStructureIITLecture_3.List.Interface;
using DataStructureIITLecture_3.Position.Implementation;
using DataStructureIITLecture_3.Position.Interface;
using DataStructureIITLecture_3.Queue.Implementation;
using DataStructureIITLecture_3.Queue.Interface;
using DataStructureIITLecture_3.Vector.Implementation;
using DataStructureIITLecture_3.Vector.Interface;
using System;

namespace DataStructureIITLecture_3
{
    class Program
    {
        static IILinkedList list;
        static void Main(string[] args)
        {
            //IQueue queue = new QueueArray(8);
            //DemoQueue(queue);

            //IQueue queueDoubleLL = new QueueDoublyLinkedList();
            //DemoQueue(queueDoubleLL);

            //IQueue queueCircularLL = new QueueDoublyLinkedList();
            //DemoQueue(queueCircularLL);

            //list = new SingleLinkedList();
            //IVector vector = new VectorLinkedList(list.CreateList(new int[] { 10, 9, 8, 7, 5 }));
            //DemoVector(vector);

            //IILinkedList list = new DoublyLinkedList();
            //IVector vector = new VectorLinkedList(list.CreateList(new int[] { 10, 9, 8, 7, 5 }));
            //DemoVector(vector);

            //IILinkedList list = new DoublyLinkedList();
            //IPosition pos = new PostionLL();
            //Node head = list.CreateList(new int[] { 10, 9, 8, 7, 5 });
            //for(int i = 1; i<= 10; i++)
            //{
            //    Console.WriteLine(pos.GetElementByPosition(head, i)?.data.ToString() ?? "Position does not exist");
            //}

            IILinkedList lst = new DoublyLinkedList();
            Node head = lst.CreateList(new int[] { 10, 9, 8, 7, 5 });
            IPosition pos = new PostionLL();
            IList list = new ListLL(head, pos);
            DemoList(list);

            Console.ReadLine();

        }

        static void DemoQueue(IQueue queue)
        {
            queue.Enqueue(17);
            queue.Enqueue(7);
            queue.Enqueue(16);
            queue.Enqueue(15);
            queue.Enqueue(4);
            queue.Enqueue(3);
            queue.Enqueue(500);
            Console.WriteLine("");
            Console.WriteLine(queue.Size());
            queue.Enqueue(9);
            queue.Enqueue(170);

            Console.Write(queue.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");

            queue.Enqueue(30);
            queue.Enqueue(510);
            queue.Enqueue(91);
            queue.Enqueue(171);
            Console.WriteLine("");
            Console.WriteLine(queue.Size());
            queue.Enqueue(93);
            queue.Enqueue(172);
            queue.Enqueue(179);

            Console.Write(queue.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");
            queue.Enqueue(19);
            Console.Write(queue.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");
            queue.Enqueue(19);
            Console.Write(queue.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");


            //Console.ReadLine();
        }

        static void DemoVector(IVector vector)
        {         
            for (int i = 1; i <= 12; i++)
                Console.Write(vector.ElementAtRank(i) + " ");

            vector.InsertAtRank(1, 11);
            vector.InsertAtRank(2, 11);
            vector.InsertAtRank(3, 11);
            vector.InsertAtRank(5, 11);
            vector.InsertAtRank(6, 11);
            vector.InsertAtRank(7, 11);
            vector.InsertAtRank(11, 11);
            vector.InsertAtRank(12, 11);

            for (int i = 1; i <= 20; i++)
                Console.Write(vector.ElementAtRank(i) + " ");

            vector.ReplaceAtRank(1, 12);
            vector.ReplaceAtRank(2, 12);
            vector.ReplaceAtRank(3, 12);
            vector.ReplaceAtRank(5, 12);
            vector.ReplaceAtRank(6, 12);
            vector.ReplaceAtRank(7, 12);
            vector.ReplaceAtRank(11, 12);
            vector.ReplaceAtRank(12, 12);

 

            for (int i = 1; i<= 20; i++)
                Console.Write(vector.ElementAtRank(i) + " ");

            vector.RemoveAtRank(1);
            vector.RemoveAtRank(2);
            vector.RemoveAtRank(3);
            vector.RemoveAtRank(5);
            vector.RemoveAtRank(6);
            vector.RemoveAtRank(7);
            vector.RemoveAtRank(11);
            vector.RemoveAtRank(12);

            for (int i = 1; i <= 20; i++)
                Console.Write(vector.ElementAtRank(i) + " ");
        }

        static void DemoList(IList list)
        {
            

            if(list.IsEmpty())
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                list.Traverse();
            }

            Node n = list.First();
            Console.WriteLine("Firest element is " + n.data);

            n = list.Last();
            Console.WriteLine("Last element is " + n.data);

            n = list.After(2);
            Console.WriteLine("Element after 2 is " + n.data);

            n = list.Before(2);
            Console.WriteLine("Element before 2 is " + n.data);

            list.InsertAfter(3, 77);
            list.Traverse();

            list.InsertBefore(3, 78);
            list.Traverse();

            list.InsertFirst(79);
            list.Traverse();

            list.InsertLast(73);
            list.Traverse();

            if(list.IsFirst(1))
            {
                Console.WriteLine("It is a first element");
            }
            else
            {
                Console.WriteLine("It is not a first element");
            }

            if (list.IsLast(3))
            {
                Console.WriteLine("It is a last element");
            }
            else
            {
                Console.WriteLine("It is not a last element");
            }

            if (list.IsLast(list.Size()))
            {
                Console.WriteLine("It is a last element");
            }
            else
            {
                Console.WriteLine("It is not a last element");
            }

            list.Remove(2);
            list.Traverse();

            list.SwapElements(2, 3);
            list.Traverse();





        }
    }
}
