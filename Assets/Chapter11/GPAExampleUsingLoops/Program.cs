using System;

namespace GPAExampleUsingLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            double gpa;
            do
            {
                // prompt for and get GPA
                Console.Write("Enter a GPA (0.0-4.0): ");
                gpa = double.Parse(Console.ReadLine());
                // print error message for invalid GPA
                if (gpa < 0.0 || gpa > 4.0)
                {
                    Console.WriteLine("Invalid entry! GPA must be between 0.0 and 4.0");
                    Console.WriteLine();
                }
            } while (gpa < 0.0 || gpa > 4.0);
        }
    }
}
