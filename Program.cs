using System;

namespace PracticeLambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double num2 = double.Parse(Console.ReadLine());
            
            var sum = (double num1, double num2) => num1 + num2;
            var product = (double num1, double num2) => num1 * num2;
            var smallValue = (double num1, double num2) =>
            {
                if (num1 < num2)
                {
                    return num1;
                }
                else
                    return num2;
            };

            Console.WriteLine($"The numbers you entered are: {num1} and {num2}");
            Console.WriteLine($"Here is the sum of the numbers you entered: {sum(num1, num2)}");
            Console.WriteLine($"Here is the program of the numbers you entered: {product(num1, num2)}");
            Console.WriteLine($"The smaller value is: {smallValue(num1, num2)}");
        }
    }
}