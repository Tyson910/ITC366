using System;

namespace HW6
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
            Console.Write("Enter miles >> ");
            int userMiles =  int.Parse( Console.ReadLine() ) ;
            Console.WriteLine($"{userMiles} miles is { mi_to_km(userMiles) } kilometers");
        }
        public static float mi_to_km(int miles)
        {
            return (float)miles * (float)1.60934  * 1.0f ; 
        }

        public static void Exe2()
        {
            int numOfBooks, daysOverDue;
            Console.Write("Enter number of books that are overdue >> ");
            numOfBooks = int.Parse( Console.ReadLine() );
            Console.Write($"Enter number of days that the {numOfBooks} books are overdue >> ");
            daysOverDue = int.Parse(Console.ReadLine());
            DisplayLibFines(numOfBooks, daysOverDue);
        }
        public static void DisplayLibFines(int numOfBooks, int numOfDays)
        {
            const float OVERDUE_FEE = .10f;
            const float OVERDUE_ADDITIONAL_FEE = .20f;
            float totalFine = 0.0f;
            string totalFineStr;
            int i = 1;

            while (i <= numOfDays)
            {
                if (i <= 7)
                    totalFine += OVERDUE_FEE * numOfBooks * 1.0f;
                else
                    totalFine += OVERDUE_ADDITIONAL_FEE * numOfBooks * 1.0f;
                i++;
            }

            totalFineStr = totalFine.ToString("C");
            Console.WriteLine($"The fine for {numOfBooks} book(s) for {numOfDays} days is {totalFineStr}");
        }

        public static void Exe3()
        {
            double mealPrice = 30.00;
            double percentTip = .20;
            int flatTip = 5;
        
            DisplayMealCost(mealPrice, percentTip);
            DisplayMealCost(mealPrice, flatTip);
        }
        public static void DisplayMealCost(double mealPrice, double tip)
        {
            double total;
            double tipInDollars = mealPrice * tip;
            total = mealPrice + tipInDollars;
            Console.WriteLine($"Meal Price: {mealPrice.ToString("C")}. Tip percent: {tip:0.00} ");
            Console.Write($"Tip in dollars: {tipInDollars.ToString("C")} ");
            Console.WriteLine($"Total bill {total.ToString("C")} \n");
        }
        public static void DisplayMealCost(double mealPrice, int tip)
        {
            double total;
            double tipInPercentage = tip / mealPrice;
            total = mealPrice + tip;
            Console.WriteLine($"Meal Price: {mealPrice.ToString("C")}. Tip percent: {tipInPercentage:0.00} ");
            Console.Write($"Tip in dollars: {tip.ToString("C")} ");
            Console.Write($"Total bill {total.ToString("C")} \n");
        }

        public static void Exe4()
        {
            int firstInt = 23;
            int middleInt = 45;
            int lastInt = 67;
            Console.WriteLine($"The numbers are {firstInt}, {middleInt}, {lastInt}");
            SwapInts(ref firstInt, ref lastInt);
            Console.WriteLine($"The numbers are {firstInt}, {middleInt}, {lastInt}");
        }
        public static void SwapInts(ref int int1, ref int int2)
        {
            int tempInt = int1;
            int1 = int2;
            int2 = tempInt;
        }

        public static void Exe5()
        {
            FancyDisplay(33);
            FancyDisplay(44, '@');
            FancyDisplay(55.55);
            FancyDisplay(77.77, '*');
            FancyDisplay("hello");
            FancyDisplay("goodbye", '#');
        }
        private static void FancyDisplay(int num, char decoration = 'X')
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, num);
        }
        private static void FancyDisplay(double num, char decoration = 'X')
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, num.ToString("C"));
        }
        private static void FancyDisplay(string word, char decoration = 'X')
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, word);
        }

    }
}
