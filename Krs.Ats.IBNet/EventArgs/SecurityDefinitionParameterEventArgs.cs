using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// 
    /// </summary>
    public class SecurityDefinitionParameterEventArgs : EventArgs
    {
        public string Exchange { get; set; }
        private List<string> Expirations { get; set; }
        private string Multiplier { get; set; }
        private int ReqId { get; set; }
        private List<double> Strikes { get; set; }
        private string TradingClass { get; set; }
        private int UnderlyingConId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reqId"></param>
        /// <param name="exchange"></param>
        /// <param name="underlyingConId"></param>
        /// <param name="tradingClass"></param>
        /// <param name="multiplier"></param>
        /// <param name="expirations"></param>
        /// <param name="strikes"></param>
        public SecurityDefinitionParameterEventArgs(int reqId, string exchange, int underlyingConId, string tradingClass, string multiplier, List<string> expirations, List<double> strikes)
        {
            ReqId = reqId;
            Exchange = exchange;
            UnderlyingConId = underlyingConId;
            TradingClass = tradingClass;
            Multiplier = multiplier;
            Expirations = expirations;
            Strikes = strikes;
        }
    }
}
