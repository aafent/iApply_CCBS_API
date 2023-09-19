using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class UpdateMembershipContractualRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string ApplicationId { get; set; }

        [DataMember]
        public int CustomerCBSId { get; set; }

        [DataMember]
        public int MemberId { get; set; }

        #endregion Public Properties
    }
}