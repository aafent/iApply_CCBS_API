using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveAllPropertiesRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public int? PropertyCBSId { get; set; }

        #endregion Public Properties
    }
}