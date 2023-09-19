namespace iApplyShared.CbsModels
{
    public class CbsDownloadPositionAndDetailsRequest
    {
        #region Public Properties

        /// <summary>
        /// Account Check Digit (integer)
        /// For each account OutSelectedProfitsAccountAccountCd
        /// </summary>
        public int AccountCD { get; set; }

        /// <summary>
        /// Account Number (varchar (30))
        /// For each account OutSelectedProfitsAccountAccountNumber
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Account Type (integer)
        /// For each account OutSelectedProfitsAccountPrftSystem
        /// </summary>
        public int AccountType { get; set; }

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int CustomerCbsCd { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar (20))
        /// </summary>
        public string CustomerCbsId { get; set; }

        #endregion Public Properties
    }
}