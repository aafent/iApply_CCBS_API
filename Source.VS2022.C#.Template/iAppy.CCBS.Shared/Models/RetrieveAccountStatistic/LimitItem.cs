using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class LimitItem
    {
        #region Public Properties

        [DataMember]
        public int AccountCd { get; set; }

        [DataMember]
        public string AccountNo { get; set; }

        [DataMember]
        public decimal OverLimitAmt { get; set; }

        #endregion Public Properties
    }
}