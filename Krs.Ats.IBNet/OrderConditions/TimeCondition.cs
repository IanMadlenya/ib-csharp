using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Time condition used in conditional orders to submit or cancel orders at specified time. 
    /// </summary>
    public class TimeCondition : OperatorCondition
    {
        const string header = "time";

        protected override string Value
        {
            get
            {
                return Time;
            }
            set
            {
                Time = value;
            }
        }

        public override string ToString()
        {
            return header + base.ToString();
        }

        /// <summary>
        /// Time field used in conditional order logic.
        /// </summary>
        public string Time { get; set; }

        protected override bool TryParse(string cond)
        {
            if (!cond.StartsWith(header))
                return false;

            cond = cond.Replace(header, "");
            return base.TryParse(cond);
        }
    }
}
