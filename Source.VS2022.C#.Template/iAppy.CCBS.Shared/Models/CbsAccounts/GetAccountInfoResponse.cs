using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetAccountInfoResponse : BaseResponse
    {
        #region Public Properties

        [DataMemberAttribute]
        public decimal AccountAvailableAmount { get; set; }

        [DataMemberAttribute]
        public int AccountCd { get; set; }

        [DataMemberAttribute]
        public decimal AccountLimitAmount { get; set; }

        [DataMemberAttribute]
        public string AccountNumber { get; set; }

        [DataMemberAttribute]
        public decimal AccountUtilizedAmount { get; set; }

        #endregion Public Properties
    }
}