using System;
using System.Collections.Generic;

namespace HW5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exe1();
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
    }
}
