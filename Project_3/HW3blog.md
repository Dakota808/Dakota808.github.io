# Homework #3 <br>

## Learing C#
<p>
    So this assignment we are now getting into visual studio code. This application is more desgined for windows computers. So this was based for understanding of how to translate java code into (C#) C sharp code. The important note about these two coding languages are that they have simialr code functions. To see the differences between is type of calls that are issued for certain things such as Java's super class to the base class from C#. It can be translated in a similar way but one has to realize that the code translation between the two are simple to understand.   
</p>

Here are the links to the this assignment:<br>
[Repsoitory](https://github.com/Dakota808/Dakota808.github.io/tree/master/Project_3/bit_Translator/HW3)<br>
[Main Page](https://dakota808.github.io/)<br>

## Objective
We are to write C# code and be able to translate Java code as well. We were to refactor java code designed to make a binary tree which will take a input and interate through the process until they have met the input value so for example:<br>
```C#
             1
         /       \
        10       11
       /  \     /  \
     100  101 110  111
```
## Java To C#
This section we will be looking into the Java code and breif detail of how they function.<br>
Here's what we are looking into:<br>
```html
<ul>
    Node.java
    QueueInterface.java
    QueueUnderflowException.java
    LinkedQueue.java
    Main.java
</ul>
```
### Installing Visual Studio
<p>So installing the Visual studio code is not that hard however to setup the enviorment is know what you will need add on to work on certain things. For this case we need to run all functions of C# and web services such as MVC and ASPI. These can all be found when you first setup the Visual Studio which will ask you what types of features do you want to run.</p>
Setup is simple here's how:<br>
1.Download [Visual Studio](https://visualstudio.microsoft.com/downloads/)<br>
2.Add any feature you need to run<br>

<p>Once you have that setup you can start using Visual studio and if you need to add more tools go to you Tools tab in visual studios and click on "Get Tools and Features.</p>

### Node.java <br>
<p>
 The Node class from java is simple and easy to understand. But does (T) in the class header mean?Simple it intalizes the node pointer which will hold type.
</p>
<p>
So (T) is a class type which in this case can hold class type objects such as strings, integers, or object types. From this case we use the nodes as pointers to integers.
</p>

This will also introduce the use of "this" which indicate where we are in the list of nodes that we are in. 

### Java:
```Java
/** Singly linked node class. */

public class Node<T>
{
	public T data;
	public Node<T> next;
	
	public Node( T data, Node<T> next )
	{
		this.data = data;
		this.next = next;
	}
}
```
So translating this is simple and in fact they are exactly the same:
### C#
```C#
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
}
```
Note: that in this display the code is in a what they call a namespace. This is the way visual studio is designed, it will hold all of the different class and it's functions inside a name space which C# uses the most and so you can consider the namspace as like a workbench or a folder which holds all of the work progress that you have done. 

### QueueUnderflowExecption

<p>When we look into how to handle exceptions in java is not the same as in C#. In fact one of the key things to note about them is that the excpeitons are handle outside of the class instead if a function just having to direct connection to the exception. So when I built the exception for this part I had no throw exceptions inside the body of the class or in the function. All of them were handle outside of this.</p>

### Java Code
```Java
/**
 * A custom unchecked exception to represent situations where 
 * an illegal operation was performed on an empty queue.
 */
public class QueueUnderflowException extends RuntimeException
{
  public QueueUnderflowException()
  {
    super();
  }

  public QueueUnderflowException(String message)
  {
    super(message);
  }
}

```



### C# Code
```C#
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


```
The only difference between Java and C# is where they handle the Exceptions. Java handles it inside the class for it. While C# handles it from the outside of the class using System which handles Exceptions and many other functions.<br>

### QueueInterface
There is no really significant difference between how java and C# use for functions. But how to declare the interface is different.Instead of running a QueueInterface like Java, C# uses an similar one called IQueueIterface. Honestly there really is not big difference between the two its just how they are defined in there respective language.<br>

### Java Code
```Java
/**
 * A FIFO queue interface.  This ADT is suitable for a singly
 * linked queue.
 */
public interface QueueInterface<T>
{
    /**
     * Add an element to the rear of the queue
     * 
     * @return the element that was enqueued
     */
    T push(T element);

    /**
     * Remove and return the front element.
     * 
     * @throws Thrown if the queue is empty
     */
    T pop() throws QueueUnderflowException;

    /**
     * Test if the queue is empty
     * 
     * @return true if the queue is empty; otherwise false
     */
    boolean isEmpty();
}

```

### C# Code
```C#
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
```
### LinkedQueue
The most important part to this particular part of this assignment is how to handle the null pointer exceptions. Which in C# reference is not the same as java's. 
## Demo


