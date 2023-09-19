using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CbsValuer
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Mobile { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string EntryStatus { get; set; }
        [DataMember]
        public string InternalFlag { get; set; }
        [DataMember]
        public string County { get; set; }
        [DataMember]
        public decimal? Amount { get; set; }
        [DataMember]
        public string ContactPerson { get; set; }
        [DataMember]
        public int? Ccy { get; set; }
        [DataMember]
        public int? Underwriter { get; set; }
        [DataMember]
        public string BankEmployee { get; set; }


    }
}
