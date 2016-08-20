using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// This class represents a condition requiring a specific execution event to be fulfilled.
    /// Orders can be activated or canceled if a set of given conditions is met. An ExecutionCondition is met whenever a trade occurs on a certain product at the given exchange.
    /// </summary>
    public class ExecutionCondition : OrderCondition
    {
        /// <summary>
        /// Exchange where the symbol needs to be traded.
        /// </summary>
        public string Exchange { get; set; }

        /// <summary>
        /// Kind of instrument being monitored.
        /// </summary>
        public string SecType { get; set; }

        /// <summary>
        /// Instrument's symbol
        /// </summary>
        public string Symbol { get; set; }

        const string header = "trade occurs for ",
                     symbolSuffix = " symbol on ",
                     exchangeSuffix = " exchange for ",
                     secTypeSuffix = " security type";

        public override string ToString()
        {
            return header + Symbol + symbolSuffix + Exchange + exchangeSuffix + SecType + secTypeSuffix;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cond"></param>
        /// <returns></returns>
        protected override bool TryParse(string cond)
        {
            if (!cond.StartsWith(header))
                return false;

            try
            {
                var parser = new StringSuffixParser(cond.Replace(header, ""));

                Symbol = parser.GetNextSuffixedValue(symbolSuffix);
                Exchange = parser.GetNextSuffixedValue(exchangeSuffix);
                SecType = parser.GetNextSuffixedValue(secTypeSuffix);

                if (!string.IsNullOrWhiteSpace(parser.Rest))
                    return base.TryParse(parser.Rest);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public override void Deserialize(BinaryReader reader)
        {
            base.Deserialize(reader);

            SecType = reader.ReadStr();
            Exchange = reader.ReadStr();
            Symbol = reader.ReadStr();
        }

        public override void Serialize(BinaryWriter outStream)
        {
            base.Serialize(outStream);

            outStream.Send(SecType);
            outStream.Send(Exchange);
            outStream.Send(Symbol);
        }
    }
}
