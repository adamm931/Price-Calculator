using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.Domain
{
    public class Product
    {
        public Product(
            string name,
            long upc,
            Price price)
        {
            this.Name = name;
            this.Upc = upc;
            this.Price = price;
        }

        public string Name { get; }

        public long Upc { get; }

        public Price Price { get; }

        public Price TaxAmount(Tax tax)
            => Price.CalculateFrom(tax);

        public Price DiscountAmount(Discount discount)
            => Price.CalculateFrom(discount);

        public override string ToString()
            => $"Name: {Name} Upc: {Upc} Price: {Price}";
    }
}
