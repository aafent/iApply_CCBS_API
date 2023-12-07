namespace iApplyShared.CbsModels
{
    public class CbsInsertDepositAccountResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Customer Id (varchar (15))
        /// </summary>
        public string cu_id { get; set; }

        /// <summary>
        /// Deposit Account Number (varchar (40))
        /// </summary>
        public string currentaccount { get; set; }

        /// <summary>
        /// Deposit Account Check Digit (integer)
        /// </summary>
        public int currentaccount_cd { get; set; }

        /// <summary>
        /// Deposit Account Statu (varchar (2))
        /// </summary>
        public string currentaccount_status { get; set; }

        /// <summary>
        /// Application Id (varchar (15))
        /// </summary>
        public string la_id { get; set; }

        #endregion Public Properties
    }
}