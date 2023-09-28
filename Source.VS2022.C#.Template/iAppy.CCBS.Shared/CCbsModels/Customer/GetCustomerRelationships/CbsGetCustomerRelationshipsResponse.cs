using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsGetCustomerRelationshipsResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Opposite (varchar (1))
        /// </summary>
        public string reltype { get; set; }

        /// <summary>
        /// RelationshipTmstamp (datetime)
        /// </summary>
        public DateTime RelationshipTmstamp { get; set; }

        /// <summary>
        /// Relationship (varchar (20))
        /// </summary>
        public string cu_reltype { get; set; }

        /// <summary>
        /// Customer Id (varchar (15))
        /// </summary>
        public string cu_id_rel { get; set; }

        /// <summary>
        /// Issued Date (datetime)
        /// </summary>
        public DateTime cu_relissdt { get; set; }

        /// <summary>
        /// Expiry Date (datetime)
        /// </summary>
        public DateTime cu_relexpdt { get; set; }

        /// <summary>
        /// CustomerType (varchar)
        /// </summary>
        public string CustomerType { get; set; }

        /// <summary>
        /// Percentage (decimal (15,2))
        /// </summary>
        public decimal perc { get; set; }

        /// <summary>
        /// Account Check Digit (integer)
        /// </summary>
        public int currentaccount_cd { get; set; }

        /// <summary>
        /// Account Number (varchar (40))
        /// </summary>
        public string currentaccount { get; set; }

        /// <summary>
        /// Account Type (varchar (10))
        /// </summary>
        public string account_type { get; set; }

        /// <summary>
        /// All Accounts (varchar (1))
        /// 1 = Yes 0 = No
        /// </summary>
        public string cu_allacc { get; set; }

        public List<CustomerRelationshipDetail> Details { get; set; }


        #endregion Public Properties
    }
}
