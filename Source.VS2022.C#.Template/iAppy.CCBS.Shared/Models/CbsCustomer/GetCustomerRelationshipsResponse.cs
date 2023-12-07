using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetCustomerRelationshipsResponse : BaseResponse
    {
        #region Public Properties

        [DataMemberAttribute(EmitDefaultValue = false, Order = 36)]
        public List<CustomerRelationship> CustomerRelationships { get; set; } = new();

        #endregion Public Properties
    }
}