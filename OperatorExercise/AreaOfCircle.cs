
namespace AreaOfCircle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("17/4 is 4 remainder 1");

            Console.WriteLine("What is the radius of your circle?");

            
            if (!double.TryParse(Console.ReadLine(), out var radius))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the radius.");
                return;
            }

            
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}

