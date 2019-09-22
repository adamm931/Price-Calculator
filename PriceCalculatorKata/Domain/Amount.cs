using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.Domain
{
    public class Amount
    {
        public Amount(decimal value)
        {
            this.Value = value;
        }

        public decimal Value { get; }

        public Amount ApplyTax(Tax tax)
        {
            var newAmount = this + CalculateFrom(tax);
            return newAmount;
        }

        public Amount ApplyDiscount(Discount discount)
        {
            var newAmount = this - CalculateFrom(discount);
            return newAmount;
        }

        public Amount CalculateFrom(Rate percentage)
        {
            return new Amount(this.Value * percentage.Percentage / 100);
        }

        public static Amount operator -(Amount left, Amount right)
        {
            return new Amount(left.Value - right.Value);
        }

        public static Amount operator +(Amount left, Amount right)
        {
            return new Amount(left.Value + right.Value);
        }

        public override string ToString()
        {
            return $"{this.Value}";
        }
    }
}
