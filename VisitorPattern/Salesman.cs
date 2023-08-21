using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    // The following Concrete Visitor class implements the Visit Method declared by Visitor Interface. 
    // The Visit Method implements a fragment of the algorithm defined for the corresponding Element class. 
    class Salesman : IVisitor
    {
        //The following Property store the Name of the Salesman
        public string Name { get; set; }
        //Initializing the Name Property using Class Constructor
        public Salesman(string name)
        {
            Name = name;
        }
        //The Following is the Method we want to execute for each element of the collection or Data Structure
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine($"Salesman: {Name} give a school bag to the child: {kid.KidName}");
        }
    }
}
