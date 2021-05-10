using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture
{
    public class InsertionSort
    {
        public static int[] Sort(int[] Ar)
        {
            int len = Ar.Length;

            for (int i = 1; i < len; i++)
            {
                int num = Ar[i];
                int pos = i;
                
                for(int j = i -1; j >= 0 && Ar[j] > num ; j--)
                {
                    Ar[j + 1] = Ar[j];
                    pos = j;
                }

                Ar[pos] = num;
            }

            return Ar;
        }

    }
}
