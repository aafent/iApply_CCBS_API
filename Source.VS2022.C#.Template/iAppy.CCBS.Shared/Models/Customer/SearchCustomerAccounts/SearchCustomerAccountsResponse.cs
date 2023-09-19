using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class SearchCustomerAccountsResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public CustomerAccountInfo[] Details { get; set; }

        [DataMember]
        public bool NotFound { get; set; }

        #endregion Public Properties
    }
}