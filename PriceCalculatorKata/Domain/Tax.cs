using PriceCalculatorKata.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.Domain
{
    public class Tax : Rate
    {
        public Tax(decimal percentage)
            : base(percentage)
        { }
    }
}
