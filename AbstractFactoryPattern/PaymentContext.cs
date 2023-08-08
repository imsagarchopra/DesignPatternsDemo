using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // The Context Provides the interface which is going to be used by the Client.
    public class PaymentContext
    {
        // The Context has a reference to the Strategy object.
        // The Context does not know the concrete class of a strategy. 
        // It should work with all strategies via the Strategy interface.
        private IPaymentStrategy _paymentStrategy;
        private IPaymentGateway _paymentGateway;

        // The Client will set what PaymentStrategy to use by calling this method at runtime
        public PaymentContext(IPaymentStrategy strategy, IPaymentGateway paymentGateway)
        {
            _paymentStrategy = strategy;
            _paymentGateway = paymentGateway;
        }

        public void ProcessPayment(double amount)
        {
            _paymentGateway.ProcessPayment(amount);
        }

        // The Context delegates the work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void Pay(double amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}
