using Krs.Ats.IBNet.Enums;
using System;
using System.IO;
using System.Linq;

namespace Krs.Ats.IBNet
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public abstract class OrderCondition
    {
        public OrderConditionType Type { get; private set; }
        public bool IsConjunctionConnection { get; set; }

        public static OrderCondition Create(OrderConditionType type)
        {
            OrderCondition rval = null;

            switch (type)
            {
                case OrderConditionType.Execution:
                    rval = new ExecutionCondition();
                    break;

                case OrderConditionType.Margin:
                    rval = new MarginCondition();
                    break;

                case OrderConditionType.PercentCange:
                    rval = new PercentChangeCondition();
                    break;

                case OrderConditionType.Price:
                    rval = new PriceCondition();
                    break;

                case OrderConditionType.Time:
                    rval = new TimeCondition();
                    break;

                case OrderConditionType.Volume:
                    rval = new VolumeCondition();
                    break;
            }

            if (rval != null)
                rval.Type = type;

            return rval;
        }

        public virtual void Serialize(BinaryWriter writer)
        {
            writer.Send(IsConjunctionConnection ? "a" : "o");
        }

        public virtual void Deserialize(BinaryReader reader)
        {
            IsConjunctionConnection = reader.ReadStr() == "a";
        }

        virtual protected bool TryParse(string cond)
        {
            IsConjunctionConnection = cond == " and";

            return IsConjunctionConnection || cond == " or";
        }

        public static OrderCondition Parse(string cond)
        {
            var conditions = Enum.GetValues(typeof(OrderConditionType)).OfType<OrderConditionType>().Select(Create).ToList();

            return conditions.FirstOrDefault(c => c.TryParse(cond));
        }
    }

    internal class StringSuffixParser
    {
        private string str;

        public StringSuffixParser(string str)
        {
            this.str = str;
        }

        private string SkipSuffix(string prefix)
        {
            return str.Substring(str.IndexOf(prefix) + prefix.Length);
        }

        public string GetNextSuffixedValue(string prefix)
        {
            var rval = str.Substring(0, str.IndexOf(prefix));
            str = SkipSuffix(prefix);

            return rval;
        }

        public string Rest => str;
    }
}