using PriceCalculatorKata.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.Domain
{
    public class Price
    {
        public Price(Amount amount, Currency currency)
        {
            if (amount == null)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            this.Amount = amount;

            if (currency == null)
            {
                throw new ArgumentNullException(nameof(currency));
            }

            this.Currency = currency;
        }

        public Amount Amount { get; }

        public Currency Currency { get; }

        public Price ApplyTax(Tax tax)
            => new Price(Amount.ApplyTax(tax), Currency);

        public Price ApplyDiscount(Discount discount)
            => new Price(Amount.ApplyDiscount(discount), Currency);

        public Price CalculateFrom(Rate percentage)
            => new Price(Amount.CalculateFrom(percentage), Currency);

        public static Price operator -(Price left, Price right)
        {
            return new Price(left.Amount - right.Amount, left.Currency);
        }

        public override string ToString()
            => $"{Currency}{Amount}";
    }
}
