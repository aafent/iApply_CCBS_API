using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetApplicationListRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string CBSID { get; set; }

        [DataMember]
        public int CheckDigit { get; set; }

        #endregion Public Properties
    }
}