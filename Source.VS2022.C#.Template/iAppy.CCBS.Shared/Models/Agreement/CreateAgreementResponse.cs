using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CreateAgreementResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public short AgreementAccountCD { get; set; }

        [DataMember]
        public string AgreementStatus { get; set; }

        [DataMember]
        public int CustomerID { get; set; }

        [DataMember]
        public string LoanReferenceNumber { get; set; }

        #endregion Public Properties
    }
}