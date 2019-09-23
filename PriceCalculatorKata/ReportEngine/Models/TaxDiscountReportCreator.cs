using PriceCalculatorKata.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.ReportEngine.Models
{
    public class TaxDiscountReportRequest : TaxReportRequest
    {
        public Discount Discount { get; set; }
    }
}
