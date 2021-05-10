using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_2.Stack.Interface
{
    public interface IStack
    {
        void Push(int num);
        int Pop();
        int Top();

        bool IsEmpty();
    }
}
