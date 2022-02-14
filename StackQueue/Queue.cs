using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class Queue
    {
        public Node head;
        public Node Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                return head;
            }
            else
            {
                Node Temp = head;
                while (Temp.next != null)
                {
                    Temp = Temp.next;
                }
                Temp.next = newnode;
                return head;
            }
        }

        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
            Console.WriteLine("");
        }
    }
}
