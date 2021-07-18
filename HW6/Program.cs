using System;

namespace HW6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exe2();
        }

        public static void Exe1()
        {
            Console.Write("Enter miles >> ");
            int userMiles =  int.Parse( Console.ReadLine() ) ;
            Console.WriteLine($"{userMiles} miles is { mi_to_km(userMiles) } kilometers");
        }
        public static float mi_to_km(int miles)
        {
            return (float)miles * (float)1.60934  * 1.0f ; 
        }

        public static void Exe2()
        {
            int numOfBooks, daysOverDue;
            Console.Write("Enter number of books that are overdue >> ");
            numOfBooks = int.Parse( Console.ReadLine() );
            Console.Write($"Enter number of days that the {numOfBooks} books are overdue >> ");
            daysOverDue = int.Parse(Console.ReadLine());
            DisplayLibFines(numOfBooks, daysOverDue);
        }
        public static void DisplayLibFines(int numOfBooks, int numOfDays)
        {
            const float OVERDUE_FEE = .10f;
            const float OVERDUE_ADDITIONAL_FEE = .20f;
            float totalFine = 0.0f;
            string totalFineStr;
            int i = 0;

            while (i < numOfDays)
            {
                if (i >= 7)
                    totalFine += OVERDUE_FEE * numOfBooks * 1.0f;
                else
                    totalFine += OVERDUE_ADDITIONAL_FEE * numOfBooks * 1.0f;
                i++;
            }

            totalFineStr = totalFine.ToString("C");
            Console.WriteLine($"The fine for {numOfBooks} book(s) for {numOfDays} is {totalFineStr}");
        }
    }
}
