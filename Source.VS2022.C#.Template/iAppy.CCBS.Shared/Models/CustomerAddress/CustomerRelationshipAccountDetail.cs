using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CustomerRelationshipAccountDetail
    {
        #region Public Properties

        [DataMemberAttribute]
        public short AccountCd { get; set; }

        [DataMemberAttribute]
        public string AccountNumber { get; set; }

        [DataMemberAttribute]
        public short RelAccountType { get; set; }

        #endregion Public Properties
    }
}