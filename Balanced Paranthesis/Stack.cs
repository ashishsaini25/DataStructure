using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Paranthesis
{
        public class Stack
        {
            public Node head;
            public Node Push(char data)
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
            public Node Pop()
            {
                if (head == null)
                {
                  
                    return head;
                }
                else
                {
                    head = head.next;
                    return head ;
                }
            }
        public char Top()
        {
            if(head == null)
            {
                return '0';
            }
            else
            {
                return head.data;
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

