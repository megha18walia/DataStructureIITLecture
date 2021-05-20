using DataStructureIITLecture_4.Dictionary.Implementation;
using DataStructureIITLecture_4.Dictionary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructureIITLecture_4
{
    public class DictionaryData
    {
        IDictionary dict;
        List<string> phoneNums;
        string phoneNum;
        string name;
        int age;

        public DictionaryData(IDictionary dic)
        {
            dict = dic;
            phoneNums = new List<string>();
        }

        public void InsertData()
        {
            int len = phoneNums.Count + 1;

            phoneNum = GeneratePhoneNumber();
            name = "name "+ len;
            age = 10 + len;

            Node n = new Node(phoneNum, name, age);
            if (dict.Insert(n))
            {
                phoneNums.Add(phoneNum);
            }
        }

        public void GetData()
        {
            int len = phoneNums.Count;

            for (int i = 0; i < len; i++)
            {
                Node n = dict.GetValue(phoneNums[i]);
                if (n != null)
                {
                    Console.WriteLine($"Record Number : {i + 1}");
                    Console.WriteLine($"{n.phoneNumber} : {n.name} : {n.age}");
                }
                else
                {
                    Console.WriteLine("Phone Number not found");
                }
            }
        }

        public void RemoveData()
        {
            for(int i = 10; i< 15; i++)
            {
                string key = phoneNums[i];
                Node n = dict.Remove(key);

                if (n != null)
                {
                    Console.WriteLine($"Record Number : {i + 1}");
                    Console.WriteLine($"{n.phoneNumber} : {n.name} : {n.age}");
                }
                else
                {
                    Console.WriteLine("Phone Number not found");
                }

            }
        }

        private string GeneratePhoneNumber()
        {
            Random r = new Random();
            string phoneNum = "9";
            for (int j = 0; j < 9; j++)
            {
                phoneNum = phoneNum + Convert.ToString(r.Next(9));
            }

            return phoneNum;
        }


    }
}
