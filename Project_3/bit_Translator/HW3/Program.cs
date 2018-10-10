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
        public T Data;
        public Node<T> Next;

        public Node(T data, Node<T> next)
        {
            ///This is the moving the pointer of the node 
            ///to the next node in the data.
            this.Data = data;
            this.Next = next;
        }

         interface IQueueInterface<T> {
            /// <summary>
            /// This is holidng all the elements and then from there it will add
            /// the elements to the query. This will place that element to the end
            /// of the query.
            /// </summary>
            /// <param name="element"></param>
            /// <returns></returns>
            T  Push(T element);

            /// <summary>
            /// This will take the top element from the top of the stack
            /// Then will then return that element.
            /// </summary>
            /// <returns></returns>
            T Pop();

            /// <summary>
            /// This is to check and see if the queue is empty.
            /// This will return false if the queue is populated,
            /// otherwise this will return true. 
            /// </summary>
            /// <returns></returns>
            bool IsEmpty();

        }

        /// <summary>
        /// This is using the idea of running a test to check for 
        /// any operations that were executed/performed to a empty queue. 
        /// </summary>
        public class QueueUnderflowException : Exception
        {
            public QueueUnderflowException()
            {
                
            }
            /// <summary>
            /// This will return a string message that will 
            /// inform a illegal operation that is performed in the program.
            /// </summary>
            /// <param name="message"></param>
            public QueueUnderflowException(string message) : base(message){



            }

        }

        public class LinkedQueue : IQueueInterface<T> {


        }
        static void Main(string[] args)
        {
        }
    }
}
