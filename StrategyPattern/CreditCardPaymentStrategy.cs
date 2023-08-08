using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Concrete Strategy A
    // The following CreditCardPaymentStrategy Class implements the IPaymentStrategy Interface and 
    // Implement the Pay Method. 
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Customer pays Rs {amount} By Credit Card");
        }
    }
}
