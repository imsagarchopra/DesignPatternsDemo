using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_2
{
    public class PaymentProcessor
    {
        private readonly IPaymentGateway _gateway;
        private readonly IReceiptGenerator _receiptGenerator;

        public PaymentProcessor(IPaymentFactory factory)
        {
            _gateway = factory.CreatePaymentGateway();
            _receiptGenerator = factory.CreateReceiptGenerator();
        }

        public void ProcessPayment(double amount)
        {
            _gateway.ProcessPayment(amount);
            _receiptGenerator.GenerateReceipt(amount);
        }
    }
}
