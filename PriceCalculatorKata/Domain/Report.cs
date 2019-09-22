using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.Domain
{
    public class Report
    {
        public Report(string content)
        {
            this.Content = content;
        }

        public string Content { get; }
    }
}
