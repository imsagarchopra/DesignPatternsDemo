using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridFactory_StrategyPattern
{
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        private IPaymentGateway _gateway;

        public CreditCardPaymentStrategy(IPaymentGateway gateway)
        {
            _gateway = gateway;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Customer pays Rs {amount} By Credit Card");
        }
    }
}
