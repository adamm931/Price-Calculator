using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.ReportEngine.Expcetions
{
    public class ReportTemplateNotFoundException : Exception
    {
        public ReportTemplateNotFoundException() : base()
        { 
        }

        public ReportTemplateNotFoundException(string message) : base(message)
        {
        }
    }
}
