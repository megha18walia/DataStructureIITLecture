using DataStructureIITLecture_4.Dictionary.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_4.Dictionary.Interface
{
    public interface IChain
    {
        bool Insert(Node node, int pos);

        Node GetValue(string key, int pos);

        Node Remove(string key, int pos);

    }
}
