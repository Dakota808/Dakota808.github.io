using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW3
{


    

        


        

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
                    Console.Write(" ");
                }
                Console.WriteLine(s);
            }
        }

    }


       

}
