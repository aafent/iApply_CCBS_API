using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveMemberMessageRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string CustomerCBSId { get; set; }

        #endregion Public Properties
    }
}