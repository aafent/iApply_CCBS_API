using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CheckBulkMessagesRequest : BaseRequest
    {
        #region Public Properties

        [DataMember(IsRequired = true)]
        public decimal[] UniqueMessageIds { get; set; }

        #endregion Public Properties
    }
}