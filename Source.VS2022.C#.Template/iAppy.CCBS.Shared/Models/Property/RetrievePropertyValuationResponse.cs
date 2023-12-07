using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrievePropertyValuationResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public List<ValuationItem> ValuationItems { get; set; } = new();

        #endregion Public Properties
    }
}