using DataStructureIITLecture_2.Stack.Implementation;
using DataStructureIITLecture_2.Stack.Interface;
using System;

namespace DataStructureIITLecture_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array based stack");
            IStack stk = new StackArray(4);
            DemoStack(stk);

            Console.WriteLine("Double Linked List based stack");
            stk = new StackDoublyLinkedList();
            DemoStack(stk);

            Console.WriteLine("Circular Linked List based stack");
            stk = new StackCircularLinkedList();
            DemoStack(stk);

            int[] Input = { 10, 9, 8, 4, 13, 7, 12, 4, 6, 2 };
            for (int i = 0; i < Input.Length; i++)
            {
                Console.Write(Input[i] + " ");
            }
            Console.WriteLine("");

            int[] Span = ArraySpan.CalculateSpan(Input);

           
            for (int i = 0; i < Span.Length; i++)
            {
                Console.Write(Span[i] + " ");
            }

            Console.ReadLine();




        }

        static void DemoStack(IStack stk)
        {
            stk.Push(10);
            stk.Push(9);
            stk.Push(7);
            stk.Push(6);
            stk.Push(4);
            stk.Push(2);

            Console.Write(stk.Pop() + " ");
            Console.Write(stk.Pop() + " ");
            Console.Write(stk.Pop() + " ");
            Console.WriteLine("");

            stk.Push(16);
            stk.Push(14);
            stk.Push(12);

            Console.Write(stk.Pop() + " ");
            Console.Write(stk.Pop() + " ");
            Console.Write(stk.Pop() + " ");
            Console.WriteLine("");

            Console.WriteLine(stk.Top());
            stk.Push(26);
            Console.Write(stk.Pop() + " ");
            Console.Write(stk.Pop() + " ");
            Console.Write(stk.Pop() + " ");
            stk.Push(266);
            Console.Write(stk.Pop() + " ");
            Console.Write(stk.Pop() + " ");
            Console.Write(stk.Pop() + " ");
            Console.Write(stk.Pop() + " ");
            Console.Write(stk.Pop() + " ");
            Console.Write(stk.Pop() + " ");
            Console.WriteLine("");
        }

    }
}
