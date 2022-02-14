using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public  class Stack
    {
        public Node head;
        public Node Push(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                return head;
            }
            else
            {
                Node temp = head;
                head = newnode;
                newnode.next = temp;
                return head;
            }

        }

        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data + "->");
                    temp = temp.next;
                }
            }
            Console.WriteLine("null");
        }

    }
}
