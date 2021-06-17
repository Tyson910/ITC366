using System;

namespace HW1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");

        }
        public static string DisplayMenu()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Homework 1");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine("Hit [4] to run Exercise 4.");
            Console.WriteLine("Hit [5] to run Exercise 5.");

            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;


        }
        private static bool Run(string exeArg)

        {
            switch (exeArg.ToLower())
            {

                case "1":
                    DoExe1();
                    return true;

                case "2":
                    DoExe2();
                    return true;

                case "3":
                    DoExe3();
                    return true;

                case "4":
                    DoExe4();
                    return true;

                case "5":
                    DoExe5();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }
        private static void DoExe1()
        {
            const float cmPerInch = 2.54f;
            int inches = 3;
            Console.WriteLine(inches + " inches is " + (inches * cmPerInch) + " centimeters");
            // throw new NotImplementedException();
        }
        private static void DoExe2()
        {
            const float cmPerInch = 2.54f;
            Console.Write("Please enter a value in inches >>>  ");
            int inches = int.Parse( Console.ReadLine() );
            Console.WriteLine(inches + " inches is " + (inches * cmPerInch) + " centimeters");
            // throw new NotImplementedException();
        }
        private static float convertToC (float temp)
        {
            return (temp - 32) * 5/9f ;
        }
        private static void DoExe3()
        {
            Console.Write("Please enter a temperature in Fahrenheit >>>  ");
            float userTemp = float.Parse( Console.ReadLine() );
            float cTemp = convertToC(userTemp);
            Console.WriteLine( userTemp.ToString("0.0") + " degrees F is " + cTemp.ToString("0.0") + " degrees C");
            // throw new NotImplementedException();
        }
        enum Planets
        {
            Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
        }
        private static void DoExe4()
        {
            Console.WriteLine("Please enter a position in the solar system (1-8)");
            int userPosition = int.Parse( Console.ReadLine() ) - 1;
            Console.Write("You selected....");
            Console.WriteLine( (Planets)userPosition );
            // throw new NotImplementedException();
        }
        private static void DoExe5()
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
            // throw new NotImplementedException();
        }
    }
}
