using System.ComponentModel;

namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The client code works with all of the components (Both Leaf and Composite) via the base interface i.e. Component.
            // Component means the class that implements the Component abstract class
            // In our example Leaf and Composite classes implement the Component abstract class
            //Creating Leaf Objects or you can say child objects
            IComponent Pranaya = new Leaf("Pranaya", 22000);
            IComponent Rohit = new Leaf("Rohit", 33000);
            IComponent Anurag = new Leaf("Anurag", 42000);
            IComponent Priyanka = new Leaf("Priyanka", 52000);
            IComponent Sambit = new Leaf("Sambit", 28000);

            //Creating Composite Objects
            Composite ITDepartment = new Composite("ITDepartment", new List<IComponent> { Pranaya, Rohit, Anurag });
            Composite HRDepartment = new Composite("HRDepartment", new List<IComponent> { Priyanka, Sambit });
            Composite Company = new Composite("Company" , new List<IComponent> { ITDepartment, HRDepartment });
            
            Console.WriteLine("All Employees of the Company");
            //To Display the Price of the Computer i.e. it will display the Price of all components
            Console.WriteLine($"Total Salary of the Company: {Company.GetSalary()}");
            //To display Salaries and Employees of the IT Department
            Console.WriteLine("\nIT Department Employees");
            Console.WriteLine($"Total Salary of IT Department: {ITDepartment.GetSalary()}");
            //To display Salaries and Employees of the HR Department
            Console.WriteLine("\nHR Department Employees");
            Console.WriteLine($"Total Salary of HR Department: {HRDepartment.GetSalary()}");

            //To display Salaries and Employees of HR Department
            Console.WriteLine("\nSalary of Employee Pranaya:");
            Pranaya.GetSalary();
            Console.WriteLine($"\nSalary of Employee Anurag: ");
            Anurag.GetSalary();
            Console.Read();
        }
    }
}