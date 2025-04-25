using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsDeleteCustomerRelationshipsRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Customer Check Digit (integer)
        /// 0 if CustomerCBSCd = RelCustomerCBSCd
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar)
        /// 0 if CustomerCBSId = RelCustomerCBSId
        /// </summary>
        [Mockup(1)]
        public string CustomerCBSId { get; set; }

        /// <summary>
        /// Expiry Date (datetime)
        /// </summary>
        public DateTime ExpiryDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Issued Date (datetime)
        /// </summary>
        public DateTime IssueDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Relationship (integer)
        /// </summary>
        public int RelationCode { get; set; }

        /// <summary>
        /// Relationship (varchar)
        /// </summary>
        public string RelationCodeDet { get; set; }

        /// <summary>
        /// Relation Customer Check Digit (integer)
        /// 0 if RelCustomerCBSCd = CustomerCBSCd
        /// </summary>
        public int RelCustomerCBSCd { get; set; }

        /// <summary>
        /// Relation Customer CBS Id (varchar)
        /// 0 if RelCustomerCBSId = CustomerCBSId
        /// </summary>
        public string RelCustomerCBSId { get; set; }

        #endregion Public Properties
    }
}