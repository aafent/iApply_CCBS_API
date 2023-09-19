using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveRepaymentModeRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string Account { get; set; }

        [DataMember]
        public int? AccountCd { get; set; }

        [DataMember]
        public string CustomerCBSId { get; set; }

        [DataMember]
        public string ProductId { get; set; }

        #endregion Public Properties
    }
}