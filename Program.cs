using System;

namespace MohirDevVazifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MohirDev Vazifa Basic \"2\"");
            Console.WriteLine("_____________________Task #1_____________________");
            Console.WriteLine("Welcome to the Calculator program!");
            Calculator calculator = new Calculator();
            calculator.EnterValueAndCalculate();

            Console.WriteLine("\n_____________________Task #2_____________________");
            Console.WriteLine("Welcome to the Sum of Numbers program!");
            SumOfNumbers sumCalculator = new SumOfNumbers();
            Console.WriteLine($"Sum of Numbers is: {sumCalculator.CalculateSum()}");

            Console.WriteLine("\n_____________________Task #3_____________________");
            Console.WriteLine("Welcome to the Parity Check program!");
            ParityCheck parityChecker = new ParityCheck();
            parityChecker.CheckParity();
        }
    }
}