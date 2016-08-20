using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Used with conditional orders to place or submit an order based on a percentage change of an instrument to the last close price.
    /// </summary>
    public class PercentChangeCondition : ContractCondition
    {

        protected override string Value
        {
            get
            {
                return ChangePercent.ToString();
            }
            set
            {
                ChangePercent = double.Parse(value, NumberFormatInfo.InvariantInfo);
            }
        }

        public double ChangePercent { get; set; }
    }
}
