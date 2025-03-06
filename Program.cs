using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter first number (or 'exit' to quit):");
                string input1 = Console.ReadLine();

                if (input1.ToLower() == "exit")
                {
                    break;
                }

                if (!double.TryParse(input1, out double num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Enter operator (+, -, *, /):");
                string operatorInput = Console.ReadLine();

                if (operatorInput != "+" && operatorInput != "-" && operatorInput != "*" && operatorInput != "/")
                {
                    Console.WriteLine("Invalid operator. Please enter +, -, *, or /.");
                    continue;
                }

                Console.WriteLine("Enter second number:");
                string input2 = Console.ReadLine();

                if (!double.TryParse(input2, out double num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                double result = 0;

                switch (operatorInput)
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
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            continue;
                        }
                        result = num1 / num2;
                        break;
                }

                Console.WriteLine($"Result: {num1} {operatorInput} {num2} = {result}");
            }

            Console.WriteLine("Goodbye!");
        }
    }
}