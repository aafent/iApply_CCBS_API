using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CollateralFxRateResponse : BaseResponse
    {
        [DataMember]
        public decimal FixRate { get; set; }

        [DataMember]
        public decimal InitFixRate { get; set; }

        [DataMember]
        public decimal CurrFixRate { get; set; }

    }
}
