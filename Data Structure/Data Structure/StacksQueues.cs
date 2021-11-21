using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class StacksQueues
    {
        internal Node top;
        internal StacksQueues()
        {
            this.top = null;
        }
        internal void Add(int data) // This Method Will Add Int Data into Stack
        {
            Node node = new Node(data);
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.next = top;
                top = node;
            }
            Console.WriteLine("{0} Inserted into Stack", node.data);
        }
        internal void Display() //This Method Showing the Data in the Stack
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node temp = top;
                Console.Write("Elements in Stack is: ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine(" ");
            }
        }
    }
}
