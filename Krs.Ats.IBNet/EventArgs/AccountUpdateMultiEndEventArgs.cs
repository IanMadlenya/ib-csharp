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
    public class AccountUpdateMultiEndEventArgs : EventArgs
    {
        public int RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestId"></param>
        public AccountUpdateMultiEndEventArgs(int requestId)
        {
            RequestId = requestId;
        }
    }
}
