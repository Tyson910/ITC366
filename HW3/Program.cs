using System;

namespace HW3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exe2();
            /*
             Exe1();
             Exe2();
             Exe3();
             Exe4();
             Exe5();
             */
            /*
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
                    {
                        Console.WriteLine(" Good bye... ");
                    }
                    else
                    {
                        Console.WriteLine(" please try again!");
                    }
                }
            }
            while (userChoice.ToUpper() != "E");
        }
            */
            /*
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
            */
        }
        public static void Exe1()
        {
            Console.WriteLine("Enter your short message below: ");
            String userMessage = Console.ReadLine();
            if (userMessage.Length <= 140)
                Console.WriteLine("The message is okay");
            else
                Console.WriteLine($"Error!! Message is {userMessage.Length} characters, please enter a message under 140 characters");
        }
        public static void Exe2()
        {
            Console.WriteLine("Enter a grade point average: ");
            double GPA = double.Parse( Console.ReadLine() );
            Console.WriteLine("Enter test score");
            int testScore = int.Parse( Console.ReadLine() );
            if (GPA >= 3.0 && testScore >= 60)
                Console.WriteLine("Accepted ");
            else if (GPA < 3.0 && testScore >= 80)
                Console.WriteLine("Accepted");
            else
                Console.WriteLine("Rejected");
                
        }
        public static void Exe4()
        {
            // Program decides tuition based on several criteria:
            // 1 - 12 credit hours @ $150 per credit hour
            // 13 - 18 credit hours, flat fee $1900
            // over 18 hours, $1900 plus $100 per credit hour over 18
            // If year in school is 4, there is a 15% discount

            int credits, year;
            string inputString;
            double tuition;
            const int LOWCREDITS = 12;
            const int HIGHCREDITS = 18;
            const double HOURFEE = 150.00;
            const double DISCOUNT = 0.15;
            const double FLAT = 1900.00;
            const double RATE = 100.00;
            const int SENIORYEAR = 4;

            Console.WriteLine("How many credits? ");
            inputString = Console.ReadLine();
            credits = Convert.ToInt32(inputString);

            Console.WriteLine("Year in school? ");
            inputString = Console.ReadLine();
            year = Convert.ToInt32(inputString);

            if (credits <= LOWCREDITS)
                tuition = HOURFEE * credits;
            else if (credits > HIGHCREDITS)
                tuition = FLAT + (credits - HIGHCREDITS) * RATE;
            else
                tuition = FLAT;

            if (year == SENIORYEAR)
                tuition -= (tuition * DISCOUNT);

            Console.WriteLine("For year {0}, with {1} credits",
          year, credits);
            Console.WriteLine("Tuition is {0}", tuition.ToString("C"));

        }
        public static void Exe5()
        {
            // Program takes a hot dog order
            // And determines price

            const double BASIC_DOG_PRICE = 2.00;
            const double CHILI_PRICE = 0.69;
            const double CHEESE_PRICE = 0.49;
            String wantChilli, wantCheese;
            double price;

            Console.WriteLine("Do you want chili on your dog? (Y/N)  ");
            wantChilli = Console.ReadLine().ToUpper();
            Console.WriteLine("Do you want cheese on your dog? (Y/N)  ");
            wantCheese = Console.ReadLine().ToUpper();

            if (wantChilli == "Y" && wantCheese == "Y")
                price = BASIC_DOG_PRICE + CHILI_PRICE + CHEESE_PRICE;
            else if (wantChilli == "Y")
                price = BASIC_DOG_PRICE + CHILI_PRICE;
            else if (wantCheese == "Y")
                price = BASIC_DOG_PRICE + CHEESE_PRICE;
            else
                price = BASIC_DOG_PRICE;

            Console.WriteLine("Your total is {0}", price.ToString("C"));

        }

    }
}