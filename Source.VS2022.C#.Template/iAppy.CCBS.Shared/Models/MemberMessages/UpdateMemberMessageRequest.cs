using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class UpdateMemberMessageRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public int CBSSN { get; set; }

        [DataMember]
        public string CustomerId { get; set; }

        [DataMember]
        public int MessageSN { get; set; }

        #endregion Public Properties
    }
}