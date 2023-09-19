using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class InsertCollateralGeneralRequest : BaseRequest
    {
        [DataMember]
        public string PropertyId { get; set; }

        [DataMember]
        public string TransactionId { get; set; }
    }
}
