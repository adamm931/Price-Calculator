using PriceCalculatorKata.ReportEngine.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.ReportEngine
{
    public class ReportBuilder : IReportBuilder
    {
        private IDictionary<string, object> Data = new Dictionary<string, object>();
        private string TemplateKey;

        public Report Build()
        {
            if (string.IsNullOrEmpty(TemplateKey))
            {
                throw new TemplateKeyNotDefinedException();
            }

            var template = new TemplateProvider().GetTemplate(TemplateKey);

            foreach(var entry in Data)
            {
                template = template.Replace(entry.Key, entry.Value);
            }

            Reset();

            return new Report(template.Body);
        }
   
        public IReportBuilder WithKeyValue(string key, object value)
        {
            Data[key] = value;
            return this;
        }

        public IReportBuilder WithTemplateKey(string key)
        {
            TemplateKey = key;
            return this;
        }

        private void Reset()
        {
            Data = new Dictionary<string, object>();
            TemplateKey = string.Empty;
        }
    }
}
