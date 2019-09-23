using PriceCalculatorKata.Domain;
using PriceCalculatorKata.Interfaces;
using PriceCalculatorKata.Presentation;
using PriceCalculatorKata.ReportEngine.Creators;
using PriceCalculatorKata.ReportEngine.Models;
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

            var request = new TaxReportRequest
            {
                Product = product,
                Tax = tax
            };

            var taxReportCreator = new TaxReportCreator(request);

            DisplayResults(taxReportCreator, "Sprint 1");

            // DisplayResults(null, "Sprint 2");

            Console.ReadLine();
        }

        private static void DisplayResults<T>(ReportCreator<T> reportCreator, string title)
            where T : ReportRequest
        {
            var content = reportCreator.Create().Content;
            ConsoleHelper.DisplayResults(content, title);

        }
    }
}
