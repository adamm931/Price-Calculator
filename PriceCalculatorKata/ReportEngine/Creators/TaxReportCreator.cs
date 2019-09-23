using PriceCalculatorKata.Common;
using PriceCalculatorKata.ReportEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.ReportEngine.Creators
{
    public class TaxReportCreator : ReportCreator<TaxReportRequest>
    {
        public TaxReportCreator(TaxReportRequest request) : base(request)
        {
        }

        protected override void Setup(IReportBuilder reportBuilder)
        {
            var basePrice = Request.Product.Price;
            var tax = Request.Tax;
            var finalPrice = basePrice.ApplyTax(tax);

            reportBuilder
                .WithTemplateKey(Constants.ReportTemplates.Tax)
                .WithKeyValue(Constants.Placeholders.BasePrice, basePrice)
                .WithKeyValue(Constants.Placeholders.TaxRate, tax)
                .WithKeyValue(Constants.Placeholders.FinalPrice, finalPrice);
        }
    }
}
