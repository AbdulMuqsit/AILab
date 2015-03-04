using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab.Model
{
    class Node<T>
    {
        public Node<T> Predecessor { get; set; }
        public Node<T> Successor { get; set; }
        public T Data { get; set; }
        public Node()
        {
            Predecessor = this;
            Successor = this;

        }
        public Node(Node<T> predecessor, Node<T> successor)
        {
            Predecessor = predecessor;
            Successor = successor;
        }
        public Node(T data, Node<T> predecessor, Node<T> successor)
        {
            Data = data;
            Predecessor = predecessor;
            Successor = successor;
        }



    }
}
