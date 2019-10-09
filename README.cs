# the-sum-of-two-numbers
returns sum of two user provided numbers

using System;

namespace Sum_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number: ");
            var input1 = Console.ReadLine();
            Console.WriteLine("enter second number: ");
            var input2 = Console.ReadLine();
            int sum = int.Parse(input1) + int.Parse(input2);
            Console.WriteLine("the sum of those two numbers is: " + sum);

        }
    }
}
