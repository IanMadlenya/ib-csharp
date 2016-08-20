using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krs.Ats.IBNet
{
    public class AccountUpdateMultiEventArgs : EventArgs
    {
        public int RequestId { get; set; }
        public string Account { get; set; }
        public string ModelCode { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Currency { get; set; }

        public AccountUpdateMultiEventArgs(int requestId, string account, string modelCode, string key, string value, string currency)
        {
            RequestId = requestId;
            Account = account;
            ModelCode = modelCode;
            Key = key;
            Value = value;
            Currency = currency;
        }
    }
}
