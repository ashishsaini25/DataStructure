using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateBankingCashCounter
{
    public  class CashCounter
    {
        public int cashpresent = 100000;
        public void Withdraw(ref Node user)
        {
            Console.WriteLine("Enter the amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount > user.amount)
            {
                Console.WriteLine("Cannot withdraw money because user does not have that much amount");
                return;
            }
            if (amount > cashpresent)
            {
                Console.WriteLine("Does not that much amount So unable to process this request");
            }
            user.amount -= amount;
            cashpresent -= amount;
        }
        public void Deposit(ref Node user)
        {
            Console.WriteLine("Enter the amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            user.amount += amount;
            cashpresent += amount;
        }

    }
}
