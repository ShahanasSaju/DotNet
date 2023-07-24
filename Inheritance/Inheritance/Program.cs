namespace Inheritance
{
    class Shape
    {
       public int length;
       public  int breadth;
       
    }
    class Rectangle : Shape
    {
        public int l;
        public int b;

        public int perimeter()
        {
            return 2 * (l + b);
        }
    }
    class Circle : Shape
    {
        public int radius;
        public double perimeter()
        {
            return (2 * 3.14 * radius);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.length = 2;
            shape.breadth = 4;

            Rectangle rec = new Rectangle();
            rec.l = shape.length;
            rec.b = shape.breadth;
            int rectangleperimeter = rec.perimeter();
            Console.WriteLine("The perimeter of rectangle is : " + rectangleperimeter);
            

            Circle circle = new Circle();
            circle.radius = shape.length;
            double circleperimeter = circle.perimeter();
            Console.WriteLine("The perimeter of the circle is  : " + circleperimeter);
           



        }
    }
}