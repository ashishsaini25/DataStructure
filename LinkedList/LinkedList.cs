using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public  class LinkedList
    {
        public Node head;
         public Node Addathead(int data)
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
                head= newnode;
                newnode.next = temp;
                return head;
            }

        }
        public Node Addatback(int data)
        {
            Node newnode=new Node(data);
            if(head== null)
            {
                head= newnode;
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

        public Node Deleteathead()
        {
            if(head== null)
            {
                Console.WriteLine("List is already Empty");
                return head;
            }
            else
            {
                head = head.next;
                return head;
            }
        }
        public Node Deleteattail()
        {
            if (head == null)
            {
                Console.WriteLine("List is already empty");
                return head;
            }
            if (head.next == null)
            {
                head = null;
                return head;
            }
            else
            {
                Node temp = head;
             
                
                    while (temp.next.next != null)
                        temp = temp.next;
                    temp.next = null;
                    return head;
            }
        }
        public void DeleteAtParticluarpos(int pos)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty\n");
                return ;
            }
            if (pos == 0)
            {
                head = head.next;
                return;

            }
            Node temp = head;
            for (int i = 0; i < pos - 1&&temp!= null; i++){
                temp = temp.next;
            }
            if (temp == null) return;
            temp.next = temp.next.next;
        }
        public int Search(int data)
        {
            Node temp = head;
            int count = 0;
            while (temp!=null)
            {
                if (temp.data == data) return count;
                temp = temp.next;
                count++;
            }
            return -1;
            
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while(temp != null)
                {
                    Console.Write(temp.data+" ");
                    temp = temp.next;
                }
            }
            Console.WriteLine("");
        }
        public void Size()
        {
            int count = 0;
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (temp != null)
                {
                    temp = temp.next;
                    count++;
                }
            }
            Console.WriteLine("The Size of The list is :{0}", count);

        }

    }
}
