using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    public class BBF
    {
        [DataMember]
        public string CustomerId { get; set; }
        [DataMember]
        public string CustomerCbsId { get; set; }
        [DataMember]
        public int? CustomerCheckDigit { get; set; }
        [DataMember]
        public string BBFId { get; set; }
        [DataMember]
        public string BBFSn { get; set; }
        [DataMember]
        public string BBFStatus { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string RelType { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Address1 { get; set; }
        [DataMember]
        public string Address2 { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Comments { get; set; }
        [DataMember]
        public string FisrtName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string HomePhone { get; set; }
        [DataMember]
        public string PoBox { get; set; }
        [DataMember]
        public string Mobile { get; set; }
        [DataMember]
        public string Percentage { get; set; }
        [DataMember]
        public string Region { get; set; }
        [DataMember]
        public string Resident { get; set; }
        [DataMember]
        public string WorkPhone { get; set; }
        [DataMember]
        public string ZipCode { get; set; }
        [DataMember]
        public string BBFCbsid { get; set; }
        [DataMember]
        public int? BBFCheckDigit { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string IdType { get; set; }
        [DataMember]
        public string IdNumber { get; set; }
        [DataMember]
        public DateTime? BirthDate { get; set; }
        [DataMember]
        public string Occupation { get; set; }
    }
}

