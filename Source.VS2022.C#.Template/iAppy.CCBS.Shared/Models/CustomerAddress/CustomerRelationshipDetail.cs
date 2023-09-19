using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CustomerRelationshipDetail
    {
        #region Public Properties

        [DataMemberAttribute]
        public string Accounts { get; set; }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public CustomerRelationshipAccountDetail[] Details { get; set; }

        [DataMemberAttribute]
        public int Relationship { get; set; }

        [DataMemberAttribute]
        public double RelPerc { get; set; }

        #endregion Public Properties
    }
}