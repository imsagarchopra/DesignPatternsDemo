using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_2
{
    public class PrintReceiptGenerator : IReceiptGenerator
    {
        public void GenerateReceipt(double amount)
        {
            Console.WriteLine($"Generating print receipt for payment of {amount}.");
        }
    }
}
