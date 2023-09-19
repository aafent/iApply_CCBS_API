namespace iApplyShared.CbsModels
{
    public class CbsDownloadAccountDetailsRequest
    {
        #region Public Properties

        /// <summary>
        /// Account Check Digit
        /// </summary>
        public int accountCD { get; set; }

        /// <summary>
        /// Account Number
        /// </summary>
        public string accountNumber { get; set; }

        /// <summary>
        /// Account Type
        /// </summary>
        public int accountType { get; set; }

        #endregion Public Properties
    }
}