using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CollateralCbsRetrieveRequest : BaseRequest
    {
        [DataMemberAttribute]
        public int OpeningUnit { get; set; }

        [DataMemberAttribute]
        public int Product { get; set; }

        [DataMemberAttribute]
        public double CollateralSn { get; set; }

        [DataMemberAttribute]
        public string ApplicationId { get; set; }

    }
}
