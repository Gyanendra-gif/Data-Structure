using System;

namespace Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList ln = new LinkedList(); 
            ln.Add(56);
            ln.Add(30);
            ln.Add(70);
            int search = ln.Search(30);
            Console.WriteLine(search);
            ln.DeleteNodeAtParticularPosition(search);
        }
    }
}
