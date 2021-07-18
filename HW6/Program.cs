using System;

namespace HW6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exe3();
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

        public static void Exe3()
        {
            double mealPrice = 30.00;
            double percentTip = .20;
            int flatTip = 5;
        
            DisplayMealCost(mealPrice, percentTip);
            Console.WriteLine("");
            Console.WriteLine("");
            DisplayMealCost(mealPrice, flatTip);
        }
        public static void DisplayMealCost(double mealPrice, double tip)
        {
            double total;
            double tipInDollars = mealPrice * tip;
            total = mealPrice + tipInDollars;
            Console.WriteLine($"Meal Price: {mealPrice.ToString("C")}. Tip percent: {tip:0.00} ");
            Console.Write($"Tip in dollars: {tipInDollars.ToString("C")} ");
            Console.WriteLine($"Total bill {total.ToString("C")}");
        }
        public static void DisplayMealCost(double mealPrice, int tip)
        {
            double total;
            double tipInPercentage = tip / mealPrice;
            total = mealPrice + tip;
            Console.WriteLine($"Meal Price: {mealPrice.ToString("C")}. Tip percent: {tipInPercentage:0.00} ");
            Console.Write($"Tip in dollars: {tip.ToString("C")} ");
            Console.Write($"Total bill {total.ToString("C")}");
        }
    }
}
