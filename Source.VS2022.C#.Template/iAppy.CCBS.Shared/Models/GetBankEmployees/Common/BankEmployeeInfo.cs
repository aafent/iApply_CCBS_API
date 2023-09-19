using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class BankEmployeeInfo
    {
        [DataMemberAttribute]
        public string FirstName { get; set; }

        [DataMemberAttribute]
        public string BankEmployeeId { get; set; }

        [DataMemberAttribute]
        public string Surname { get; set; }

        [DataMemberAttribute]
        public string StaffNo { get; set; }
    }
}
