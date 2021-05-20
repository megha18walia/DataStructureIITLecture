using DataStructureIITLecture_4.Dictionary.Implementation;
using DataStructureIITLecture_4.Dictionary.Interface;
using System;
using System.Collections.Generic;

namespace DataStructureIITLecture_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary dictLL = new DictionaryLL(1000);
            TestDictionary(dictLL);

            IDictionary dictLP = new DictionaryLP(50);
            TestDictionary(dictLP);


            Console.ReadLine();
        }

        static void TestDictionary(IDictionary dic)
        {
            DictionaryData dict = new DictionaryData(dic);

            for (int index = 1; index <= 50; index++)
            {
                dict.InsertData();
            }

            Console.WriteLine("**************Get Value Called**************");
            dict.GetData();

            Console.WriteLine("**************Remove Data Called**************");
            dict.RemoveData();

            Console.WriteLine("**************Get Value Called**************");
            dict.GetData();
            dict.InsertData();
            dict.InsertData();

            Console.WriteLine("**************Get Value Called**************");
            dict.GetData();
        }
    }
}
