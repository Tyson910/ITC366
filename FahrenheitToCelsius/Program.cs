using System;

namespace FahrenheitToCelsius
{
    class MainClass
    {
        static float convertToC (float temp)
        {
            return (temp - 32) * 5/9f ;
        }
        public static void Main(string[] args)
        {
            Console.Write("Please enter a temperature in Fahrenheit >>>  ");
            float userTemp = float.Parse( Console.ReadLine() );
            float cTemp = convertToC(userTemp);
            Console.WriteLine( userTemp.ToString("0.0") + " degrees F is " + cTemp.ToString("0.0") + " degrees C");
        }
    }
}
