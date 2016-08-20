using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// This class represents a condition requiring the margin cushion reaching a given percent to be fulfilled.
    /// Orders can be activated or canceled if a set of given conditions is met. A MarginCondition is met whenever the margin penetrates the given percent.
    /// </summary>
    public class MarginCondition : OperatorCondition
    {
        const string header = "the margin cushion percent";

        protected override string Value
        {
            get
            {
                return Percent.ToString();
            }
            set
            {
                Percent = int.Parse(value);
            }
        }

        public override string ToString()
        {
            return header + base.ToString();
        }

        /// <summary>
        /// Margin percent to trigger condition.
        /// </summary>
        public int Percent { get; set; }

        protected override bool TryParse(string cond)
        {
            if (!cond.StartsWith(header))
                return false;

            cond = cond.Replace(header, "");

            return base.TryParse(cond);
        }
    }
}
