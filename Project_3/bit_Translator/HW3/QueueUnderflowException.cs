using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
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
        public QueueUnderflowException(string message) : base(message)
        {



        }

    }
}
