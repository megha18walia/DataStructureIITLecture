using DataStructureIITLecture_4.Dictionary.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_4.Dictionary.Implementation
{
    public class DictionaryLL : IDictionary
    {
        int mod = 0;
        Node[] DictionaryArr;
        IHash hastValue;
        IChain chain;
        public DictionaryLL(int input)
        {           
            hastValue = new HashTechnique_1(input, ref mod);
            DictionaryArr = new Node[mod + 1];
            this.chain = new ChainingLL(DictionaryArr);
        }

        public bool Insert(Node node)
        {
            int pos = hastValue.GetPosition(node.phoneNumber, mod);
            return chain.Insert(node, pos);
        }
        public Node GetValue(string key)
        {
            int pos = hastValue.GetPosition(key, mod);
            return chain.GetValue(key, pos);
        }

        public Node Remove(string key)
        {
            int pos = hastValue.GetPosition(key, mod);
            return chain.Remove(key, pos);
        }
    }
}
