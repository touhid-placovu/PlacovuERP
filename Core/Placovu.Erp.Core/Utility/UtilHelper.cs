using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placovu.Erp.Core.Utility
{
    public static class UtilHelper
    {
        public static decimal RoundTwoDigit(decimal? data)
        {
            decimal value = (decimal)0.00;
            if (data.HasValue)
                value = Math.Round(data.Value, 2);
            return Decimal.Parse(value.ToString("0.00"));
        }
    }
}
