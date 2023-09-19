using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DownloadPositionAndDetailsResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public int PositionRowsCount { get; set; }

        #endregion Public Properties
    }
}