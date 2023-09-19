using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsRetrieveCreditLineResponse : CommonResponseModel
    {
        /// <summary>
        /// Customer Id
        /// Data Type: varchar (15)
        /// Entities: cr_cucreditline
        /// </summary>
        public string cu_id { get; set; }

        /// <summary>
        /// Credit Limit Currency
        /// Data Type: integer
        /// Entities: cr_cucreditline
        /// </summary>
        public int cr_ccy { get; set; }

        /// <summary>
        /// Credit Limit Amount
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucreditline
        /// </summary>
        public decimal cr_amount { get; set; }

        /// <summary>
        /// Expiry Date
        /// Data Type: datetime
        /// Entities: cr_cucreditline
        /// </summary>
        public DateTime cr_expdt { get; set; }

        /// <summary>
        /// Review Date
        /// Data Type: datetime
        /// Entities: cr_cucreditline
        /// </summary>
        public DateTime cr_reviewdt { get; set; }

        /// <summary>
        /// Next Review Date
        /// Data Type: datetime
        /// Entities: cr_cucreditline
        /// </summary>
        public DateTime cr_nextreviewdt { get; set; }

        /// <summary>
        /// Credit Limit Type
        /// Data Type: varchar (15)
        /// Entities: cr_cucreditline
        /// </summary>
        public string cr_type { get; set; }

        /// <summary>
        /// Credit Limit Status
        /// Data Type: varchar (15)
        /// Entities: cr_cucreditline
        /// </summary>
        public string cr_status { get; set; }

        /// <summary>
        /// Utilized Limit
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucreditline
        /// </summary>
        public decimal cr_utamount { get; set; }

        /// <summary>
        /// Assignment Date
        /// Entities: cr_cucreditline
        /// </summary>
        public DateTime cr_assigndt { get; set; }
    }
}
