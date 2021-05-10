using DataStructureIITLecture_3.Queue.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_3.List.Interface
{
    public interface IList
    {
        int Size();
        bool IsEmpty();
        bool IsFirst(int p);
        bool IsLast(int p);
        Node First();
        Node Last();
        Node Before(int p);
        Node After(int p);
        void SwapElements(int p, int q);
        void InsertFirst(int num);
        void InsertLast(int num);
        void InsertBefore(int p, int num);
        void InsertAfter(int p, int num);
        int Remove(int p);
        void Traverse();

    }
}
