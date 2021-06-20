using System;

namespace HW2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exe1();
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
        public static void Exe3()
        {
            string path = "The path is ";
            Console.WriteLine(path + @"C:\Windows\System32");
            Console.WriteLine(path + "C:\\Windows\\System32");
        }
    }
}