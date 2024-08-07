
using System.Threading.Channels;

namespace MohirDevVazifa
{
    class SumOfNumbers
    {
        public uint CalculateSum()
        {
            uint sumOfNumbers = 0;
            Console.WriteLine("Enter a number to find the sum of a series of numbers:");
            if (!uint.TryParse(Console.ReadLine(), out uint n))
            {
                Console.WriteLine("Error! Please enter a valid integer!");
                return 0;
            }

            for (uint i = 0; i <= n; i++)
            {
                sumOfNumbers += i;
            }
            return sumOfNumbers;
        }
    }
}