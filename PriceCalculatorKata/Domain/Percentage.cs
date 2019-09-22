using System;

namespace PriceCalculatorKata.Domain
{
    public abstract class Rate
    {
        protected Rate(decimal percentage)
        {
            if (percentage < decimal.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(percentage));
            }

            this.Percentage = percentage;
        }

        public decimal Percentage { get; }

        public override string ToString()
        => $"{Percentage} %";
    }
}