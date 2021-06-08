using System;

namespace InchesToCentimetersInteractive
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const float cmPerInch = 2.54f;
            Console.Write("Please enter a value in inches >>>  ");
            int inches = int.Parse( Console.ReadLine() );
            Console.WriteLine(inches + " inches is " + (inches * cmPerInch) + " centimeters");
        }
    }
}
