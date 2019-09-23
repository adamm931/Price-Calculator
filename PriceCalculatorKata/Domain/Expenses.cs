using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.Domain
{
    public class Expenses
    {
        public string Name { get; }

        public Amount Amount { get; }

        public bool IsRate { get; }

        private Expenses(string name, Amount amount, bool isRate)
        {
            this.Name = name;
            this.Amount = amount;
            this.IsRate = isRate;
        }

        public static Expenses AsRate(string name, Amount amount)
        {
            return new Expenses(name, amount, true);
        }

        public static Expenses AsFlat(string name, Amount amount)
        {
            return new Expenses(name, amount, false);
        }
    }
}
