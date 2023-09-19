using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsDeleteCustAccRelationshipsRequest
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
        /// Customer CBS Id (varchar)
        /// 0 if CustomerCBSId = RelCustomerCBSId
        /// </summary>
        public string CustomerCBSId { get; set; }

        /// <summary>
        /// Relation Customer CBS Id (varchar)
        /// 0 if RelCustomerCBSId = CustomerCBSId
        /// </summary>
        public string RelCustomerCBSId { get; set; }

        /// <summary>
        /// Account Number (integer)
        /// </summary>
        public int RelAccountNumber { get; set; }

        /// <summary>
        /// Account Check Digit (integer)
        /// </summary>
        public int RelAccountNumberCd { get; set; }

        /// <summary>
        /// Account Type (varchar)
        /// </summary>
        public string RelAccountType { get; set; }

        #endregion Public Properties
    }
}
