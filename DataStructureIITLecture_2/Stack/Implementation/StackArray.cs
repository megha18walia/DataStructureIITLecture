using DataStructureIITLecture_2.Stack.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace DataStructureIITLecture_2.Stack.Implementation
{
    public class StackArray : IStack
    {
        int[] Ar;
        int pushval = 0;
        int popval = -1;
        public StackArray(int n)
        {
            Ar = new int[n];
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                int val = Ar[popval];
                popval--;
                pushval--;
                return val;
            }
        }

        public void Push(int num)
        {
            int len = Ar.Length;
            if(pushval > Ar.Length - 1)
            {
                int[] tempArr = Ar;
                Ar = new int[2 * len];

                for (int i = 0; i < tempArr.Length; i++)
                    Ar[i] = tempArr[i];
            }

            Ar[pushval] = num;
            popval = pushval;
            pushval++;

        }

        public int Top()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                return Ar[popval];
            }
        }

        public bool IsEmpty()
        {
            return popval == -1 ? true : false;
        }
    }
}
