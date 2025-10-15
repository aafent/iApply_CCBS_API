namespace CCBS.Models
{
    public class CbsGetBusinessDateRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Optional, default is null - The Bank Group ID
        /// </summary>
        public string bankGroup { get; set; }

        /// <summary>
        /// Optional, default is null - The Bank’s Code
        /// </summary>
        public string bankCode { get; set; }

        #endregion Public Properties
    }
}
