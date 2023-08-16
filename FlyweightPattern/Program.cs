namespace FlyweightPattern
{
    internal class Program
    {
        private const string Circle = "Circle";
        private const string Square = "Square";

        static void Main(string[] args)
        {
            //Creating Circle Objects with Red Color
            CreateCircles();
            CreateSquares();
            Console.ReadKey();
        }

        private static void CreateCircles()
        {
            Console.WriteLine("\n Red color Circles ");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape(Circle);
                circle.SetColor("Red");
                circle.Draw();
            }
            //Creating Circle Objects with Green Color
            Console.WriteLine("\n Green color Circles ");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape(Circle);
                circle.SetColor("Green");
                circle.Draw();
            }
            //Creating Circle Objects with Blue Color
            Console.WriteLine("\n Blue color Circles");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetShape(Circle);
                circle.SetColor("Green");
                circle.Draw();
            }
            //Creating Circle Objects with Orange Color
            Console.WriteLine("\n Orange color Circles");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetShape(Circle);
                circle.SetColor("Orange");
                circle.Draw();
            }
            //Creating Circle Objects with Black Color
            Console.WriteLine("\n Black color Circles");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetShape(Circle);
                circle.SetColor("Black");
                circle.Draw();
            }
        }

        private static void CreateSquares()
        {
            Console.WriteLine("\n Red color Squares ");
            for (int i = 0; i < 3; i++)
            {
                Square square = (Square)ShapeFactory.GetShape(Square);
                square.SetColor("Red");
                square.Draw();
            }
            //Creating Square Objects with Green Color
            Console.WriteLine("\n Green color Squares ");
            for (int i = 0; i < 3; i++)
            {
                Square square = (Square)ShapeFactory.GetShape(Square);
                square.SetColor("Green");
                square.Draw();
            }
            //Creating Square Objects with Blue Color
            Console.WriteLine("\n Blue color Squares");
            for (int i = 0; i < 3; ++i)
            {
                Square square = (Square)ShapeFactory.GetShape(Square);
                square.SetColor("Green");
                square.Draw();
            }
            //Creating Circle Objects with Orange Color
            Console.WriteLine("\n Orange color Squares");
            for (int i = 0; i < 3; ++i)
            {
                Square square = (Square)ShapeFactory.GetShape(Square);
                square.SetColor("Orange");
                square.Draw();
            }
            //Creating Circle Objects with Black Color
            Console.WriteLine("\n Black color Squares");
            for (int i = 0; i < 3; ++i)
            {
                Square square = (Square)ShapeFactory.GetShape(Square);
                square.SetColor("Black");
                square.Draw();
            }
        }
    }
}