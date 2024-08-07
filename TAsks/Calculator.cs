
namespace MohirDevVazifa
{
    class Calculator
    {
        public void EnterValueAndCalculate()
        {
            Console.WriteLine("Enter the first number:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal firstNumber))
            {
                Console.WriteLine("Error! Please enter a valid number!");
                return;
            }

            Console.WriteLine("Enter the second number:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal secondNumber))
            {
                Console.WriteLine("Error! Please enter a valid number!");
                return;
            }

            Console.WriteLine("Enter an operation (+, -, *, /):");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {firstNumber + secondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {firstNumber - secondNumber}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {firstNumber * secondNumber}");
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Error! Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {firstNumber / secondNumber}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation! Please check and enter again.");
                    break;
            }
        }
    }
}