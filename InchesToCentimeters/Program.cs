using System;

namespace InchesToCentimeters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const float cmPerInch = 2.54f;
            int inches = 3;
            Console.WriteLine(inches + " inches is " + (inches * cmPerInch) + " centimeters");
        }
    }
}
