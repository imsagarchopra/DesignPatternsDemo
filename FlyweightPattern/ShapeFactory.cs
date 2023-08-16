using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    // FlyweightFacory
    // This is a factory class used to create concrete objects of the ConcreteFlyweight type
    public class ShapeFactory
    {
        //The Following Dictionary is going to act as our Cache Memory
        private static Dictionary<string, IShape> shapeMap = new Dictionary<string, IShape>();
        //The following Method is going to return the Shape Object
        public static IShape GetShape(string shapeType)
        {
            IShape shape = null;

            //If the key shapeType i.e. circle is stored in the Cache, then return the value of the key
            //else create circle object, store it in the Cache, and return the object
            if (shapeMap.TryGetValue(shapeType, out shape))
            {
            }
            else
            {
                switch (shapeType)
                {
                    case "Circle": shape = new Circle();
                        break;
                    case "Square": shape = new Square();
                        break;
                    default: shape = new Circle();
                        break;
                }
                shapeMap.Add(shapeType, shape);
                Console.WriteLine($" Creating {shapeType} object without any color in shapefactory \n");
            }

            return shape;
        }
    }
}
