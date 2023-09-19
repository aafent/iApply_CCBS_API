using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class UpdateCreditLineRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public int CustomerCBSId { get; set; }

        [DataMember]
        public int CustomerCheckDigit { get; set; }

        [DataMember]
        public string CustomerID { get; set; }

        [DataMember]
        public int RowIndex { get; set; }

        #endregion Public Properties
    }
}