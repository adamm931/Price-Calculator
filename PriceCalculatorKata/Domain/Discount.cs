using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.Domain
{
    public class Discount : Rate
    {
        private const int UpcNoValue = -1;

        public Discount(decimal rate)
            : base(rate)
        {
        }

        public Discount(decimal rate, bool isAppliedAfterTax)
            : base(rate)
        {
            IsAppliedAfterTax = isAppliedAfterTax;
        }

        private Discount(long appliesForUpc, bool isAppliedAfterTax, decimal rate)
            : this(rate, isAppliedAfterTax)
        {
            this.AppliesForUpc = appliesForUpc;
        }

        public long AppliesForUpc { get; private set; } = UpcNoValue;

        public bool IsAppliedAfterTax { get; }

        public Discount ForUpc(long upc)
        {
            return new Discount(upc, IsAppliedAfterTax, Percentage);
        }

        public bool IsUpcDefined()
        {
            return AppliesForUpc != UpcNoValue;
        }
    }
}
