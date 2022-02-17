using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Paranthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the given expression\n");
            string s=Console.ReadLine();
            Paranthesis paranthesis = new Paranthesis();
            if (paranthesis.Check(s))
            {
                Console.WriteLine("It is Balenced\n");
            }
            else
            {
                Console.WriteLine("It is not balenced\n");
            }
        }
    }
}
