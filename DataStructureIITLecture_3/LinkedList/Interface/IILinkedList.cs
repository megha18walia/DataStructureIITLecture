using DataStructureIITLecture_3.Queue.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_3.LinkedList.Interface
{
    public interface IILinkedList
    {
        Node CreateList(int[] input);

        void Traverse();
    }
}
