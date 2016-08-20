using System;
using System.Collections.Generic;
using System.Text;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// 
    /// </summary>
    public class PositionMultiEventArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public int RequestId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ModelCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Contract Contract { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Pos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double AvgCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="account"></param>
        /// <param name="modelCode"></param>
        /// <param name="contract"></param>
        /// <param name="pos"></param>
        /// <param name="avgCost"></param>
        public PositionMultiEventArgs(int requestId, string account, string modelCode, Contract contract, double pos, double avgCost)
        {
            RequestId = requestId;
            Account = account;
            ModelCode = modelCode;
            Contract = contract;
            Pos = pos;
            AvgCost = avgCost;
        }
    }
}
