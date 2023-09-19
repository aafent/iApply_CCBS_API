using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CreateInsuranceRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string ApplicationId { get; set; }

        [DataMember]
        public string IApplyUserName { get; set; }

        [DataMember]
        public int ProductId { get; set; }

        #endregion Public Properties
    }
}