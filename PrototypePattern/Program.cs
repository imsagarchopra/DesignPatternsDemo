namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example to Understand Deep Copy and Shallow Copy in C#
            //Creating Employee Object
            Employee emp1 = new TemporaryEmployee
            {
                Name = "Anurag",
                Department = "IT",
                EmpAddress = new Address() { address = "BBSR" }
            };
            //Creating a Clone Object from the Existing Object using the GetDeepCopy method
            Employee emp2 = emp1.GetDeepCopy();
            //Changing Name and Address Property of Clone Object
            emp2.Name = "Pranaya";
            emp2.EmpAddress.address = "Mumbai";
            Console.WriteLine("Using Deep Copy");
            Console.WriteLine($" Emplpyee 1: Name: {emp1.Name}, Address: {emp1.EmpAddress.address}");
            Console.WriteLine($" Emplpyee 2: Name: {emp2.Name}, Address: {emp2.EmpAddress.address}");

            //Creating Employee Object
            Employee emp3 = new PermanentEmployee
            {
                Name = "Sambit",
                Department = "HR",
                EmpAddress = new Address() { address = "Delhi" }
            };
            //Creating a Clone Object from the Existing Object using the GetShallowCopy method
            Employee emp4 = emp3.GetShallowCopy();
            //Changing Name and Address Property of Clone Object
            emp4.Name = "Hina";
            emp4.EmpAddress.address = "Hyderabad";
            Console.WriteLine("\nUsing Shallow Copy");
            Console.WriteLine($" Emplpyee 3: Name: {emp3.Name}, Address: {emp3.EmpAddress.address}");
            Console.WriteLine($" Emplpyee 4: Name: {emp4.Name}, Address: {emp4.EmpAddress.address}");

            Console.Read();
        }
    }
}