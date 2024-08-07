namespace MohirDevVazifa
{
    class ParityCheck
    {
        public void CheckParity()
        {
            Console.WriteLine("Enter an integer:");
            if (!uint.TryParse(Console.ReadLine(), out uint number))
            {
                Console.WriteLine("Error! Please enter a valid integer.");
                return;
            }

            string evenOrOdd = (number % 2 == 0) ? "Number is \"Even\"" : "Number is \"Odd\"";
            if (number > 0)
            {
                Console.WriteLine(evenOrOdd);
            }
            else { Console.WriteLine("Number is zero"); }
        }
    }
}