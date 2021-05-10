using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_3.Vector.Interface
{
    public interface IVector
    {
        void InsertAtRank(int rank, int num);
        int RemoveAtRank(int rank);
        void ReplaceAtRank(int rank, int num);

        int ElementAtRank(int rank);

    }
}
