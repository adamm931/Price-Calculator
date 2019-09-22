using PriceCalculatorKata.Domain;
using PriceCalculatorKata.Interfaces;
using PriceCalculatorKata.Presentation;
using PriceCalculatorKata.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    class Program
    {
        static void Main(string[] args)
        {
            // This can be place in method
            var tax = new Tax(20);
            var amount = new Amount(20.25m);
            var currency = Currency.USD;
            var discount = new Discount(15);
            var price = new Price(amount, currency);
            var product = new Product("The Little Prince", 12345, price);
            //

            Sprint1_Tax();
            Sprint2_Discount();
            Sprint3_Report();

            Console.ReadLine();
        }

        private static void Sprint1_Tax()
        {
            // This can be place in method
            var tax = new Tax(20);
            var amount = new Amount(20.25m);
            var currency = Currency.USD;
            var discount = new Discount(15);
            var price = new Price(amount, currency);
            var product = new Product("The Little Prince", 12345, price);
            //

            var reporter = new PriceWithTaxReporter(product, tax);
            var report = reporter.GetReport();

            ConsoleHelper.DisplayResults(report.Content, "Sprint 1. (TAX)");
        }

        private static void Sprint2_Discount()
        {
            ConsoleHelper.DisplayResults("Spirnt 2 result here...", "Sprint 2");
        }

        private static void Sprint3_Report()
        {
            ConsoleHelper.DisplayResults("Spirnt 2 result here...", "Sprint 3");
        }
    }
}
