using DataStructureIITLecture_4.Dictionary.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_4.Dictionary.Implementation
{
    public class ChainLenierProbing : IChain
    {
        Node[] input;
        int probe;
        public ChainLenierProbing(int size)
        {
            input = new Node[size];
            probe = 1;

        }
        public Node GetValue(string key, int pos)
        {
            int i = pos;
            int size = input.Length;

            if (input[pos].phoneNumber == key)
            {
                return input[pos];
            }

            i++;

            for(int k = i; k % size != pos; k++)
            {
                k = k % size;
                if (input[k].phoneNumber == key)
                    return input[k];
            }

            Console.WriteLine("Node not found");
            return null;
        }

        public bool Insert(Node node, int pos)
        {
            int i = pos;
            int size = input.Length;
            if (input[i] == null)
            {
                input[i] = node;
                return true;
            }

            if(input[i].phoneNumber == node.phoneNumber)
            {
                Console.WriteLine("Phone Number already exists");
                return false;
            }

            i++;

            for(int n = i; n % size != pos; n++)
            {
                n = n % size;
                if (input[n] == null)
                {
                    input[n] = node;
                    return true;
                }
                else if(input[n].phoneNumber == node.phoneNumber)
                {
                    Console.WriteLine("Phone Number already exists");
                    return false;
                }
                else if(input[n].phoneNumber == "X" )
                {
                    input[n] = node;
                    return true;
                }
            }

            return false;
        }

        public Node Remove(string key, int pos)
        {
            int i = pos;
            int size = input.Length;

            if (input[pos].phoneNumber == key)
            {
                Node temp = input[pos];
                input[pos].phoneNumber = "X";
                input[pos].name = "X";
                input[pos].age = 0;
                return temp;
            }

            i++;

            for (int k = i; k % size != pos; k++)
            {
                k = k % size;
                if (input[k].phoneNumber == key)
                {
                    Node temp = input[k];
                    input[k].phoneNumber = "X";
                    input[k].name = "X";
                    input[k].age = 0;
                    return temp;
                }
            }

            Console.WriteLine("Node not found");
            return null;
        }
    }
}
