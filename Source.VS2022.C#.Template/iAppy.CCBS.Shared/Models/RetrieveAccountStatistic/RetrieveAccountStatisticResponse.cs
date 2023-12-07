using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveAccountStatisticResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public List<ChequeItem> ChequeItems { get; set; } = new();

        [DataMember]
        public List<LimitItem> LimitItems { get; set; } = new();

        [DataMember]
        public List<ResponseList> ResponseItems { get; set; } = new();

        #endregion Public Properties
    }
}