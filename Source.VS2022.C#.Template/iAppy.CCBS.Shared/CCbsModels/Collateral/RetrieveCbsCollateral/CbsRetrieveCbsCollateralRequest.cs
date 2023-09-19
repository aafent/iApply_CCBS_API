using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsRetrieveCbsCollateralRequest
    {
        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Opening Branch
        /// Data Type: integer
        /// </summary>
        public int openingUnit { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Collateral Product
        /// Data Type: integer
        /// </summary>
        public int product { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Collateral CBS Id
        /// Data Type: integer
        /// </summary>
        public int collateralSn { get; set; }
    }
}
