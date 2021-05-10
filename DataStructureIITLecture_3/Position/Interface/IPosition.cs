using DataStructureIITLecture_3.Queue.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_3.Position.Interface
{
    public interface IPosition
    {
        public Node GetElementByPosition(Node head, int n);
    }
}
