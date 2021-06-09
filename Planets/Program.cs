using System;

namespace Planets
{
    class MainClass
    {
        enum Planets
        {
            Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a position in the solar system (1-8)");
            int userPosition = int.Parse( Console.ReadLine() ) - 1;
            Console.Write("You selected....");
            Console.WriteLine( (Planets)userPosition );
        }
    }
}
