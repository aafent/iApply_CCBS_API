using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsUpdateLGBeneficiaryResponse
    {
        #region Public Properties

        /// <summary>
        /// Customer Id (varchar (15))
        /// </summary>
        public string cu_id { get; set; }

        /// <summary>
        /// LG CBS Id (varchar (20))
        /// </summary>
        public string clnum { get; set; }

        #endregion Public Properties
    }
}
