using System;

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
            Exe4();
            Exe5();
            */
            string userChoice;
            do
            {
                Console.WriteLine("Choose an exercise number (1-5)");
                userChoice = Console.ReadLine();
                ChooseExe(userChoice);
            }
            while (userChoice.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");
        }
        public static void ChooseExe(string choice)
        {
            switch (int.Parse(choice))
            {
                case 1:
                    Exe1();
                    break;
                case 2:
                    Exe2();
                    break;
                case 3:
                    Exe3();
                    break;
                case 4:
                    Exe4();
                    break;
                case 5:
                    Exe5();
                    break;
                default:
                    break;
            }
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
        public static void Exe5()
        {
            string name, bossName;
            bool areNamesTheSame;
            Console.Write("Enter your name >> ");
            name = Console.ReadLine();
            Console.Write("Hello {0}! Enter the name of your boss >> ", name);
            bossName = Console.ReadLine();
            areNamesTheSame = String.Equals(name, bossName);
            Console.WriteLine("It is {0} that you are your own boss", areNamesTheSame);

        }
    }
}