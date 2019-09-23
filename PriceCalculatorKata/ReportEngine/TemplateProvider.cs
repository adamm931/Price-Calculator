using PriceCalculatorKata.ReportEngine.Expcetions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.ReportEngine
{
    public class TemplateProvider : ITemplateProvider
    {
        public ReportTemplate GetTemplate(string key)
        {
            var value = ConfigurationManager.AppSettings[key];

            if(value == null)
            {
                throw new ReportTemplateNotFoundException(key);
            }

            return new ReportTemplate(value);
        }
    }
}
