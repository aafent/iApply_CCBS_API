using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class UpdateDynamicCustomerFormRequest : BaseRequest
    {
        [DataMember]
        public string CustomerId { get; set; }
        [DataMember]
        public int CustomerCBSId { get; set; }
        [DataMember]
        public int CustomerCd { get; set; }
    }
}
