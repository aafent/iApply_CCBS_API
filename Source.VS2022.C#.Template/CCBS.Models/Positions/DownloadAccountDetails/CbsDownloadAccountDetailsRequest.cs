using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsDownloadAccountDetailsRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Account Check Digit
        /// </summary>
        [Mockup(2)]
        public int accountCD { get; set; }

        /// <summary>
        /// Account Number
        /// </summary>
        [Mockup(1)]
        public string accountNumber { get; set; }

        /// <summary>
        /// Account Type
        /// </summary>
        public int accountType { get; set; }

        #endregion Public Properties
    }
}