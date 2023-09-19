using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrievePropertyValuationResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public ValuationItem[] ValuationItems { get; set; }

        #endregion Public Properties
    }
}