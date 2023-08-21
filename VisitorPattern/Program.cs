namespace VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of the object structure i.e. School class
            School school = new School();
            //Create an Instance of the Visitor i.e. Doctor
            var visitor1 = new Doctor("James");
            //Call the PerformOperation Method by passing the Visitor Object which wants to Visit
            //All elements of the ObjectStructure i.e. a collection
            //Here, Doctor James will Visit all the Kids at the School
            school.PerformOperation(visitor1);
            Console.WriteLine();
            //Create an Instance of another Visitor i.e. Salesman
            var visitor2 = new Salesman("John");
            //Call the PerformOperation Method by passing the Visitor Object which wants to Visit
            //All elements of the ObjectStructure i.e. a collection
            //Here, the Salesman John will Visit all the Kids of the School
            school.PerformOperation(visitor2);
            Console.Read();
        }
    }
}