using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krs.Ats.IBNet
{
    public static class CTriggerMethod
    {
        public static readonly string[] friendlyNames = new string[] { "default", "double bid/ask", "last", "double last", "bid/ask", "", "", "last of bid/ask", "mid-point" };


        public static string ToFriendlyString(this TriggerMethod th)
        {
            return friendlyNames[(int)th];
        }

        public static TriggerMethod FromFriendlyString(string friendlyName)
        {
            return (TriggerMethod)Array.IndexOf(friendlyNames, friendlyName);
        }
    }

    /// <summary>
    /// Used with conditional orders to cancel or submit order based on price of an instrument. 
    /// </summary>
    public class PriceCondition : ContractCondition
    {
        protected override string Value
        {
            get
            {
                return Price.ToString();
            }
            set
            {
                Price = double.Parse(value, NumberFormatInfo.InvariantInfo);
            }
        }

        public override string ToString()
        {
            return TriggerMethod.ToFriendlyString() + " " + base.ToString();
        }

        public double Price { get; set; }
        public TriggerMethod TriggerMethod { get; set; }

        public override void Deserialize(BinaryReader reader)
        {
            base.Deserialize(reader);

            TriggerMethod = (TriggerMethod)reader.ReadInt();
        }

        public override void Serialize(BinaryWriter writer)
        {
            base.Serialize(writer);
            writer.Send((int)TriggerMethod);
        }

        protected override bool TryParse(string cond)
        {
            var fName = CTriggerMethod.friendlyNames.Where(n => cond.StartsWith(n)).OrderByDescending(n => n.Length).FirstOrDefault();

            if (fName == null)
                return false;

            try
            {
                TriggerMethod = CTriggerMethod.FromFriendlyString(fName);
                cond = cond.Substring(cond.IndexOf(fName) + fName.Length + 1);

                return base.TryParse(cond);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
