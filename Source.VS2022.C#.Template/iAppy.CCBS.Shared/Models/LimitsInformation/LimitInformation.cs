using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    public class LimitInformation
    {
        #region Public Properties

        [DataMember]
        public string AccountAccountNumber { get; set; }

        [DataMember]
        public double LimitActiveAccCnt { get; set; }

        [DataMember]
        public decimal LimitCoveredAmn { get; set; }

        [DataMember]
        public string LimitEntityKey { get; set; }

        [DataMember]
        public string LimitEntityKeyDesc { get; set; }

        [DataMember]
        public DateTime LimitExpireDate { get; set; }

        [DataMember]
        public double LimitId { get; set; }

        [DataMember]
        public decimal LimitLimitAmn { get; set; }

        [DataMember]
        public double LimitMaxAccNo { get; set; }

        [DataMember]
        public decimal LimitUsedCoveredAmn { get; set; }

        [DataMember]
        public decimal LimitUsedLimitAmn { get; set; }

        [DataMember]
        public decimal SuppliedAmount { get; set; }

        #endregion Public Properties
    }
}