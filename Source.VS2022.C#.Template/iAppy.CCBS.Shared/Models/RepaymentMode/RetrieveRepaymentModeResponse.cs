using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveRepaymentModeResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public string RepaymentMode { get; set; }

        [DataMember]
        public string RepaymentModeDescription { get; set; }

        #endregion Public Properties
    }
}