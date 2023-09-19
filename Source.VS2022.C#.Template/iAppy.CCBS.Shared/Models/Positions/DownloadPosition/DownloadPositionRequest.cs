using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DownloadPositionRequest : BaseRequest
    {
        #region Public Properties

        [DataMember(IsRequired = true)]
        public string CustomerId { get; set; }

        #endregion Public Properties
    }
}