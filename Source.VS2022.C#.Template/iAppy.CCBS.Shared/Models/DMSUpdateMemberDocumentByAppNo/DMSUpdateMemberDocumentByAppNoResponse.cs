using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DMSUpdateMemberDocumentByAppNoResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public string UploadStatus { get; set; }

        #endregion Public Properties
    }
}