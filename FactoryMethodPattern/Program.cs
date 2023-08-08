using StrategyPattern;
using static StrategyPattern.Program;

namespace FactoryMethodPattern
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

                IPaymentStrategy paymentStrategy = null;

                //Based on the Payment Type Selected by user at Runtime,
                //Create the Appropriate Payment Strategy Instance and call the SetPaymentStrategy method
                if (selectedPaymentType == PaymentType.CreditCard)
                {
                    paymentStrategy = new CreditCardPaymentStrategyFactory().CreateProduct();

                }
                else if (selectedPaymentType == PaymentType.DebitCard)
                {
                    paymentStrategy = new DebitCardPaymentStrategyFactory().CreateProduct();

                }
                else if (selectedPaymentType == PaymentType.Cash)
                {
                    paymentStrategy = new CashPaymentStrategyFactory().CreateProduct();
                }
                else
                {
                    Console.WriteLine("Invalid input for payment type.");
                }
                
                if (paymentStrategy == null)
                    return;

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