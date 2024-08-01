using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsDeleteCustIdentifRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar (20))
        /// </summary>
        [Mockup(1)]
        public string CustomerCBSId { get; set; }

        public CbsCustomerIdentificationView CustomerIdentificationViews { get; set; }

        /// <summary>
        /// Id Authority (varchar (100))
        /// </summary>
        public string IdentificationAuthority { get; set; }

        /// <summary>
        /// Id Expiry Date (datetime)
        /// </summary>
        public DateTime IdentificationExpiryDate { get; set; }

        /// <summary>
        /// Issue Country (integer)
        /// </summary>
        public int IdentificationIssueCountry { get; set; }

        /// <summary>
        /// Issue Country Description(varchar (200))
        /// </summary>
        public string IdentificationIssueCountryShortDescription { get; set; }

        /// <summary>
        /// Id Issue Date (datetime)
        /// </summary>
        public DateTime IdentificationIssueDate { get; set; }

        /// <summary>
        /// Main Id (varchar (1))
        /// 1 = Yes 0 = No
        /// </summary>
        public string IdentificationMain { get; set; }

        /// <summary>
        /// Identification Number (varchar (100))
        /// </summary>
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// Id Type (varchar (10))
        /// </summary>
        public string IdentificationType { get; set; }

        #endregion Public Properties
    }
}