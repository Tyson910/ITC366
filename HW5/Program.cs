using System;
using System.Collections.Generic;
using System.Linq;

namespace HW5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exe2();
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

    }
}
