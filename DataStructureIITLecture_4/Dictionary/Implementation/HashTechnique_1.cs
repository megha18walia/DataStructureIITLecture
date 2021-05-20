using DataStructureIITLecture_4.Dictionary.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_4.Dictionary.Implementation
{
    public class HashTechnique_1 : IHash
    {
        public HashTechnique_1(int input, ref int module)
        {
            int mod;
            int sqrt = Convert.ToInt32(Math.Sqrt(input));
            int num = 0;

            while (true)
            {
                if (IsPrime(sqrt + num))
                {
                    mod = sqrt + num;
                    break;
                }

                if (IsPrime(sqrt - num))
                {
                    mod = sqrt - num;
                    break;
                }

                num++;
            }

            module = mod;
        }
        public int GetPosition(string key , int mod)
        {
            double sum = 0;
            char[] keyChars = key.ToCharArray();
            for(int i = 1; i<= keyChars.Length; i++)
            {
                sum = sum + i * Convert.ToInt32(keyChars[i-1]);
            }

            return Convert.ToInt32( sum % Convert.ToDouble( mod)) ;
        }

        private bool IsPrime(int n)
        {
            int last = n / 2 + 1;
            if (n == 2)
                return true;

            for (int i = 2; i <= last; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
