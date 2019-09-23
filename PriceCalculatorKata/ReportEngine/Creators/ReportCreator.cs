using PriceCalculatorKata.Common;
using PriceCalculatorKata.Domain;
using PriceCalculatorKata.ReportEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.ReportEngine.Creators
{
    public abstract class ReportCreator<TRequest>
        where TRequest : ReportRequest
    {
        public ReportCreator(TRequest request)
        {
            this.Request = request;
        }

        protected TRequest Request { get; }

        protected abstract void Setup(IReportBuilder reportBuilder);

        public Report Create()
        {
            var builder = new ReportBuilder()
                .WithTemplateKey(Constants.ReportTemplates.Basic)
                .WithKeyValue(Constants.Placeholders.Name, Request.Product.Name)
                .WithKeyValue(Constants.Placeholders.Upc, Request.Product.Upc)
                .WithKeyValue(Constants.Placeholders.BasePrice, Request.Product.Price);

            var basic = builder.Build();

            Setup(builder);

            var concrete = builder.Build();

            return basic.Append(concrete);
        }

    }
}
