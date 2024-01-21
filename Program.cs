using System;
System.Console.WriteLine(" \t Homework1");
System.Console.WriteLine("Enter a number to calculate Sum of odd number... ");
int sumOFOddNumbers = 0 ;
int number = int.Parse(Console.ReadLine());
int i = 1;
while  (i <= number)
{
    if ( i % 2 == 1 )
    {
    sumOFOddNumbers += i ;
    }
    i++;
}
System.Console.WriteLine("Sum of odd numbers is : " +sumOFOddNumbers);


System.Console.WriteLine(" \n \t Homework 2");
  int[] myArray = { -2, 3, -5, 334, 45, 432, 556, 32, 34, 43, 343, 4, 35, 644, 32, 8, };
  int arrayMax = myArray.Max();
  int arrayMin = myArray.Min();
  
  int minMax = arrayMax * arrayMin;
  Console.WriteLine($"Multiplying the max and min values of the arrays is equal to {arrayMax} x {arrayMin} = {arrayMax*arrayMin}");


System.Console.WriteLine(" \n \t Homework 3");
System.Console.WriteLine("Enter a number to calculate factorial ...");
int x = int.Parse(Console.ReadLine());
long factorial = 1;
for ( i = 1; i <= x ; i++ )
{
  factorial *= i;
}
System.Console.WriteLine($" Factorial of {x} is : {factorial}");