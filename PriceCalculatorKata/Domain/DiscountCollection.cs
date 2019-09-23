using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.Domain
{
    public class DiscountCollection
    {
        public DiscountCollection(IEnumerable<Discount> discounts, Amount cap, bool isRate)
        {
            this.Discounts = discounts;
            this.Cap = cap;
            this.IsRate = isRate;
        }

        public Amount Cap { get; }

        public IEnumerable<Discount> Discounts { get; }

        public bool IsRate { get; }
    }
}
