using System;

namespace HW2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exe1();
            Exe2();
            Exe3();
        }
        public static void Exe1()
        {
            string moState = "Missouri State University College of Business";
            Console.WriteLine("Second Word : " + get2ndWord(moState));
        }
        private static string get2ndWord(string sentence)
        {
            int firstSpace = sentence.IndexOf(" ");
            int secondSpace = sentence.IndexOf(" ", firstSpace + 1);
            return sentence.Substring(firstSpace, secondSpace - firstSpace);
        }
        public static void Exe2()
        {
            string name = " Tyson ";
            var today = DateTime.Now;
            string longDate = today.ToLongDateString();
            string shortTime = today.ToShortTimeString();
            // Composite formatting:
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2} {3} now.", name, today.DayOfWeek, longDate, shortTime );
            // String interpolation:
            Console.WriteLine($"Hello, {name}! Today is {today.DayOfWeek}, it's {longDate} {shortTime} now.");
        }
        public static void Exe3()
        {
            string path = "The path is ";
            Console.WriteLine(path + @"C:\Windows\System32");
            Console.WriteLine(path + "C:\\Windows\\System32");
        }
    }
}