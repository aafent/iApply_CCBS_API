using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CustomerIdentification
    {
        #region Public Properties

        [DataMember]
        public string IdentificationAuthority { get; set; }

        [DataMember]
        public string IdentificationDocument { get; set; }

        [DataMember]
        public DateTime IdentificationExpiryDate { get; set; }

        [DataMember]
        public int IdentificationIssueCountry { get; set; }

        [DataMember]
        public DateTime IdentificationIssueDate { get; set; }

        [DataMember]
        public string IdentificationMain { get; set; }

        [DataMember]
        public string IdentificationNumber { get; set; }

        [DataMember]
        public int IdentificationType { get; set; }

        [DataMember]
        public short SerialNo { get; set; }

        #endregion Public Properties
    }
}