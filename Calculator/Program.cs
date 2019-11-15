using System;
using Functions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t...2 Digit Calculator...\t\t\n\n");
            Console.WriteLine("Enter Number 1: ");
            var n1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            var n2 = Convert.ToDecimal(Console.ReadLine());

            var calc1 = new BasicOperations(n1, n2);

            Console.WriteLine($"{n1} + {n2} = {calc1.GetAdd()}");
            // New code has been added below
        }
    }
}
