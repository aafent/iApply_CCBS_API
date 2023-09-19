using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DMSUpdateMemberDocumentByAppNoRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string ApplicationId { get; set; }

        [DataMember]
        public string MemberNo { get; set; }

        #endregion Public Properties
    }
}