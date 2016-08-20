namespace Krs.Ats.IBNet
{
    /// <summary>
    /// API minimum server versions.
    /// </summary>
    public class MinServerVersion
    {
        /// <summary>
        /// RealTimeBars
        /// </summary>
        public const int RealTimeBars = 34;
        /// <summary>
        /// ScaleOrders
        /// </summary>
        public const int ScaleOrders = 35;
        /// <summary>
        /// SnapshotMktData
        /// </summary>
        public const int SnapshotMktData = 35;
        /// <summary>
        /// SshortComboLegs
        /// </summary>
        public const int SshortComboLegs = 35;
        /// <summary>
        /// WhatIfOrders
        /// </summary>
        public const int WhatIfOrders = 36;
        /// <summary>
        /// ContractConId
        /// </summary>
        public const int ContractConId = 37;
        /// <summary>
        /// PtaOrders
        /// </summary>
        public const int PtaOrders = 39;
        /// <summary>
        /// FundamentalData
        /// </summary>
        public const int FundamentalData = 40;
        /// <summary>
        /// UnderComp
        /// </summary>
        public const int UnderComp = 40;
        /// <summary>
        /// ContractDataChain
        /// </summary>
        public const int ContractDataChain = 40;
        /// <summary>
        /// ScaleOrders2
        /// </summary>
        public const int ScaleOrders2 = 40;
        /// <summary>
        /// AlgoOrders
        /// </summary>
        public const int AlgoOrders = 41;
        /// <summary>
        /// ExecutionDataChain
        /// </summary>
        public const int ExecutionDataChain = 42;
        /// <summary>
        /// NotHeld
        /// </summary>
        public const int NotHeld = 44;
        /// <summary>
        /// SecIdType
        /// </summary>
        public const int SecIdType = 45;
        /// <summary>
        /// PlaceOrderConId
        /// </summary>
        public const int PlaceOrderConId = 46;
        /// <summary>
        /// RequestMarketDataConId
        /// </summary>
        public const int RequestMarketDataConId = 47;
        /// <summary>
        /// RequestCalculateImpliedVolatility
        /// </summary>
        public const int RequestCalculateImpliedVolatility = 49;
        /// <summary>
        /// RequestCalculateOptionPrice
        /// </summary>
        public const int RequestCalculateOptionPrice = 50;
        /// <summary>
        /// CancelCalculateImpliedVolatility
        /// </summary>
        public const int CancelCalculateImpliedVolatility = 50;
        /// <summary>
        /// CancelCalculateOptionPrice
        /// </summary>
        public const int CancelCalculateOptionPrice = 50;
        /// <summary>
        /// SshortxOld
        /// </summary>
        public const int SshortxOld = 51;
        /// <summary>
        /// Sshortx
        /// </summary>
        public const int Sshortx = 52;
        /// <summary>
        /// RequestGlobalCancel
        /// </summary>
        public const int RequestGlobalCancel = 53;
        /// <summary>
        /// HedgeOrders
        /// </summary>
        public const int HedgeOrders = 54;
        /// <summary>
        /// RequestMarketDataType
        /// </summary>
        public const int RequestMarketDataType = 55;
        /// <summary>
        /// OptOutSmartRouting
        /// </summary>
        public const int OptOutSmartRouting = 56;
        /// <summary>
        /// SmartComboRoutingParams
        /// </summary>
        public const int SmartComboRoutingParams = 57;
        /// <summary>
        /// DeltaNeutralConId
        /// </summary>
        public const int DeltaNeutralConId = 58;

        /// <summary>
        /// 
        /// </summary>
        public const int ScaleOrders3 = 60;
        /// <summary>
        /// 
        /// </summary>
        public const int OrdercomboLegsPrice = 61;
        /// <summary>
        /// 
        /// </summary>
        public const int TrailingPercent = 62;
        public const int DeltaNeutralOpenClose = 66;
        public const int AcctSummary = 67;
        public const int TradingClass = 68;
        public const int ScaleTable = 69;
        public const int Linking = 70;
        public const int AlgoID = 71;
        public const int OptionalCapabilities = 72;
        public const int OrderSolicited = 73;
        public const int LinkingAuth = 74; //NOT IMPLEMENTED - it's for verifyAndAuthRequest and verifyAndAuthMessage
        public const int Primaryexch = 75;
        public const int RandomizeSizeAndPrice = 76;
        public const int FractionalPositions = 101;
        public const int PeggedToBenchmark = 102;
        public const int ModelsSupport = 103;
        public const int SecDefOptParamsReq = 104;
        public const int ExtOperator = 105;
    }
}