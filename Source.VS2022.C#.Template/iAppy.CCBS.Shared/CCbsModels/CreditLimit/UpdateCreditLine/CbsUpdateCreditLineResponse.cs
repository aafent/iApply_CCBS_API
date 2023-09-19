using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsUpdateCreditLineResponse : CommonResponseModel
    {
        /// <summary>
        /// Entity: cr_cucreditline
        /// Description: Source
        /// Data Type: varchar (1)
        /// </summary>
        public string CrFromCbs { get; set; }
    }
}
