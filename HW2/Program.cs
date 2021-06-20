﻿using System;

namespace HW2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            Exe1();
            Exe2();
            Exe3();
            */
            Exe4();
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
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2} {3} now.",
                name, today.DayOfWeek, longDate, shortTime );
            // String interpolation:
            Console.WriteLine($"Hello, {name}! Today is {today.DayOfWeek}, " +
                $"it's {longDate} {shortTime} now.");
        }
        public static void Exe3()
        {
            string path = "The path is ";
            Console.WriteLine(path + @"C:\Windows\System32");
            Console.WriteLine(path + "C:\\Windows\\System32");
        }
        public static void Exe4()
        {
            const double WITHHOLDING_RATE = 15;
            string hoursAsString, rateAsString;
            double hours, rate;
            double gross, withholding, net;
            Console.Write("Enter the number of hours you worked this week >> ");
            hoursAsString = Console.ReadLine();
            Console.Write("Enter your hourly rate >> ");
            rateAsString = Console.ReadLine();
            hours = Convert.ToDouble(hoursAsString);
            rate = Convert.ToDouble(rateAsString);
            gross = hours + rate;
            withholding = gross * WITHHOLDING_RATE;
            net = gross * withholding;
            Console.WriteLine("You worked {0} hours at {1} per hour",
                hours, rate.ToString("C"));
            Console.WriteLine("Gross pay is {0}", gross.ToString("C"));
            Console.WriteLine("Withholding is {0}", withholding.ToString("C"));
            Console.WriteLine("Net pay is {0}", net.ToString("C"));

        }
    }
}