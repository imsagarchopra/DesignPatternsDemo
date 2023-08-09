using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_2
{
    public class VisaPaymentFactory : IPaymentFactory
    {
        public IPaymentGateway CreatePaymentGateway()
        {
            return new VisaPaymentGateway();
        }

        public IReceiptGenerator CreateReceiptGenerator()
        {
            return new EmailReceiptGenerator();
        }
    }
}
