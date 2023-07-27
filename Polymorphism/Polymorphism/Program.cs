namespace Polymorphism
{
    public class Shape
    {
        public virtual double Perimeter()
        {
            return 0;
        }
    }
    public class Rectangle: Shape
    {
        public double length { get; set; }
        public double breadth { get; set; }

        public Rectangle()
        {
            length = 6;
            breadth = 7;
        }

        public override double Perimeter()
        {
            return 2*(length + breadth);

        }
    }
    public class Circle : Shape
    {
        public double radius{ get; set; }
        public Circle()
        {
            radius = 5;
        }
        public override double  Perimeter()
        {
            return 2 * 3.14 * radius;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            double rectangleperimeter = rectangle.Perimeter();
            Console.WriteLine("The perimeter of rectangle is " + rectangleperimeter);

            Circle circle = new Circle();
            double circleperimeter = circle.Perimeter();
            Console.WriteLine("The perimeter of the cicle is " + circleperimeter);
        }
    }
}