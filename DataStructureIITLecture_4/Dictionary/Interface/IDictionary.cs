using DataStructureIITLecture_4.Dictionary.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_4.Dictionary.Interface
{
    public interface IDictionary
    {
        bool Insert(Node node);

        Node GetValue(string key);

        Node Remove(string key);
    }
}
