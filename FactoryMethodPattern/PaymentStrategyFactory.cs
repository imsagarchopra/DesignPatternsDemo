﻿using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class PaymentStrategyFactory
    {
        protected abstract IPaymentStrategy MakePaymentStrategy();
        // Also note that The Creator's primary responsibility is not creating products. 
        // Usually, it contains some core business logic that relies on Product objects, returned by the factory method. 
        public IPaymentStrategy CreatePaymentStrategy()
        {
            //Call the MakeProduct which will create and return the appropriate object 
            IPaymentStrategy paymentStrategy = this.MakePaymentStrategy();
            //Return the Object to the Client
            return paymentStrategy;
        }
    }
}
