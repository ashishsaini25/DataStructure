using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateBankingCashCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Simulate banking cash Counter program");
            Queue queue = new Queue();
            CashCounter cashCounter = new CashCounter();
            queue.Enqueue( 1000);
            queue.Enqueue( 5000);
            queue.Enqueue( 10000);
            queue.Enqueue( 100000);
            queue.Enqueue( 5000000);
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter 1 to Withdraw money \n 2 to Deposit ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        cashCounter.Withdraw( ref queue.head);
                       // queue.head.data.Info();
                        queue.Dequeue();
                        break;
                    case 2:
                        cashCounter.Deposit(ref queue.head);
                        //queue.head.data.Info();
                        break;
                }
            }
            Console.WriteLine(cashCounter.cashpresent);
        }
    }
}
