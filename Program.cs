namespace Triangle;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");
        Console.Write("Side 1: ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Side 2: ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Side 3: ");
        double side3 = double.Parse(Console.ReadLine());

        if (IsValidTriangle(side1, side2, side3))
        {
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is equilateral");
            }
            else if (side1 == side2 || side2 == side3 || side3 == side1)
            {
                Console.WriteLine("The triangle is isosceles");
            }
            else
            {
                Console.WriteLine("The triangle is scalene");
            }

            if (IsDegenerateTriangle(side1, side2, side3))
            {
                Console.WriteLine("The triangle is also a degenerate triangle");
            }
        }

        else
        {
            Console.WriteLine("The lengths do not form a valid triangle");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return a > 0 && b > 0 && c > 0 && a + b >= c && a + c >= b && b + c >= a;
    }

    static bool IsDegenerateTriangle(double a, double b, double c)
    {
        return a + b  == c || a + c == b || b + c == a;
    }
}