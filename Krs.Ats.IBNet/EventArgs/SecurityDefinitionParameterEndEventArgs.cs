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
    public class SecurityDefinitionParameterEndEventArgs : EventArgs
    {
        public int ReqId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reqId"></param>
        public SecurityDefinitionParameterEndEventArgs(int reqId)
        {
            ReqId = reqId;
        }
    }
}
