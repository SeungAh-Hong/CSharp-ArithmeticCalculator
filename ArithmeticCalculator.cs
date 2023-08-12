using System;

namespace ArithmeticCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result = 0;
            string operation;

            Console.WriteLine("Arithmetic Calculator");

            // Input first number
            Console.Write("Enter the first number: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            // Input second number
            Console.Write("Enter the second number: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            // Input operation
            Console.WriteLine("Enter operation (+, -, *, /): ");
            operation = Console.ReadLine();

            // Perform the chosen operation
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Only +, -, *, / are allowed.");
                    return;
            }

            // Display the result
            Console.WriteLine($"{num1} {operation} {num2} = {result}");
        }
    }
}