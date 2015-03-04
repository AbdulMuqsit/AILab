using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab.Model
{
    class CustomQueue<T> : ObservableCollection<Node<T>>
    {


        public void Enqueue(Node<T> node)
        {
            this.Add(node);

        }

        public Node<T> Dequeue()
        {
            var topNode = this[0];
            this.RemoveAt(0);
            return topNode;
        }

        public Node<T> Peek()
        {
            return this[0];
        }

    }
}
