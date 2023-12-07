using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class SearchCustomerResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public List<CustomerInfo> Details { get; set; } = new();

        [DataMember]
        public bool NotFound { get; set; }

        #endregion Public Properties
    }
}