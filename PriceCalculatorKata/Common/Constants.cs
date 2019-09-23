using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.Common
{
    public class Constants
    {
        /// <summary>
        /// Defines the keys for report template which are place in App.config
        /// </summary>
        public class ReportTemplates
        {
            /// <summary>
            /// Placeholder are:
            /// Placeholder can be found in <see cref="Constants.Placeholders"/> 
            /// <para></para>
            /// <para> - Name </para>
            /// <para> - Upc </para>
            /// <para> - BasePrice </para>
            /// </summary>
            public const string Basic = "ReportTemplate:Basic";

            /// <summary>
            /// Placeholder can be found in <see cref="Constants.Placeholders"/> 
            /// <para></para>
            /// Placeholder are:
            /// <para> - FinalPrice </para>
            /// <para> - BasePrice </para>
            /// <para> - TaxRate </para>
            /// </summary>
            public const string Tax = "ReportTemplate:Tax";

            /// <summary>
            /// Placeholder are:
            /// <para> - Name </para>
            /// <para> - Upc </para>
            /// <para> - BasePrice </para>
            /// </summary>
            public const string TaxAndDiscount = "ReportTemplate:Tax.Discount";
        }

        public class Placeholders
        {
            public const string Name = "name";
            public const string Upc = "upc";
            public const string BasePrice = "basePrice";
            public const string FinalPrice = "finalPrice";
            public const string TaxAmount = "taxAmount";
            public const string TaxRate = "taxRate";
            public const string DiscountAmount = "discountAmount";
            public const string DiscountRata = "discountRate";
        }
    }
}
