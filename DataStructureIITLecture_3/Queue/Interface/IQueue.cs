using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_3.Queue.Interface
{
    public interface IQueue
    {
        void Enqueue(int num);

        int Dequeue();

        int Size();

        bool IsEmpty();

        bool IsFull();

    }
}
