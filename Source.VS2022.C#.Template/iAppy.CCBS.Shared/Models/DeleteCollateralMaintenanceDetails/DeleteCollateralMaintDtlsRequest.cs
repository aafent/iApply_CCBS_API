using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{

    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DeleteCollateralMaintDtlsRequest : BaseRequest
    {
        [DataMember]
        public string ApplicationId { get; set; }

        [DataMember]
        public string CollateralId { get; set; }

        [DataMember]
        public string AccountNumber { get; set; }

        [DataMember]
        public int? AccountCheckDigit { get; set; }

        [DataMember]
        public int? CollateralTrCbsId { get; set; }

        [DataMember]
        public string CustomerCbsId { get; set; }

    }
}
