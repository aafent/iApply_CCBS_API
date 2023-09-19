using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetDepBalanceAccrualsRequest : BaseRequest
    {
        [DataMember]
        public string DepositAccount { get; set; }

        [DataMember]
        public DateTime BusinessDate { get; set; }

        [DataMember]
        public short AccountCd { get; set; }

        [DataMember]
        public short AccountType { get; set; }

        [DataMember]
        public string CustomerID { get; set; }
    }
}
