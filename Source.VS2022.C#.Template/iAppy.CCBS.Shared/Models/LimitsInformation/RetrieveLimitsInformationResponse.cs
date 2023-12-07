using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveLimitsInformationResponse : BaseResponse
    {
        #region Public Fields

        [DataMember]
        public List<LimitInformation> limitInformation { get; set; } = new();

        #endregion Public Fields
    }
}