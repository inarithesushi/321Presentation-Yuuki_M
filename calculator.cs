/* There are at least seven logic errors in this code and many bad design choices. 
    Feel free to comment or directly edit your changes but do not merge your branch with main! */ 

using System;

// Accessibility issue. Need to write a summary of a function.
class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");

        try
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine()); // Implementation issue. Need to convert string to int.

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine()); // Implementation issue. Need to convert string to int.

            Console.WriteLine("Select operation (+, -, *, /): ");
            char operation = Console.ReadLine()[0]; // Logic Error. It will return Exception when the ReadLine is empty.

            CalculatorLogic calculatorLogic = new CalculatorLogic();

            int result = calculatorLogic.PerformCalculation(num1, num2); // Logic Error. It also need to pass "char operation."

            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}"); // 
        }
    }
}

// Accessibility issue. Need to write a summary of a function.
class CalculatorLogic
{
    public int PerformCalculation(int num1, int num2, char operation)
    {
        int result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero");
                }
                break;
            default:
                // * 
                Console.WriteLine("Error: Invalid operation selected.");
                //
                break;
        } // Implementation issue. The programmer hardcoaded the cases and writing a function directly.
          // Possibly, the programmer can make other separated functions for calculations.

        return result;
    }
}

class CalculatorUtility
{
    // * 
    public string ConvertToBinary(int decimalNumber)
    {
        return Convert.ToString(decimalNumber, 2); // Implementation issue. The code need to put "2" for convert binary.
    }
}
