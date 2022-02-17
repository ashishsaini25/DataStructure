using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateBankingCashCounter
{
    public class Queue
    {

            public Node head;
            public Node Enqueue(int amount)
            {
            Node newnode = new Node(amount);
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
            public Node Dequeue()
            {
                if (head == null)
                {
                    
                    return head;
                }
                else
                {
                    
                    head = head.next;
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
                        Console.Write(temp.amount + " ");
                        temp = temp.next;
                    }
                }
                Console.WriteLine("");
            }
        }
    }

