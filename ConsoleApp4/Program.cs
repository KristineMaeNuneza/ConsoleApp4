

using System;

class Arithmetic
{
    static void Main()
    {
        // Declare variables
        int num1, num2;

        // Get input from the user
        Console.WriteLine("Enter the first number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Perform and display arithmetic operations
        Console.WriteLine($"Sum: {num1 + num2}");
        Console.WriteLine($"Difference: {num1 - num2}");
        Console.WriteLine($"Product: {num1 * num2}");

        // Check for division by zero
        if (num2 != 0)
        {
            double quotient = (double)num1 / num2;
            Console.WriteLine($"Quotient: {quotient}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }

        Console.ReadLine(); // Keep console window open
    }
}