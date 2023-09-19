using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CreateMemberMessageRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string CustomerCBSId { get; set; }

        [DataMember]
        public string CustomerId { get; set; }

        [DataMember]
        public int MessageSN { get; set; }

        [DataMember]
        public string User { get; set; }

        #endregion Public Properties
    }
}