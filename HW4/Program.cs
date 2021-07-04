using System;

namespace HW4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exe1();
        }

        public static void Exe1()
        {
            char userInput;
            do
            {
                Console.Write("Enter an uppercase letter or ! to quit ");
                userInput = char.Parse( Console.ReadLine() );
            }
            while (userInput != '!');

        }
    }
}
