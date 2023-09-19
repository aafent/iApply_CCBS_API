using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetCustomerCategoryRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public short? CustomerCBSCd { get; set; }

        [DataMember]
        public int? CustomerCBSId { get; set; }

        #endregion Public Properties
    }
}