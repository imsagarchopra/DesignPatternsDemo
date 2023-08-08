using StrategyPattern;
using static StrategyPattern.Program;

namespace FactoryPattern
{
    public class Program
    {      
        static void Main(string[] args)
        {
            //Ask the user to Select the Payment Type
            Console.WriteLine("Please Select Payment Type : \n1. CreditCard \n2. DebitCard \n3. Cash");

            if (Enum.TryParse(Console.ReadLine(), out PaymentType selectedPaymentType))
            {
                Console.WriteLine("Payment type is: " + selectedPaymentType);

                Console.WriteLine("Please enter Amount to Pay:");
                double amount;
                while (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid amount:");
                }

                Console.WriteLine("Amount is: " + amount);

                PaymentStrategyFactory strategyFactory = new PaymentStrategyFactory();
                IPaymentStrategy paymentStrategy = strategyFactory.GetPaymentStrategy(selectedPaymentType);

                //Create an Instance of the PaymentContext class
                PaymentContext context = new PaymentContext(paymentStrategy);
                context.Pay(amount);
            }
            else
            {
                Console.WriteLine("Invalid input for payment type.");
            }                
        }
    }
}