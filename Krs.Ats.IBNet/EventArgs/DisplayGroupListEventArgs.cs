using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krs.Ats.IBNet
{
    public class DisplayGroupListEventArgs : EventArgs
    {
        public int ReqId { get; set; }
        public string Groups { get; set; }

        public DisplayGroupListEventArgs(int reqId, string groups)
        {
            ReqId = reqId;
            Groups = groups;
        }
    }
}
