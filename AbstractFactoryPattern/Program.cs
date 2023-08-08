using StrategyPattern;
using static StrategyPattern.Program;

namespace AbstractFactoryPattern
{
    public class Program
    {
        public enum PaymentGatewayType
        {
            Visa = 1,
            Mastercard = 2,
        }

        static void Main(string[] args)
        {
            // Ask the user to Select the Payment Type
            Console.WriteLine("Please Select Payment Type : \n1. CreditCard \n2. DebitCard \n3. Cash");

            if (Enum.TryParse(Console.ReadLine(), out PaymentType selectedPaymentType))
            {
                Console.WriteLine("Payment type is: " + selectedPaymentType);

                PaymentGatewayFactory gatewayFactory;

                Console.WriteLine("Please select Payment Gateway: \n1. Visa \n2. Mastercard");

                if (Enum.TryParse(Console.ReadLine(), out PaymentGatewayType selectedGatewayType))
                {
                    Console.WriteLine("Selected gateway: " + selectedGatewayType);

                    double amount;
                    Console.WriteLine("Please enter Amount to Pay:");
                    while (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid amount:");
                    }

                    Console.WriteLine("Amount is: " + amount);

                    PaymentStrategyFactory strategyFactory;
                    IPaymentStrategy paymentStrategy = null;

                    if (selectedPaymentType == PaymentType.CreditCard)
                    {
                        strategyFactory = new CreditCardPaymentStrategyFactory();
                    }
                    else if (selectedPaymentType == PaymentType.DebitCard)
                    {
                        strategyFactory = new DebitCardPaymentStrategyFactory();
                    }
                    else if (selectedPaymentType == PaymentType.Cash)
                    {
                        strategyFactory = new DebitCardPaymentStrategyFactory();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for payment type.");
                        return;
                    }

                    if (selectedGatewayType == PaymentGatewayType.Visa)
                    {
                        gatewayFactory = new VisaPaymentGatewayFactory();
                    }
                    else if (selectedGatewayType == PaymentGatewayType.Mastercard)
                    {
                        gatewayFactory = new MastercardPaymentGatewayFactory();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for payment gateway.");
                        return;
                    }

                    IPaymentGateway paymentGateway = gatewayFactory.CreatePaymentGateway();
                    paymentStrategy = strategyFactory.CreatePaymentStrategy(paymentGateway);

                    if (paymentGateway == null || paymentStrategy == null)
                        return;

                    PaymentContext context = new PaymentContext(paymentStrategy, paymentGateway);
                    context.ProcessPayment(amount);
                    context.Pay(amount);
                }
                else
                {
                    Console.WriteLine("Invalid input for payment gateway.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for payment type.");
            }

            Console.ReadKey();
        }
    }
}