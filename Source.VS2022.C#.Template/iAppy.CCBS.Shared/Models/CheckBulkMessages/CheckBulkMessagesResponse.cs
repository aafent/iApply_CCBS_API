using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class BulkMessageStatus
    {
        #region Public Properties

        [DataMember(IsRequired = true)]
        public string MessageStatus { get; set; }

        [DataMember(IsRequired = true)]
        public decimal UniqueMessageId { get; set; }

        #endregion Public Properties
    }

    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CheckBulkMessagesResponse : BaseResponse
    {
        #region Public Properties

        [DataMember(IsRequired = true)]
        public BulkMessageStatus[] BulkMessageStatuses { get; set; }

        #endregion Public Properties
    }
}