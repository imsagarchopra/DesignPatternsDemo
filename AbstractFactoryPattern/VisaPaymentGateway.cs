﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridFactory_StrategyPattern
{
    public class VisaPaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} via Visa.");
        }
    }
}
