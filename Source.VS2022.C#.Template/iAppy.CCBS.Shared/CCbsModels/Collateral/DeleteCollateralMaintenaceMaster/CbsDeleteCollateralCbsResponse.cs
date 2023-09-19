using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsDeleteCollateralCbsResponse : CommonResponseModel
    {
        /// <summary>
        /// Entity: crp_CBS_updateCollCBSID
        /// Description: Application Id
        /// Data Type: varchar (15)
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollCBSID
        /// Description: Collateral Id
        /// Data Type: varchar (15)
        /// </summary>
        public string co_id { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollCBSID
        /// Description: Collateral CBS Id
        /// Data Type: integer
        /// </summary>
        public int co_cbsid { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollCBSID
        /// Description: Collateral Status
        /// Data Type: varchar (10)
        /// </summary>
        public string co_status { get; set; }
    }
}
