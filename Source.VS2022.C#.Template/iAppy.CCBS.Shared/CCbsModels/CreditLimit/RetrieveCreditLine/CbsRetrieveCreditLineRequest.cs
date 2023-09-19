using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsRetrieveCreditLineRequest
    {
        /// <summary>
        /// Customer CBS Id
        /// Data Type: integer
        /// </summary>
        public int CustomerCBSId { get; set; }

        /// <summary>
        /// Customer Check Digit
        /// Data Type: integer
        /// </summary>
        public int CustomerCBSCd { get; set; }
    }
}
