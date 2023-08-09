using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_2
{
    public class MastercardPaymentFactory : IPaymentFactory
    {
        public IPaymentGateway CreatePaymentGateway()
        {
            return new MastercardPaymentGateway();
        }

        public IReceiptGenerator CreateReceiptGenerator()
        {
            return new PrintReceiptGenerator();
        }
    }
}
