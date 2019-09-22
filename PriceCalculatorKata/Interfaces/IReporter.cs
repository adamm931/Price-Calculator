using PriceCalculatorKata.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata.Interfaces
{
    public interface IReporter
    {
        Report GetReport();
    }
}
