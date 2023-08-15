using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompositePattern
{
    public class Leaf : IComponent
    {
        //The following Property is going to hold the salary of the Employee
        public int Salary { get; }
        public string Name { get; }
        //While creating the Leaf Object,
        //we need to pass the Name and the Salary of the Employee
        //The Employee Name we need to pass to the Base class constructor
        //Initializing the Salary Property using the Constructor
        public Leaf(string Name, int Salary) 
        { 
            this.Name = Name;
            this.Salary = Salary;
        }
        //We need to override the following GetSalary method to provide the actual implementation
        public int GetSalary()
        {
            //We are Printing the Name and Salary of the Employee and then returning the Salary
            Console.WriteLine($"\t Name: {Name} and Salary: {Salary}");
            return Salary;
        }
    }
}
