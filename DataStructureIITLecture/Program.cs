using System;

namespace DataStructureIITLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[] { 10, 9, 15, 7, 18, 20 ,5, 2, 2, 17 };
            Console.WriteLine("Input Array");
            for (int i = 0; i < Array.Length; i++)
                Console.Write(Array[i] + " ");
            Console.WriteLine("");

            var ArrayRes = InsertionSort.Sort(Array);

            Console.WriteLine("Output Array");
            for (int i = 0; i < ArrayRes.Length; i++)
                Console.Write(ArrayRes[i] + " ");
            Console.WriteLine("");

            Console.ReadLine();


        }
    }
}
