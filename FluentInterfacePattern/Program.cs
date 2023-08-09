namespace FluentInterfacePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an Instance of Wrapper class i.e. FluentEmployee
            FluentEmployee obj = new FluentEmployee();
            //Call Methods one by one using dot Operator whose Return Type is FluentEmployee
            obj.NameOfTheEmployee("John Doe")               
                    .Born("10/10/1900")
                    .WorkingOn("IT")
                    .StaysAt("India");

            //To See the Details call the ShowDetails Method
            obj.ShowDetails();
            Console.Read();
        }
    }
}