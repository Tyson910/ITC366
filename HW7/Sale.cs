using System;
namespace HW7
{
    public class Sale
    {

        public double taxAmount, saleAmount;
        public int InventoryNum { get; set; }
        public double SaleAmount
        {
            get { return saleAmount; }

            set
            {
                saleAmount = value;
                if (value < 101)
                {
                    taxAmount = value * .08;
                }
                else
                {
                    taxAmount = calcMarginalTaxRate(value);
                }
            }
        }

        public Sale()
        {
        }

        override public string ToString()
        {
          return $" Sale # {InventoryNum} Amount: {saleAmount.ToString("C")}  \n tax is {taxAmount.ToString("C")}";
        }

        private double calcMarginalTaxRate(double amount)
        {
            double firstMargin, secondMargin, totalTax;
            firstMargin = 100 * .08 ;
            secondMargin = (amount - 100) * .06;
            totalTax = firstMargin + secondMargin;
            return totalTax;
        }
    }
}
