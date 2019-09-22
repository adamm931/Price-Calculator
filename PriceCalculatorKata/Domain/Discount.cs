using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.Domain
{
    public class Discount : Rate
    {
        public Discount(decimal rate)
            : base(rate)
        {
        }
    }
}
