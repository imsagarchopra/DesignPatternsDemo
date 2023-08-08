using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class DebitCardPaymentStrategyFactory : PaymentStrategyFactory
    {
        protected override IPaymentStrategy MakePaymentStrategy(IPaymentGateway gateway)
        {
            return new DebitCardPaymentStrategy(gateway);
        }
    }
}
