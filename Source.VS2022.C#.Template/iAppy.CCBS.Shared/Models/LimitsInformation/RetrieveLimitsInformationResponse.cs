using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveLimitsInformationResponse : BaseResponse
    {
        #region Public Fields

        [DataMember]
        public LimitInformation[] limitInformation;

        #endregion Public Fields
    }
}