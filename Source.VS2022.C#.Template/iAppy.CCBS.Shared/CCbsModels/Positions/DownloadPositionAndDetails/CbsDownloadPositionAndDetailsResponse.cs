using iApply.CbsModels;

namespace iApplyShared.CbsModels
{
    /// <summary>
    ///
    /// </summary>
    public class CbsDownloadPositionAndDetailsResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// TF Expiry Type (Trade Finance, accountType = 37)
        /// Data Type: varchar (15)
        /// CBS: OutSelectedLgLgAccountExpirationType
        /// </summary>
        public string cb_exp_type_tf { get; set; }

        /// <summary>
        /// LC Total Issued Amount (Letter of Credit, accountType = 39)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLgLgAccountLgAmountBal
        /// </summary>
        public decimal cb_lg_com_bal_lc { get; set; }

        /// <summary>
        /// TF Amount (Trade Finance, accountType = 37)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLgLgAccountLgAmountBal
        /// </summary>
        public decimal cb_lg_com_bal_tf { get; set; }

        /// <summary>
        /// LC Initial Amount (Letter of Credit, accountType = 39)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLgLgAccountLgInitialAmn
        /// </summary>
        public decimal cb_lg_exp_bal_lc { get; set; }

        /// <summary>
        /// LC Limit Amount (Letter of Credit, accountType = 39)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLgLgAccountAccLimitAmn
        /// </summary>
        public decimal cb_lg_lmt_amt_lc { get; set; }

        /// <summary>
        /// LC Obligation Status (Letter of Credit, accountType = 39)
        /// Data Type: varchar (15)
        /// CBS: OutSelectedLgLgAccountObligationStatus
        /// </summary>
        public string cb_lg_obl_status_lc { get; set; }

        /// <summary>
        /// Account Status (Letter of Credit, accountType = 39)
        /// Data Type: varchar (10)
        /// CBS: OutSelectedLgLgAccountAccStatus
        /// </summary>
        public string cb_status_lc { get; set; }

        /// <summary>
        /// Customer Id
        /// Data Type: varchar (15)
        /// CBS: customerId
        /// </summary>
        public string cu_id { get; set; }

        public List<PositionDataModel> PositionsList { get; set; }

        #endregion Public Properties
    }
}