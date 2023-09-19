using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveDynamicCollateralRequest : BaseRequest
    {

        [DataMember]
        virtual public string TagSetCode { get; set; }

        [DataMember]
        virtual public string pr_id { get; set; }

        [DataMember]
        virtual public int? CustomerCbsId { get; set; }

        [DataMember]
        virtual public int? CustomerCbsCd { get; set; }

        [DataMember]
        virtual public double? CollInternalSn { get; set; }

    }
}
