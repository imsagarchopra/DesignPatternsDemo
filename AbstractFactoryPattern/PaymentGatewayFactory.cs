using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class PaymentGatewayFactory
    {
        protected abstract IPaymentGateway MakePaymentGateway();
        // Also note that The Creator's primary responsibility is not creating products. 
        // Usually, it contains some core business logic that relies on Product objects, returned by the factory method. 
        public IPaymentGateway CreatePaymentGateway()
        {
            //Call the MakeProduct which will create and return the appropriate object 
            IPaymentGateway paymentGateway = this.MakePaymentGateway();
            //Return the Object to the Client
            return paymentGateway;
        }
    }
}
