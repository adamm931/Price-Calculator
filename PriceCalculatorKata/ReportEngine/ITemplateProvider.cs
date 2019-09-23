using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.ReportEngine
{
    public interface ITemplateProvider
    {
        ReportTemplate GetTemplate(string key);
    }
}
