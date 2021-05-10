using DataStructureIITLecture_2.Stack.Implementation;
using DataStructureIITLecture_2.Stack.Interface;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataStructureIITLecture_2
{
    public static class ArraySpan
    {
        public static int[] CalculateSpan(int[] Input)
        {
            int len = Input.Length;
            int[] Span = new int[len];

            //Span[0] = 0;

            IStack stk = new StackArray(len);
            //stk.Push(0);
            for(int i = 0; i< len; i++)
            {
                if (i == 0)
                {
                    Span[0] = 0;
                    stk.Push(0);
                }
                else
                {
                    if (Input[i] < Input[i - 1])
                    {
                        Span[i] = 1;
                        stk.Push(i);
                    }
                    else
                    {
                        while ( !stk.IsEmpty() && Input[stk.Top()] < Input[i])
                        {
                            stk.Pop();
                        }

                        if (stk.IsEmpty())
                        {
                            Span[i] = 0;
                            stk.Push(i);
                        }
                        else
                        {
                            Span[i] = i - stk.Top();
                            stk.Push(i);
                        }
                    }
                }
            }
            return Span;
        }
    }
}
