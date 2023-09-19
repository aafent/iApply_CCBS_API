using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class FinalizeCollateralResponse : BaseResponse
    {
        /// <summary>
        /// Collateral status	OutCollateral.CollateralStatus	Text	Collateral Status of the finalized collateral. After successful execution it is set to 1 =  approved.
        /// </summary>
        [DataMember]
        public string CollateralStatus { get; set; }
    }
}
