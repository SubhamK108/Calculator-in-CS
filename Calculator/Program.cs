using System;
using Function1;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "y";
            while (option.ToLower() == "y")
            {
                Console.Clear();
                Console.WriteLine("\n\t\t...Two Number Calculator...\t\t\n");
                Console.Write("Enter Number 1: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Number 2: ");
                double n2 = Convert.ToDouble(Console.ReadLine());
                var calc = new BasicOperations(n1, n2);
                Console.Write("What do you want to do (=, -, *, /): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "+":
                        Console.WriteLine($"\n{n1} + {n2} = {calc.GetAdd()}\n");
                        break;
                    case "-":
                        Console.WriteLine($"\n{n1} - {n2} = {calc.GetDiff()}\n");
                        break;
                    case "*":
                        Console.WriteLine($"\n{n1} * {n2} = {calc.GetProd()}\n");
                        break;
                    case "/":
                        Console.WriteLine($"\n{n1} / {n2} = {calc.GetDiv()}\n");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice !!!\n");
                        break;
                }
                Console.Write("Do you want to calculate again (Y/n): ");
                option = Console.ReadLine();
            }
        }
    }
}