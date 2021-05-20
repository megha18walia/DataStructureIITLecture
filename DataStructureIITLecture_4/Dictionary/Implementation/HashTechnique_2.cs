using DataStructureIITLecture_4.Dictionary.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_4.Dictionary.Implementation
{
    class HashTechnique_2 : IHash
    {
        const double A = 0.61;
        int n = 1;
        public int GetPosition(string key, int size)
        {
            double sum = 0;
            char[] keyChars = key.ToCharArray();
            for (int i = 1; i <= keyChars.Length; i++)
            {
                sum = sum + i * Convert.ToInt32(keyChars[i - 1]);
            }

            int result = Convert.ToInt32(Math.Floor(size * ((sum * A) % n)));
            return result;


        }
    }
}
