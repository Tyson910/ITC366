using System;

namespace HW4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string userChoice;
            do
            {
                Console.WriteLine("Choose an exercise number (1-5) or 'e' to exit program");
                userChoice = Console.ReadLine();
                try
                {
                    ChooseExe(userChoice);
                }
                catch
                {
                    if (userChoice.ToLower() == "e")
                        Console.WriteLine(" Good bye... ");
                    else
                        Console.WriteLine("Error! Choose an exercise number (1-5) or 'e' to exit program");
                }
            }
            while (userChoice.ToUpper() != "E");
        }

        public static void ChooseExe(string choice)
        {
            switch (int.Parse(choice))
            {
                case 1:
                    Exe1();
                    break;
                case 2:
                    Exe2();
                    break;
                case 3:
                    Exe3();
                    break;
                case 4:
                    Exe4();
                    break;
                case 5:
                    Exe5();
                    break;
                default:
                    Console.WriteLine(" Not a number between 1-5 ");
                    break;
            }
        }

        public static void Exe1()
        {
            char userInput;
            bool inputIsUpper;
            do
            {
                Console.WriteLine("Enter an uppercase letter or ! to quit ");
                userInput = char.Parse(Console.ReadLine());
                inputIsUpper = Char.IsUpper(userInput);
                if (inputIsUpper)
                    Console.WriteLine("Congrats! This is an uppercase letter");
                else
                    Console.WriteLine("Sorry - that was not an uppercase letter. ");
            }
            while (userInput != '!' && !inputIsUpper);
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

        public static void Exe4()
        {
            const string ITEM209 = "209";
            const string ITEM312 = "312";
            const string ITEM414 = "414";
            const double PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07;
            double price;
            string stockNum;

            Console.Write("Please enter the stock number of the item you want ");
            stockNum = Console.ReadLine().Trim();
            while (!String.Equals(stockNum, ITEM209) && !String.Equals(stockNum, ITEM312) && !String.Equals(stockNum, ITEM414))
            {
                Console.WriteLine($" {stockNum} is an invalid stock number. Please enter again. ");
                stockNum = Console.ReadLine();
            }

            if (String.Equals(stockNum, ITEM209))
                price = PRICE209;
            else if (String.Equals(stockNum, ITEM312))
                price = PRICE312;
            else
                price = PRICE414;

            Console.WriteLine("The price for item # {0} is {1}", stockNum, price.ToString("C"));
        }

        public static void Exe5()
        {
            const double LIMIT = 1000000.00;
            const double START = 0.01;
            string inputString;
            double total;
            int howMany;
            int count;

            Console.Write("How many days do you think ");
            Console.WriteLine("it will take you to reach");
            Console.Write("{0} starting with {1}",
                LIMIT.ToString("C"), START.ToString("C"));
            Console.WriteLine("and doubling it every day?");
            inputString = Console.ReadLine();
            howMany = Convert.ToInt32(inputString);
            count = 0;
            total = START;
            while (total < LIMIT)
            {
                total *= 2;
                count += 1;
            }

            if (howMany > count)
                Console.WriteLine("Your guess was too high.");
            else if (howMany < count)
                Console.WriteLine("Your guess was too low.");
            else
                Console.WriteLine("Your guess was correct.");

            Console.WriteLine("It takes {0} days to reach {1} ",
               count, LIMIT.ToString("C"));
            Console.WriteLine("when you double {0} every day",
               START.ToString("C"));
        }

    }
}

