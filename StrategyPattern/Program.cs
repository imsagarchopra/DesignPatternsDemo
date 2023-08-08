namespace StrategyPattern;
public class Program
{
    public enum PaymentType
    {
        CreditCard = 1,  // 1 for CreditCard
        DebitCard = 2,   // 2 for DebitCard
        Cash = 3, // 3 for Cash
    }

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

            //Create an Instance of the PaymentContext class
            PaymentContext context = null;

            //Based on the Payment Type Selected by user at Runtime,
            //Create the Appropriate Payment Strategy Instance and call the SetPaymentStrategy method
            if (selectedPaymentType == PaymentType.CreditCard)
            {
                 context = new PaymentContext(new CreditCardPaymentStrategy());
               
            }
            else if (selectedPaymentType == PaymentType.DebitCard)
            {
                 context = new PaymentContext(new DebitCardPaymentStrategy());
              
            }
            else if (selectedPaymentType == PaymentType.Cash)
            {
                 context = new PaymentContext(new CashPaymentStrategy());               
            }
            else
            {
                Console.WriteLine("Invalid input for payment type.");
            }
            
            context?.Pay(amount);                      
        }
        else
        {
            Console.WriteLine("Invalid input for payment type.");
        }             
    }   
}

