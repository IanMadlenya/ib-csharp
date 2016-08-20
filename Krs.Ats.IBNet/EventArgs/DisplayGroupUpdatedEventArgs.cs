using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krs.Ats.IBNet
{
    public class DisplayGroupUpdatedEventArgs : EventArgs
    {
        public int ReqId { get; set; }
        public string ContractInfo { get; set; }

        public DisplayGroupUpdatedEventArgs(int reqId, string contractInfo)
        {
            ReqId = reqId;
            ContractInfo = contractInfo;
        }
    }
}
