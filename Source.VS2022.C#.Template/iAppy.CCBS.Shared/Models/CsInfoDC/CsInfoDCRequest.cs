using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CsInfoDCRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string CrbKey { get; set; }

        #endregion Public Properties
    }
}