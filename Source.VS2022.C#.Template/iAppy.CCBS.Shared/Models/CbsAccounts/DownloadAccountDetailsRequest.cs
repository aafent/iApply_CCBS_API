using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DownloadAccountDetailsRequest : BaseRequest
    {
        #region Public Properties

        [DataMember(IsRequired = true)]
        public short AccountCd { get; set; }

        [DataMember(IsRequired = true)]
        public string AccountNumber { get; set; }

        [DataMember(IsRequired = true)]
        public short AccountType { get; set; }

        [DataMember(IsRequired = true)]
        public string CustomerId { get; set; }

        #endregion Public Properties
    }
}