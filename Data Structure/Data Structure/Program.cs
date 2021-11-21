using System;

namespace Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Queues qu = new Queues();
            qu.Enqueu(70);
            qu.Enqueu(30);
            qu.Enqueu(56);
            qu.Dequeu();
            qu.Display();
        }
    }
}
