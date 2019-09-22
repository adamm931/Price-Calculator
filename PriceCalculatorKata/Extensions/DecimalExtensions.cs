using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.Extensions
{
    public static class DecimalExtensions
    {
        public static decimal Round(this decimal input, int precision = 2)
        {
            return Math.Round(input, precision);
        }
    }
}
