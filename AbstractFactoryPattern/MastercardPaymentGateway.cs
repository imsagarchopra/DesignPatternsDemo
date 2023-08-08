using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class MastercardPaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} via Mastercard.");
        }
    }
}
