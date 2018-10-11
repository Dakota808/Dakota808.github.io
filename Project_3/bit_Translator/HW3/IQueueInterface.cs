using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    interface IQueueInterface<T>
    {
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
}
