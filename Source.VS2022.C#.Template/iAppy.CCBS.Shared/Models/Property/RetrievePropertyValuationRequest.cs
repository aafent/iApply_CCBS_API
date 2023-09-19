using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrievePropertyValuationRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string PropertyId { get; set; }

        #endregion Public Properties
    }
}