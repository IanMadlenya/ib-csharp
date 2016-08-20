using System;
using System.Collections.Generic;
using System.Text;

namespace Krs.Ats.IBNet
{
    public class AccountSummaryEndEventArgs : EventArgs
    {
        public int RequestId { get; set; }

        public AccountSummaryEndEventArgs(int requestId)
        {
            RequestId = requestId;
        }
    }
}
