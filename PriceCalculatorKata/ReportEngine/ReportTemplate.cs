using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.ReportEngine
{
    public class ReportTemplate
    {
        public ReportTemplate(string body)
        {
            this.Body = body;
        }

        public string Body { get; }

        public ReportTemplate Replace(string key, object value)
        {
            var content = Body.Replace($"${key}$", value.ToString());
            return new ReportTemplate(content);
        }
    }
}
