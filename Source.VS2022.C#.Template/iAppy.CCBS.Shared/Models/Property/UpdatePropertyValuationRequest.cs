using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class UpdatePropertyValuationRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string PropertyId { get; set; }

        [DataMember]
        public string TransactionId { get; set; }

        #endregion Public Properties
    }
}