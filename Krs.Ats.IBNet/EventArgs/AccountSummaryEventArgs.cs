using System;
using System.Collections.Generic;
using System.Text;

namespace Krs.Ats.IBNet
{
    public class AccountSummaryEventArgs : EventArgs
    {
        public int RequestId { get; set; }
        public string Account { get; set; }
        public string Tag { get; set; }
        public string Value { get; set; }
        public string Currency { get; set; }

        public AccountSummaryEventArgs(int requestId, string account, string tag, string value, string currency)
        {
            RequestId = requestId;
            Account = account;
            Tag = tag;
            Value = value;
            Currency = currency;
        }
    }
}
