using System;
using System.Collections.Generic;
using System.Text;

namespace Krs.Ats.IBNet
{
    public class PositionEventArgs : EventArgs
    {
        public string Account { get; set; }
        public Contract Contract { get; set; }
        public double AvgCost { get; set; }
        public double Quantity { get; set; }

        public PositionEventArgs(string account, Contract contract, double pos, double avgCost)
        {
            Account = account;
            Contract = contract;
            AvgCost = avgCost;
            Quantity = pos;
        }
    }
}
