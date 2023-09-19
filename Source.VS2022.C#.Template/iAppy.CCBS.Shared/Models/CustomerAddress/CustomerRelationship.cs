using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CustomerRelationship
    {
        #region Public Properties

        [DataMemberAttribute]
        public int Customer { get; set; }

        [DataMemberAttribute]
        public int CustomerCD { get; set; }

        [DataMemberAttribute]
        public string CustomerType { get; set; }

        [DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public CustomerRelationshipDetail[] Details { get; set; }

        [DataMemberAttribute]
        public DateTime ExpiryDate { get; set; }

        [DataMemberAttribute]
        public DateTime IssuedDate { get; set; }

        [DataMemberAttribute]
        public string Opposite { get; set; }

        [DataMemberAttribute]
        public string Relationship { get; set; }

        [DataMemberAttribute]
        public double RelPerc { get; set; }

        #endregion Public Properties
    }
}