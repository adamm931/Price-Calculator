using PriceCalculatorKata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCalculatorKata.Domain;

namespace PriceCalculatorKata.Service
{
    public class PriceWithTaxAndDiscount : IReporter
    {
        public PriceWithTaxAndDiscount(Product product)
        {

        }

        public Product Product { get; }

        public Tax Tax { get; }

        public Discount Discount { get; }

        public Report GetReport()
        {
            var basePrice = Product.Price;
            var priceWithTax = basePrice.ApplyTax(Tax);
            var discountAmount = basePrice.CalculateFrom(Discount);
            var finalPrice = priceWithTax - discountAmount;

            var report =
                $"Sample product >> {Product}" + Environment.NewLine
                + $"Product price reported as {basePrice} before tax"
                + $" and {priceWithTax} after {Tax} tax";

            return new Report(report);
        }
    }
}
