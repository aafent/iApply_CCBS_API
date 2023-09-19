using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CustomerAddress
    {
        #region Public Properties

        [DataMember]
        public DateTime AccDate { get; set; }

        [DataMember]
        public string Address1 { get; set; }

        [DataMember]
        public string Address2 { get; set; }

        [DataMember]
        public int AddressSerialNumber { get; set; }

        [DataMember]
        public string AddressStatus { get; set; }

        [DataMember]
        public int AddressType { get; set; }

        [DataMember]
        public int AddSerial { get; set; }

        [DataMember]
        public string Apart { get; set; }

        [DataMember]
        public string BuildName { get; set; }

        [DataMember]
        public string Buildning { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string CommunicationAddress { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string CountryCode { get; set; }

        [DataMember]
        public string County { get; set; }

        [DataMember]
        public string CountyCode { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Fax { get; set; }

        [DataMember]
        public string Floor { get; set; }

        [DataMember]
        public string MailBox { get; set; }

        [DataMember]
        public string PostalCode { get; set; }

        [DataMember]
        public string PostOffice { get; set; }

        [DataMember]
        public string Region { get; set; }

        [DataMember]
        public string Telephone { get; set; }

        [DataMember]
        public string Telephone2 { get; set; }

        [DataMember]
        public string Telephone3 { get; set; }

        [DataMember]
        public string WebSite { get; set; }

        #endregion Public Properties
    }
}