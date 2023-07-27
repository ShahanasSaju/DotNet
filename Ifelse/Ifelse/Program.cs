namespace Ifelse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            if(n == 1)
            {
                Console.WriteLine("Today is monday");
            }
            else if(n == 2)
                {
                Console.WriteLine("Today is tuesday");
            }
            else if( n == 3)
            {
                Console.WriteLine("Today is wednesday");
            }
            else if(n == 4)
            {
                Console.WriteLine("Today is wednesday");
            }
            else if (n == 4)
            {
                Console.WriteLine("Today is thursday");
            }
            else if (n == 5)
            {
                Console.WriteLine("Today is friday");
            }
            else if (n == 6)
            {
                Console.WriteLine("Today is saturday");
            }
            else if(n == 7)
                {
                Console.WriteLine("Today is sunday");
            }
            else
            {
                Console.WriteLine("Have a good day");
            }
        }
    }
}