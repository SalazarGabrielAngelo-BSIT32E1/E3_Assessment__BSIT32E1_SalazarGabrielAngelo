using System;

namespace Assessments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Area of triangle\n");
            Console.Write("Enter the base of the triangle: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the triangle: ");
            double h = Convert.ToDouble(Console.ReadLine());
            
            double area = 0.5 * b * h;

            Console.WriteLine($"The area of the triangle with base {b} and height {h} is: {area}\n");


            Console.Write("Loop with sqrt\n");
            for (int i = 1; i <= 10; i++)
            {
                double sqrt = Math.Sqrt(i);

                Console.WriteLine($"Number: {i}, Square Root: {sqrt}");
            }
        }
    }
}