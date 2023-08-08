﻿using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridFactory_StrategyPattern
{
    public class CreditCardPaymentStrategyFactory : PaymentStrategyFactory
    {
        protected override IPaymentStrategy MakePaymentStrategy(IPaymentGateway gateway)
        {
            return new CreditCardPaymentStrategy(gateway);
        }
    }
}
