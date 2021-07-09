using System;
using System.Collections.Generic;

namespace HW5
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
            List<int> testScores = new List<int>();
            int testScoreTotal, userTestScore;
            float testScoreAvg;

            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Please enter a score for test number {i + 1} >> ");
                userTestScore = int.Parse( Console.ReadLine() );
                testScores.Add(userTestScore);
            }

            testScoreTotal = CalcSum(testScores);
            testScoreAvg = ( (float)testScoreTotal / (float)testScores.Count) * 1.0f;

            Console.WriteLine("Scores for the tests are: ");
            for (int i = 0; i < testScores.Count; i++)
            {
                Console.Write($"Test # {i}: ");
                Console.Write($"  {testScores[i]} ");
                Console.WriteLine($" From average: {testScores[i] - testScoreAvg:0.###}");
            }

            Console.WriteLine($"Total is {testScoreTotal}");
            Console.WriteLine($"Average is {testScoreAvg:0.###}");
        }

        public static int CalcSum(List<int> intList)
        {
            int sum = 0;
            foreach (int integer in intList)
                sum += integer;
            return sum;
        }

        public static void Exe2()
        {
            List<int> temps = new List<int>();
            List<int> sortedTemps = new List<int>();
            List<int> reverseSortedTemps = new List<int>();
            int userTemp, avgTemp;
            const int MAX_TEMP = 130;
            const int MIN_TEMP = -30;

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.Write($"Please enter a temperature {i + 1} >> ");
                    userTemp = int.Parse(Console.ReadLine());
                }
                while (userTemp > MAX_TEMP || userTemp < MIN_TEMP);

                temps.Add(userTemp);
                sortedTemps.Add(userTemp);
                reverseSortedTemps.Add(userTemp);
            }

            //from lowest to highest temp
            sortedTemps.Sort();
            //from highest to lowest temp
            reverseSortedTemps.Sort();
            reverseSortedTemps.Reverse();

            avgTemp = CalcSum(temps) / temps.Count;

            if ( arraysDoMatch(temps, sortedTemps) )
                Console.Write($"Getting warmer: ");
            else if ( arraysDoMatch(temps, reverseSortedTemps) )
                Console.Write($"Getting cooler: ");
            else
                Console.Write($"It's a mixed bag: ");

            displayTempList(temps);

            Console.WriteLine($"The average temperature is: {avgTemp}");

        }

        public static bool arraysDoMatch(List<int> tempList, List<int> tempList2)
        {
            for (int i = 0; i < tempList.Count; i++)
                if (tempList[i] != tempList2[i])
                    return false;

            return true;
        }

        public static void displayTempList(List<int> tempList)
        {
            for (int i = 0; i < tempList.Count; i++)
                if (i == tempList.Count - 1)
                    Console.WriteLine($" {tempList[i]} ");
                else
                    Console.Write($"{tempList[i]} ");
        }

        public static void Exe3()
        {
            int numOfNights;
            double nightlyRate, totalCost;
            const double ONE_OR_TWO_NIGHTS = 200.00;
            const double THREE_OR_FOUR_NIGHTS = 180.00;
            const double FIVE_SIX_OR_SEVEN_NIGHTS = 160.00;
            const double OVER_EIGHT_NIGHTS = 145.00;
           
            Console.Write("How many nights is your stay? ");
            numOfNights  = int.Parse( Console.ReadLine() );

            if (numOfNights <= 2 && numOfNights > 0)
                nightlyRate = ONE_OR_TWO_NIGHTS;
            else if (numOfNights <= 4)
                nightlyRate = THREE_OR_FOUR_NIGHTS;
            else if (numOfNights <= 7)
                nightlyRate = FIVE_SIX_OR_SEVEN_NIGHTS;
            else
                nightlyRate = OVER_EIGHT_NIGHTS;

            totalCost = nightlyRate * numOfNights;

            Console.WriteLine($"Price per night is {nightlyRate.ToString("C")}");
            Console.WriteLine($"Total for {numOfNights} night(s) is {totalCost.ToString("C")}");
        }

        public static void Exe4()
        {
            int[] numbers = { 12, 15, 22, 88 };
            double average;
            double total = 0;

            Console.Write("\nThe numbers are...");
            for (int x = 0; x < numbers.Length; x++)
                Console.Write($" {numbers[x]} ");
            Console.WriteLine();
            for (int x = 0; x < numbers.Length; x++)
            {
                total += numbers[x];
            }
            average = total / numbers.Length;

            Console.WriteLine($"The average is {average:0.##}");

        }

        public static void Exe5()
        {
            const int QUIT = 999;
            List<int> numbers = new List<int>();
            int x;
            int num;
            double average;
            double total = 0;
            string inString;

            Console.Write("Please enter a number or " + QUIT + " to quit...");
            inString = Console.ReadLine();
            num = int.Parse(inString);
            x = 0;
            while ( num != QUIT)
            {
                numbers.Add(num);
                total += numbers[x];
                x++;
                Console.Write("Please enter a number or " +
                    QUIT + " to quit...");
                inString = Console.ReadLine();
                num = Convert.ToInt32(inString);
            }

            Console.WriteLine("The numbers are:");
            for (int y = 0; y < numbers.Count; y++)
                Console.Write($"  {numbers[y]}  ");
            average = total / numbers.Count;
            Console.WriteLine();
            Console.WriteLine("The average is {0}", average);

        }
    }
}
