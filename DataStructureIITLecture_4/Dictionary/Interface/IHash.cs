using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_4.Dictionary.Interface
{
    public interface IHash
    {
        int GetPosition(string key, int mod);
    }
}
