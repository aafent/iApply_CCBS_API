using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetBankEmployeeRequest : BaseRequest
    {
        [DataMemberAttribute]
        public string StaffNo { get; set; }

        [DataMemberAttribute]
        public string LastName { get; set; }

        [DataMemberAttribute]
        public int Branch { get; set; }
    }

}
