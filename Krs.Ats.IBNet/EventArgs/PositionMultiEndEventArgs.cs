using System;
using System.Collections.Generic;
using System.Text;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// 
    /// </summary>
    public class PositionMultiEndEventArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestId"></param>
        public PositionMultiEndEventArgs(int requestId)
        {
            RequestId = requestId;
        }
    }
}
