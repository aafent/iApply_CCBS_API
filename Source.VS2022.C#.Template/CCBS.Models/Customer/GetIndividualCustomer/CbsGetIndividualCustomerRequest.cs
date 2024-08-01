using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsGetIndividualCustomerRequest : BaseCbsRequestModel
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

        #endregion Public Properties
    }
}