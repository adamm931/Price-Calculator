using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCalculatorKata.Domain;
using PriceCalculatorKata.Interfaces;

namespace PriceCalculatorKata.Service
{
    public class PriceWithTaxReporter : IReporter
    {
        public PriceWithTaxReporter(Product product, Tax tax)
        {
            this.Product = product;
            this.Tax = tax;
        }

        public Product Product { get; }

        public Tax Tax { get; }

        public Report GetReport()
        {
            var basePrice = Product.Price;
            var priceWithTax = basePrice.ApplyTax(Tax);

            var report =
                $"Product price reported as {basePrice} before tax" 
                + $" and {priceWithTax} after {Tax} tax.";
           
            return new Report(report);
        }
    }
}
