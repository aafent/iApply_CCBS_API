using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveAccountStatisticRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public short AccountCd { get; set; }

        [DataMember]
        public string AccountNumber { get; set; }

        [DataMember]
        public short CBSCheckdigit { get; set; }

        [DataMember]
        public int CBSId { get; set; }

        [DataMember]
        public DateTime DateFrom { get; set; }

        [DataMember]
        public DateTime DateTo { get; set; }

        #endregion Public Properties
    }
}