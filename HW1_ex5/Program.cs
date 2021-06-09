using System;

namespace HW1_ex5
{
    class MainClass
    {
        public static void Main()
        {
            string name;
            string firstString, secondString;
            int first, second, product;
            Console.Write("Enter your name >> ");
            name = Console.ReadLine();
            Console.Write("Hello, {0}! Enter an integer >> ", name);
            firstString = Console.ReadLine();
            first = int.Parse(firstString);
            Console.Write("Enter another integer >> ");
            secondString = Console.ReadLine();
            second = int.Parse(secondString);
            product = first * second;
            Console.WriteLine("Thank you, {0}. The product of {1} and {2} is {3}",
            name, first, second, product);
        }

    }
}
