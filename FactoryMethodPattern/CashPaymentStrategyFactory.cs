using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    // CashPaymentStrategyFactory Concrete Creators override the factory MakeProduct method
    // to create and return the CashPaymentStrategy Product
    public class CashPaymentStrategyFactory : PaymentStrategyFactory
    {
        // The signature of the method uses the abstract product IPaymentStrategy type,
        // Even though the concrete CashPaymentStrategy product is returned from the method.
        // This way the Abstract Creator PaymentStrategyFactory can stay independent of concrete product classes.
        protected override IPaymentStrategy MakePaymentStrategy()
        {
            IPaymentStrategy paymentStrategy = new CashPaymentStrategy();
            return paymentStrategy;
        }
    }
}
