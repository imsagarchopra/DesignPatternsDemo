using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Concrete Strategy B
    // The following DebitCardPaymentStrategy class implements the IPaymentStrategy Interface and 
    // Implement the Pay Method. 
    public class DebitCardPaymentStrategy : IPaymentStrategy
    {       
        public void Pay(double amount)
        {
            Console.WriteLine($"Customer pays Rs{amount} By Debit Card");
        }
    }
}
