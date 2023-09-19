using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveCollateralDetailsRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public int? MainCustomerCBSCd { get; set; }

        [DataMember]
        public int? MainCustomerCBSId { get; set; }

        [DataMember]
        public string MasterRecordType { get; set; }

        [DataMember]
        public int? PropertyCBSId { get; set; }

        [DataMember]
        public int? PropertyTransCBSId { get; set; }

        [DataMember]
        public string RecordType { get; set; }

        [DataMember]
        public string TransactionId { get; set; }

        #endregion Public Properties
    }
}