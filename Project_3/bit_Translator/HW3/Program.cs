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
    }

    interface IQueueInterface<T> {
            /// <summary>
            /// This is holidng all the elements and then from there it will add
            /// the elements to the query. This will place that element to the end
            /// of the query.
            /// </summary>
            /// <param name="element"></param>
            /// <returns></returns>
            T Push(T element);

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
            public QueueUnderflowException(string message) : base(message) {



            }

        }


        /// <summary>
        /// 
        /// </summary>
        public class LinkedQueue<T> : IQueueInterface<T>
        {
            private Node<T> front;
            private Node<T> rear;

            public LinkedQueue()
            {
                front = null;
                rear = null;
            }
            /// <summary>
            /// This is where if a element type returning a null value it will throw a exception 
            /// which is similar to NullPointerException from java,
            /// This considered the NullReferenceException.
            /// </summary>
            /// <param name="element"></param>
            /// <returns></returns>
            public T Push(T element)
            {
                if (element == null)
                {
                    throw new NullReferenceException();
                }

                if (IsEmpty())
                {
                    Node<T> temp = new Node<T>(element, null);
                    rear = front = temp;

                }
                else
                {
                    Node<T> temp = new Node<T>(element, null);
                    rear.Next = temp;
                    rear = temp;
                }

                return element;
            }

            /// <summary>
            /// This is desgined to pull out the elements from the queue and removes it.
            /// </summary>
            /// <param name="element"></param>
            /// <returns></returns>
            public T Pop()
            {
                T temp = default(T);

                if (IsEmpty())
                {
                    throw new QueueUnderflowException("The Queue is empty when pop is invoked ");
                }
                else if (front == rear)
                {
                    /// This is when one item is in the Queue
                    temp = front.Data;
                    front = null;
                    rear = null;
                }
                else
                {
                    /// This is all of the general cases
                    temp = front.Data;
                    front = front.Next;

                }
                return temp;
            }


            public bool IsEmpty()
            {
                if (front == null && rear == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }



        }

     /// <summary>
     /// This will print the binary repesentation of all numbers from 1 up to n
     /// By doing this it will design a virtual binary tree that will perform
     /// a level order traversal using the FIFO queue. 
     /// Result should be like this:
     ///        1
     ///    /       \
     ///   10       11
     ///  /  \     /  \
     ///100  101 110  111
     ///
     /// etc.
     /// which will store each value that was visited in the list.
     /// </summary>
        public class MainRun
        {
            static LinkedList<string> generateBinaryRepList(int n)
            {
                ///Creates an empty queue of strings
                LinkedQueue<StringBuilder> x = new LinkedQueue<StringBuilder>();
                ///The list is returning the binary values
                LinkedList<string> output = new LinkedList<string>();

                if (n < 1)
                {
                    /// binary values and representation do not support negative values
                    /// return an empty list
                    return output;
                }

                ///This will add the first binary number. This uses a dynamic string
                ///to avoid string concat.
                x.Push(new StringBuilder("1"));

                ///BFS
                while(n > 0)
                {
                    ///print the first part of the queue
                    StringBuilder sb = x.Pop();
                    output.AddLast(sb.ToString());

                    ///Make a copy
                    StringBuilder sbc = new StringBuilder(sb.ToString());

                    ///Left Child
                    sb.Append("0");
                    x.Push(sb);
                    ///Right Child
                    sbc.Append("1");
                    x.Push(sbc);
                    n--;

                }
            return output;

            }
        /// <summary>
        /// This will be the driver and is testing the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n = 10;
            if (args.Length < 1)
            {
                Console.WriteLine("Please invoke with the max value to print binary up to, like this:");
                Console.WriteLine("\t Main 12");
                return;
            }
            try
            {
                n = Int32.Parse(args[0]);
            }
            catch (FormatException e)
            {
                Console.WriteLine("I'm sorry, I can not understand the input: " + args[0]);
            }

            LinkedList<string> output = generateBinaryRepList(n);

            int maxLength = output.Count();
            foreach (string s in output)
            {
                for (int i = 0; i < maxLength - s.Length; i++)
                {
                    Console.WriteLine(" ");
                }
                Console.WriteLine(s);
            }
        }

    }


       

}
