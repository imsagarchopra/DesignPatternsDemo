using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //The following Concrete Decorator class will add Chicken to Existing Pizza
    public class ChickenPizzaDecorator : PizzaDecorator
    {
        //Pass the existing pizza while creating the Instance of ChickenPizzaDecorator
        //Also pass the same existing pizza object to the base constructor
        public ChickenPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }
        //Overriding the MakePizza method to Chicken
        public override string MakePizza()
        {
            //First Call the Concrete Components MakePizza Method and then the AddChicken method
            return base.MakePizza() + AddChicken();
        }
        private string AddChicken()
        {
            return ", Chicken added";
        }
    }
}
