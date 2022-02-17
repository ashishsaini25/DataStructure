using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Paranthesis
{
    public class Node
    {

        public char data;
        public Node next;
        public Node(char data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
