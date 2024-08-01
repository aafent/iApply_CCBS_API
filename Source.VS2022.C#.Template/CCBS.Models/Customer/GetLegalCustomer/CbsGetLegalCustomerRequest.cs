using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsGetLegalCustomerRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Customer Check Digit
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Customer CBS Id
        /// </summary>
        [Mockup(1)]
        public string CustomerCBSId { get; set; }

        #endregion Public Properties
    }
}