using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StrategyPattern.Program;

namespace FactoryPattern
{
    public class PaymentStrategyFactory
    {
        private readonly Dictionary<PaymentType, IPaymentStrategy> _strategies;

        public PaymentStrategyFactory()
        {
            _strategies = new Dictionary<PaymentType, IPaymentStrategy>
            {
                { PaymentType.CreditCard, new CreditCardPaymentStrategy() },
                { PaymentType.DebitCard, new DebitCardPaymentStrategy() },
                { PaymentType.Cash, new CashPaymentStrategy() }
            };
        }

        public IPaymentStrategy GetPaymentStrategy(PaymentType paymentType)
        {
            if (_strategies.TryGetValue(paymentType, out IPaymentStrategy strategy))
            {
                return strategy;
            }

            throw new ArgumentException("Invalid payment type.");
        }
    }
}
