using PriceCalculatorKata.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.ReportEngine.Models
{
    public abstract class ReportRequest
    {
        public Product Product { get; set; }
    }
}
