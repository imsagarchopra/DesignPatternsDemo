using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Concrete Strategy C
    // The following CashPaymentStrategy class implement the IPaymentStrategy Interface and 
    // Implement the Pay Method. 
    public class CashPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Customer pays Rs{amount} By Cash");
        }
    }
}
