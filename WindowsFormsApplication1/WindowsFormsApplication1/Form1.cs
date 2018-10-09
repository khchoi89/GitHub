using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //Using global variable for counting list of objects in the list box.
        public double salesTaxedItemPrice = 0;
        public double finalPriceBeforeTax = 0;
        public double importedItemTotal = 0;
        public double saleTaxExemptedItemTotal = 0;


        List<string> importItem = new List<string>();
        List<double> importItemPrice = new List<double>();

        List<string> taxExemptedItem = new List<string>();
        List<double> taxExemptedItemPrice = new List<double>();

        List<string> salesTaxItem = new List<string>();
        List<double> salesTaxItemPrice = new List<double>();

        public string importedItem = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method will calculate the total without any taxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {      
            double price = 0;
            price = double.Parse(priceTextbox.Text);
            itemListbox.Items.Add(itemTextbox.Text);
            priceListbox.Items.Add(price);

            //// It will check if anything is checked in the checkbox list.
            //// If it does then it will add total to different variables.
            //// It will store name of item and price into the collection (global variable), for later use.
            if(taxExemptedItemCheckbox.Checked== true)
            {
                taxExemptedItem.Add(itemTextbox.Text);
                taxExemptedItemPrice.Add(price);
                saleTaxExemptedItemTotal = saleTaxExemptedItemTotal + price;
            }
            else if(ImportedCheckbox.Checked == true)
            {
                importItem.Add(itemTextbox.Text);
                importItemPrice.Add(price);
                importedItemTotal = importedItemTotal + price;
            }
            else
            {
                salesTaxItem.Add(itemTextbox.Text);
                salesTaxItemPrice.Add(price);
                salesTaxedItemPrice = salesTaxedItemPrice + price;
            }    

            finalPriceBeforeTax = salesTaxedItemPrice + importedItemTotal;

            itemTextbox.Clear();
            priceTextbox.Clear();

            Console.WriteLine("Sales tax exempted item total price: " + saleTaxExemptedItemTotal);
            Console.WriteLine("Import item total price: " + importedItemTotal);
            Console.WriteLine("Total price for taxed item: " + salesTaxedItemPrice);
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            TaxCalculator calculator = new TaxCalculator();

            foreach (string item in taxExemptedItem)
            {
                receiptListbox.Items.Add(item);
            }
            foreach (double price in taxExemptedItemPrice)
            {
                receiptPriceListbox.Items.Add(price);
            }
            foreach (string item in importItem)
            {
                receiptListbox.Items.Add("Imported " + item);
            }

            foreach (double importPrice in importItemPrice)
            {
                receiptPriceListbox.Items.Add(calculator.ImportTaxCalculator(importPrice));
            }
            foreach (string item in salesTaxItem)
            {
                receiptListbox.Items.Add(item);
            }
            foreach (double price in salesTaxItemPrice)
            {
                receiptPriceListbox.Items.Add(price);
            }

            double salesTax = finalPriceBeforeTax * 0.1;
            double salesTaxConvert = Math.Round((Double)salesTax, 2);
            Console.WriteLine("Sales tax: " + salesTaxConvert);
            receiptListbox.Items.Add("Sales tax: ");
            receiptPriceListbox.Items.Add(salesTaxConvert);

            double totalAmount = salesTaxConvert + finalPriceBeforeTax + saleTaxExemptedItemTotal;
            double totalAmountConvert = Math.Round((Double)totalAmount, 2);
            Console.WriteLine("Total : " + totalAmountConvert);
            receiptListbox.Items.Add("Total : ");
            receiptPriceListbox.Items.Add(totalAmountConvert);

        }

        /// <summary>
        /// Clears the values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            salesTaxedItemPrice = 0;
            finalPriceBeforeTax = 0;
            importedItemTotal = 0;
            saleTaxExemptedItemTotal = 0;

            itemTextbox.Clear();
            priceTextbox.Clear();
            itemListbox.Items.Clear();
            priceListbox.Items.Clear();
            receiptListbox.Items.Clear();
            receiptPriceListbox.Items.Clear();
        }
    }
}
