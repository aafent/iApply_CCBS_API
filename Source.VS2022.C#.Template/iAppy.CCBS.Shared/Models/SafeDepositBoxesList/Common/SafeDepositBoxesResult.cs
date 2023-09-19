using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class SafeDepositBoxesResult
    {
        [DataMember]
        public int? Branch { get; set; }
        [DataMember]
        public int? Ccy { get; set; }
        [DataMember]
        public decimal? Rental { get; set; }
        [DataMember]
        public int? Product { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public int? SDSN { get; set; }
    }
}
