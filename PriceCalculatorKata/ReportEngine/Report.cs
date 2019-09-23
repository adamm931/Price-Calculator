using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.ReportEngine
{
    public class Report
    {
        public Report(string content)
        {
            this.Content = content;
        }

        public string Content { get; }

        public Report Append(Report report)
        {
            var builder = new StringBuilder();
            builder.AppendLine(Content);
            builder.AppendLine(report.Content);

            var value = builder.ToString();

            return new Report(value);
        }
    }
}
