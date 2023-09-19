using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class SearchValuerRequest : BaseRequest
    {
        [DataMember]
        public int County { get; set; }
        [DataMember]
        public string ValuerType { get; set; }
        [DataMember]
        public decimal? Amount { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}
