using System;
namespace HW7
{
    public class SalesTransaction
    {
        public string name;
        public int salesAmount;
        public double commisionRate, commisionValue;

        public SalesTransaction()
        { 
        }
        public SalesTransaction(int sales)
        {
            salesAmount = 0;
        }
        public SalesTransaction(string salespersonName)
        {
            name = salespersonName;
            salesAmount = 0;
            commisionRate = 0.0;
            calcCommisionValue();
        }
        public SalesTransaction(string salespersonName, int sales)
        {
            name = salespersonName;
            salesAmount = sales;
            commisionRate = 0.0;
            calcCommisionValue();
        }
        public SalesTransaction(string salespersonName, int sales, double rate)
        {
            name = salespersonName;
            salesAmount = sales;
            commisionRate = rate;
            calcCommisionValue();
        }
        public static SalesTransaction operator+ (SalesTransaction sale1, SalesTransaction sale2)
        {
            SalesTransaction totalSales = new SalesTransaction();
            totalSales.salesAmount = sale1.salesAmount + sale2.salesAmount;
            return totalSales;
        }
        public void DisplaySales()
        {
            Console.WriteLine( salesAmount.ToString("C") );
        }
        public void Display()
        {
            Console.WriteLine($"{name} had sales totaling {salesAmount}. Commision rate is {commisionRate}; comission value is {commisionValue}");
        }
        private void calcCommisionValue()
        {
            commisionValue = commisionRate * salesAmount;
        }
    }
}
