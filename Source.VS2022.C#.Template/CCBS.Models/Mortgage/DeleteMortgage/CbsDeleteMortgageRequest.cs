using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsDeleteMortgageRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Mortgage CBS Id
        /// Data Type: integer
        /// </summary>
        [Mockup(1)]
        public int MortgageCbsId { get; set; }

        #endregion Public Properties
    }
}