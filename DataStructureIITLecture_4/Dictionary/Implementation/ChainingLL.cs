using DataStructureIITLecture_4.Dictionary.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_4.Dictionary.Implementation
{
    public class ChainingLL : IChain
    {
        Node[] nodeArr;
        Node head;

        public ChainingLL(Node[] Input)
        {
            this.nodeArr = Input;
        }
        public Node GetValue(string key, int pos)
        {
            Node temp;

            for(temp = nodeArr[pos]; temp != null; temp = temp.next)
            {
                if (key == temp.phoneNumber)
                    return temp;
            }

            return null;
        }

        public bool Insert(Node node, int pos)
        {
            if(nodeArr[pos] == null)
            {
                nodeArr[pos] = node;
            }
            else
            {
                Node temp = nodeArr[pos];
                for(temp = nodeArr[pos]; temp.next != null; temp = temp.next)
                {
                    if (temp.phoneNumber == node.phoneNumber)
                    {
                        Console.WriteLine($"Phone number {temp.phoneNumber} already exist");
                        return false;
                    }
                }

                temp.next = node;
            }

            return true;
        }

        public Node Remove(string key, int pos)
        {
            if (nodeArr[pos] == null)
            {
                Console.WriteLine("Item Not found");
            }
            else
            {
                Node temp = nodeArr[pos];
                if(temp.phoneNumber == key)
                {
                    Node n = temp;
                    nodeArr[pos] = temp.next;
                    return n;

                }

                for (temp = nodeArr[pos]; temp.next != null || temp.next.phoneNumber == key; temp = temp.next)
                {
                    if (temp.next.phoneNumber == key)
                    {
                        Node n = temp.next;
                        temp.next = temp.next.next;
                        return n;
                    }
                }
            }

            return null;
        }
    }
}
