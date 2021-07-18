using System;

namespace HW6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exe1();
        }

        public static void Exe1()
        {
            Console.Write("Enter miles >> ");
            int userMiles =  int.Parse( Console.ReadLine() ) ;
            Console.WriteLine($" {userMiles} miles is { mi_to_km(userMiles) } kilometers");
        }
        public static float mi_to_km(int miles)
        {
            return (float)miles * (float)1.60934  * 1.0f ; 
        }
    }
}
