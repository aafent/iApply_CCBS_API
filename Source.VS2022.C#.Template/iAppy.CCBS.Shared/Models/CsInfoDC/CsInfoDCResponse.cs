using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CsInfoDCResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public string DocumentId { get; set; }

        #endregion Public Properties
    }
}