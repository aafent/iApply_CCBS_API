using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsUpdateCustomerRelationshipsRequest : BaseCbsRequestModel
    {
        #region Public Properties

        public List<CustomerRelationshipRequest> CustomerRelationships { get; set; } = new();

        #endregion Public Properties
    }

    public class CustomerRelationshipRequest
    {
        #region Public Properties

        /// <summary>
        /// All Accounts (varchar)
        /// </summary>
        public string AllAccount { get; set; }

        /// <summary>
        /// Comments (varchar)
        /// "Perc" + RelPerc
        /// </summary>
        public string Comments { get; set; }

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
        public DateTime ExpiryDate { get; set; } = DateTime.Parse("1800-01-01");

        /// <summary>
        /// Issued Date (datetime)
        /// </summary>
        public DateTime IssueDate { get; set; } = DateTime.Parse("1800-01-01");

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

        /// <summary>
        /// Percentage (decimal (15,2))
        /// </summary>
        public decimal? RelPerc { get; set; }

        #endregion Public Properties
    }
}