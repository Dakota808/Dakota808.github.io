using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Node<T>
    {
        /// <summary>
        /// This is in initalizing the the files data points in the nodes
        /// </summary>
        public T data;
        public Node<T> next;

        public Node(T data, Node<T> next)
        {
            ///This is the moving the pointer of the node 
            ///to the next node in the data.
            this.data = data;
            this.next = next;
        }

        interface LinkedQueue<T> {

        }
        static void Main(string[] args)
        {
        }
    }
}
