using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveDepositAccountRequest : BaseRequest
    {
        #region Public Properties

        [DataMember(IsRequired = true)]
        public short? AccountCd { get; set; }

        [DataMember(IsRequired = true)]
        public string AccountNumber { get; set; }

        [DataMember]
        public int? CustomerCustId { get; set; }

        #endregion Public Properties
    }
}