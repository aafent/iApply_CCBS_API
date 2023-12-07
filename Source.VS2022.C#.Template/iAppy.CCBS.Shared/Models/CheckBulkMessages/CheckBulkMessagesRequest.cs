using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CheckBulkMessagesRequest : BaseRequest
    {
        #region Public Properties

        [DataMember(IsRequired = true)]
        public List<decimal> UniqueMessageIds { get; set; } = new();

        #endregion Public Properties
    }
}