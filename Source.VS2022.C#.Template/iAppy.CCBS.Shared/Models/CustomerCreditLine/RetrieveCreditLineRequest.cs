using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveCreditLineRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public int CustomerCBSId { get; set; }

        [DataMember]
        public short CustomerCheckDigit { get; set; }

        [DataMember]
        public string CustomerID { get; set; }

        #endregion Public Properties
    }
}