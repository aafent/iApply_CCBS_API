using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CustomerInfo
    {
        #region Public Properties

        [DataMember]
        public string AddressLine1 { get; set; }

        [DataMember]
        public string AddressLine2 { get; set; }

        [DataMember]
        public string Businessregistry { get; set; }

        [DataMember]
        public string CertificationId { get; set; }

        [DataMember]
        public string CertificationTypeDescription { get; set; }

        [DataMember]
        public int CertificationTypeId { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string CustomerCity { get; set; }

        [DataMember]
        public string CustomerStatus { get; set; }

        [DataMember]
        public string FullName { get; set; }

        [DataMember]
        public string MemberBlIndicator { get; set; }

        [DataMember]
        public string MemberId { get; set; }

        [DataMember]
        public string MemberStatus { get; set; }

        [DataMember]
        public string MemberSubflag { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string PIN { get; set; }

        [DataMember]
        public short ProfitsCD { get; set; }

        [DataMember]
        public int ProfitsID { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        #endregion Public Properties
    }
}