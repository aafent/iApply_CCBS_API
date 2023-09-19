using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class InsertDepositAccountResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public short? AccountCd { get; set; }

        [DataMember]
        public string AccountNumber { get; set; }

        [DataMember]
        public string Status { get; set; }

        #endregion Public Properties
    }
}