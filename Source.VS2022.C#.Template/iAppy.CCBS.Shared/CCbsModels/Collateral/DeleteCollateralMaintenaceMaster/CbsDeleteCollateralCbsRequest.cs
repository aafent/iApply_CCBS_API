using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsDeleteCollateralCbsRequest
    {
        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Collateral CBS Id
        /// Data Type: integer
        /// </summary>
        public int CollateralCbsId { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Estimated Secured Value Amount
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollEstAmount { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Central Bank Security Amount
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollSecAmount { get; set; }
    }
}
