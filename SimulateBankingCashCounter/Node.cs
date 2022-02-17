using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateBankingCashCounter
{
    public  class Node
    {
        public int amount;
        public Node next;
        public Node(int amount)
        {
            this.amount = amount;
        }
       
    }
}
