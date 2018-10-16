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
1.Download [Visual Studio](https://visualstudio.microsoft.com/downloads/)
<p></p>
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



##Demo


