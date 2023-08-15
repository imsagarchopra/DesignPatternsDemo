using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Composite : IComponent
    {
        //The Following ChildComponents variable is going to hold all the child components of a composite object
        private List<IComponent> childComponents = new List<IComponent>();
        string name;

        //The Constructor takes the Composite Component name as the input parameter 
        public Composite(string name,List<IComponent> childComponents)
        {
            this.name = name;
            this.childComponents = childComponents;
        }

        //I am not using below methods to add components, instead I am using constructor to construct the composite. Because we are trying to avoid mutation here and keep our solution immutable
        
        //The following Method is used to add Child Components inside the Composite Component
        //public void AddComponent(Component NewComponent)
        //{
        //    this.ChildComponents.Add(NewComponent);
        //}
        ////The following Method is used to Remove Child Components from the Composite Component
        //public void RemoveComponent(Component RemoveComponent)
        //{
        //    this.ChildComponents.Remove(RemoveComponent);
        //}

        public int GetSalary()
        {
            //int TotalSalary = 0;
            //foreach (var component in ChildComponents)
            //{
            //    var salary = component.GetSalary();
            //    TotalSalary += salary;
            //}
            //return TotalSalary;
            // Summarizing the Salary of all children
            return this.childComponents.Sum(x => x.GetSalary());
        }
    }
}
