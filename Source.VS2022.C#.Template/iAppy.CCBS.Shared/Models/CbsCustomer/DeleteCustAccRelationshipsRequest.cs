using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DeleteCustAccRelationshipsRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string Account { get; set; }

        [DataMember]
        public string CustomerId { get; set; }

        [DataMember]
        public string RelatedCustomer { get; set; }

        [DataMember]
        public string RelationCodeDet { get; set; }

        [DataMember]
        public string Relationship { get; set; }

        #endregion Public Properties
    }
}