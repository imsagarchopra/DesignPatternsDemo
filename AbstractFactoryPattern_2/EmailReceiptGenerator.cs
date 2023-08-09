using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_2
{
    public class EmailReceiptGenerator : IReceiptGenerator
    {
        public void GenerateReceipt(double amount)
        {
            Console.WriteLine($"Generating email receipt for payment of {amount}.");
        }
    }
}
