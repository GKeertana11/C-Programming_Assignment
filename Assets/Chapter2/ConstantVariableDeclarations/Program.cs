using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVariableDeclarations
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 10;//Variable declaration.
            const int months = 12;//constant declaration.
            Console.WriteLine(health);
            Console.WriteLine(months);//executable statements.
            Console.ReadLine();
        }
    }
}
