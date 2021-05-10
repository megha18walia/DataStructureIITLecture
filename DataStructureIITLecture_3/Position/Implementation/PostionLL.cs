using DataStructureIITLecture_3.Position.Interface;
using DataStructureIITLecture_3.Queue.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureIITLecture_3.Position.Implementation
{
    public class PostionLL : IPosition
    {
        public Node GetElementByPosition(Node head , int n)
        {
            Node temp = head;
            int tempRank = 0;
            if(temp == null)
            {
                Console.WriteLine("List os empty");
                return null;
            }
            for(tempRank = 1; tempRank < n && temp.next != null; tempRank++)
            {
                temp = temp.next;
            }

            if (tempRank == n)
                return temp;
            else
                return null;




        }
    }
}
