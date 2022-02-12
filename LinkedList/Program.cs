using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist=new LinkedList();
            linkedlist.Addathead(10);
            linkedlist.Addathead(20);
           linkedlist.Addatback(30);
            int pos = linkedlist.Search(20);
            if (pos == -1)
            {
                Console.WriteLine("Element is not present in the list");
            }
            else
            {
                Console.WriteLine(pos);
            }
            linkedlist.DeleteAtParticluarpos(pos);
            linkedlist.Display();
            linkedlist.Size();
        }
    }
}
