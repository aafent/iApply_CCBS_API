using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class SearchCustomerAccountsRequest : BaseRequest
    {
        #region Public Properties

        [DataMember(IsRequired = true)]
        public short? AccountType { get; set; }

        [DataMember(IsRequired = true)]
        public int? CustomerID { get; set; }

        [DataMember(IsRequired = true)]
        public string CustomerType { get; set; }

        [DataMember]
        public int? ProductID { get; set; }

        #endregion Public Properties
    }
}