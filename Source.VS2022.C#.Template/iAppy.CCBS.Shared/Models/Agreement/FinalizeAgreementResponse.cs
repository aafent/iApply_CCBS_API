using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class FinalizeAgreementResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public string AgreementStatus { get; set; }

        #endregion Public Properties
    }
}