using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    // ConcreteFlyweight
    // This is a class which is Inherits from the Flyweight Interface.
    public class Square : IShape
    {
        public string Color { get; set; }
        //The following Properties Values are going to be the same for all Square Shape Object
        private readonly int XCor = 10;
        private readonly int YCor = 20;

        //For Each Square Object, we need to call the Following Method to set the Color
        public void SetColor(string Color)
        {
            this.Color = Color;
        }
        public void Draw()
        {
            Console.WriteLine(" Square: Draw() [Color : " + Color + ", X Cor : " + XCor + ", YCor :" + YCor);
        }
    }
}
