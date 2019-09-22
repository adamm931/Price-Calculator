using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.Domain
{
    public class Currency
    {
        private const string Dollar = "$";
        private const string Euro = "E";

        public static readonly Currency USD = new Currency(Dollar);
        public static readonly Currency Eur = new Currency(Euro);

        private Currency(string symbol)
        {
            this.Symbol = symbol;
        }

        public static Currency From(Currency currenncy)
        {
            return new Currency(currenncy.Symbol);
        }

        public string Symbol { get; }

        public override string ToString()
            => $"{this.Symbol}";
    }
}
