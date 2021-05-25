using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Interface
{
    public interface ITraverse
    {
        void InOrder(Node root);

        void PreOrder(Node root);

        void PostOrder(Node root);
        void PrintExpression(Node root);

    }
}
