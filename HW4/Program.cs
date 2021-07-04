using System;

namespace HW4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exe3();
        }

        public static void Exe1()
        {
            char userInput;
            do
            {
                Console.WriteLine("Enter an uppercase letter or ! to quit ");
                userInput = char.Parse(Console.ReadLine());
                if (Char.IsUpper(userInput))
                    Console.WriteLine("Congrats! This is an uppercase letter");
                else
                    Console.WriteLine("Sorry - that was not an uppercase letter. ");
            }
            while (userInput != '!');
        }

        public static void Exe2()
        {
            Console.WriteLine("Enter a phrase below ");
            string userPhrase = Console.ReadLine();
            Console.WriteLine($"There are {countVerbs(userPhrase)} vowels in {userPhrase}");
        }

        public static int countVerbs(string phrase)
        {
            int vowelsInString = 0;
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            foreach (char character in phrase)
                for (int i = 0; i < vowels.Length; i++)
                    if (Char.ToLower(vowels[i]) == character)
                        vowelsInString++;

            return vowelsInString;
        }

        public static void Exe3()
        {
            int sum = 0;
            for (int i = 0; i <= 200; i++)
            {
                if (i == 100)
                    Console.WriteLine($"Halfway through... after {i} numbers, sum is {sum}");
                sum += i;
            }
            Console.WriteLine($"The sum of the integers 1 through 200 is {sum}");
        }
    }
}
