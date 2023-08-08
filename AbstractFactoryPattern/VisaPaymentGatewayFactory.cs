using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridFactory_StrategyPattern
{
    public class VisaPaymentGatewayFactory : PaymentGatewayFactory
    {       
        protected override IPaymentGateway MakePaymentGateway()
        {
            return new VisaPaymentGateway();
        }
    }
}
