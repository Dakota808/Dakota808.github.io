using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
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
}
