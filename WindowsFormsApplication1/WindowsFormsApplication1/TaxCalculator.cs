using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class TaxCalculator
    {

        /// <summary>
        /// This will calculate sales tax.
        /// </summary>
        /// <param name="totalAmount"></param>
        /// <returns>
        /// This will return final price include sales tax
        /// </returns>
        public double SalesTaxCalculator(double totalAmount, string item)
        {
            double salesTax = 0;
            double priceWithSalesTax = 0;
            try
            {
                salesTax = totalAmount * 0.1;
                priceWithSalesTax = totalAmount + salesTax;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            return priceWithSalesTax;           

        }

        /// <summary>
        /// This method will calculate sales tax exempted price.
        /// </summary>
        /// <param name="totalAmount"></param>
        /// <param name="salesTaxExempted"></param>
        /// <param name="item"></param>
        /// <returns> This will return total amount with sales tax exempted price.</returns>
        public double SalesTaxExemption(double totalAmount, bool salesTaxExempted, string item)
        {
            try
            {
                if (salesTaxExempted != true)
                {
                    SalesTaxCalculator(totalAmount, item);
                }
                return totalAmount;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return totalAmount;
        }

        /// <summary>
        /// This will calculate import tax.
        /// </summary>
        /// <param name="totalAmount"></param>
        /// <returns>This will return total price with import tax.</returns>
        public double ImportTaxCalculator(double totalAmount)
        {
            double imporTax = 0;
            double priceWithImportTax = 0;
            try
            {
                imporTax = totalAmount * 0.05;
                priceWithImportTax = imporTax + totalAmount;
                return priceWithImportTax;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return priceWithImportTax;
        }
    }
}
