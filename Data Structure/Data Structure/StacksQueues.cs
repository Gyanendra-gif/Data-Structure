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
        internal void Peek() // Peek From The Data
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Data at top is: " + top.data);
            }
        }
        internal void Pop() // Pop From The Data
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Data is at popped out " + top.data);
                top = top.next;
            }
        }
        internal void Isempty()
        {
            while (top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
