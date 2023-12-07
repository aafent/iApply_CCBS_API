using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DownloadDebtResponse : BaseResponse
    {
        #region Public Properties

        [DataMemberAttribute]
        public List<DebtInfo> Details { get; set; } = new();

        [DataMemberAttribute]
        public bool NotFound { get; set; }

        #endregion Public Properties
    }
}