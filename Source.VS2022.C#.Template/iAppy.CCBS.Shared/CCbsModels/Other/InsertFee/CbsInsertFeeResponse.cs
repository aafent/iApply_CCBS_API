using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsInsertFeeResponse :CommonResponseModel
    {
        /// <summary>
        /// Source
        /// Data Type: varchar (1)
        /// Entities: crp_CBS_updatefees
        /// Notes: 2
        /// </summary>
        public string source { get; set; }
    }
}
