using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetDynamicCollateralTypesResponse : BaseResponse
    {
        [DataMember]
        virtual public string DynamicCode { get; set; }

        [DataMember]
        virtual public string DynamicDescription { get; set; }

        [DataMember]
        virtual public string DynamicComments { get; set; }

    }
}
