using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSquaresOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of squares to print: ");
            int n = int.Parse(Console.ReadLine());
            // print the squares
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine("The square of {0} is {1}", i, i * i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
