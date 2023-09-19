using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveLimitsInformationRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string ApplicationId { get; set; }

        [DataMember]
        public DateTime DateFrom { get; set; }

        [DataMember]
        public DateTime DateTo { get; set; }

        [DataMember]
        public string InsuranceId { get; set; }

        [DataMember]
        public string LogId { get; set; }

        [DataMember]
        public string ProductId { get; set; }

        [DataMember]
        public string Role { get; set; }

        #endregion Public Properties
    }
}