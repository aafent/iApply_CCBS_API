using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveAccountStatisticResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public ChequeItem[] ChequeItems { get; set; }

        [DataMember]
        public LimitItem[] LimitItems { get; set; }

        [DataMember]
        public ResponseList[] ResponseItems { get; set; }

        #endregion Public Properties
    }
}