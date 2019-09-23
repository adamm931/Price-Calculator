using PriceCalculatorKata.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.ReportEngine
{
    public interface IReportBuilder
    {
        IReportBuilder WithTemplateKey(string key);

        IReportBuilder WithKeyValue(string key, object value);

        Report Build();
    }
}
