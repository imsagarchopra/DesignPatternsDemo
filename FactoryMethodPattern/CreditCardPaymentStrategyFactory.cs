using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    // CreditCardPaymentStrategyFactory Concrete Creators override the factory MakeProduct method
    // to create and return the CreditCardPaymentStrategy Product
    public class CreditCardPaymentStrategyFactory : PaymentStrategyFactory
    {
        // The signature of the method uses the abstract product IPaymentStrategy type,
        // Even though the concrete CreditCardPaymentStrategy product is returned from the method.
        // This way the Abstract Creator PaymentStrategyFactory can stay independent of concrete product classes.
        protected override IPaymentStrategy MakeProduct()
        {
            IPaymentStrategy paymentStrategy = new CreditCardPaymentStrategy();
            return paymentStrategy;
        }
    }
}
