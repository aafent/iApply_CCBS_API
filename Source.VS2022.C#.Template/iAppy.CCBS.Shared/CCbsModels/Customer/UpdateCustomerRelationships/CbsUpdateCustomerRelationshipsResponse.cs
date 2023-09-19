using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsUpdateCustomerRelationshipsResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Customer Id (varchar (15))
        /// </summary>
        public string cu_id { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar (20))
        /// </summary>
        public string cu_clnum { get; set; }

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int cu_checkdigit { get; set; }

        /// <summary>
        /// Relationship (varchar (20))
        /// </summary>
        public string cu_reltype { get; set; }

        /// <summary>
        /// Source (varchar (20))
        /// 1
        /// </summary>
        public string source { get; set; }

        /// <summary>
        /// Relationship Master (varchar (20))
        /// </summary>
        public string cu_reltypem { get; set; }

        /// <summary>
        /// Account Number (varchar (40))
        /// </summary>
        public string currentaccount { get; set; }

        #endregion Public Properties
    }
}
