namespace AbstractFactoryPattern_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select Payment Type:\n1. Visa\n2. Mastercard");
            if (Enum.TryParse(Console.ReadLine(), out PaymentType selectedPaymentType))
            {
                IPaymentFactory factory = null;
                if (selectedPaymentType == PaymentType.Visa)
                {
                    factory = new VisaPaymentFactory();
                }
                else if (selectedPaymentType == PaymentType.Mastercard)
                {
                    factory = new MastercardPaymentFactory();
                }

                if (factory != null)
                {
                    PaymentProcessor processor = new PaymentProcessor(factory);
                    Console.WriteLine("Please enter Amount to Pay:");
                    if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
                    {
                        processor.ProcessPayment(amount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid payment type.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.ReadKey();
        }

        public enum PaymentType
        {
            Visa = 1,
            Mastercard = 2,
        }
    }
}