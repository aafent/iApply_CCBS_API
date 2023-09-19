using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsDeleteCustomerRelationshipsRequest
    {
        #region Public Properties

        /// <summary>
        /// Customer Check Digit (integer)
        /// 0 if CustomerCBSCd = RelCustomerCBSCd
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Relation Customer Check Digit (integer)
        /// 0 if RelCustomerCBSCd = CustomerCBSCd
        /// </summary>
        public int RelCustomerCBSCd { get; set; }

        /// <summary>
        /// Relationship (varchar)
        /// </summary>
        public string RelationCodeDet { get; set; }

        /// <summary>
        /// Relationship (integer)
        /// </summary>
        public int RelationCode { get; set; }

        /// <summary>
        /// Issued Date (datetime)
        /// </summary>
        public DateTime IssueDate { get; set; }

        /// <summary>
        /// Expiry Date (datetime)
        /// </summary>
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar)
        /// 0 if CustomerCBSId = RelCustomerCBSId
        /// </summary>
        public string CustomerCBSId { get; set; }

        /// <summary>
        /// Relation Customer CBS Id (varchar)
        /// 0 if RelCustomerCBSId = CustomerCBSId
        /// </summary>
        public string RelCustomerCBSId { get; set; }

        #endregion Public Properties
    }
}
