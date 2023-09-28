namespace iApplyShared.CbsModels
{
    public class DownloadLoanInsurance
    {
        #region Public Properties

        /// <summary>
        /// Account Number (from ValidateAccount)
        /// Data Type: varchar (30)
        /// CBS: OutSelectedProfitsAccountAccountNumber
        /// </summary>
        public string cb_accn { get; set; }

        /// <summary>
        /// Account Type (from ValidateAccount)
        /// Data Type: integer
        /// CBS: OutSelectedProfitsAccountPrftSystem
        /// </summary>
        public int cb_accountkind { get; set; }

        /// <summary>
        /// Account Check Digit (from ValidateAccount)
        /// Data Type: integer
        /// CBS: OutSelectedProfitsAccountAccountCd
        /// </summary>
        public int cb_checkdigit { get; set; }

        /// <summary>
        /// Additional Amount
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpCommitmentOutGrmIssPremiumCalcAddInstalmAmnt
        /// </summary>
        public decimal in_add_first_inst_amt { get; set; }

        /// <summary>
        /// Annual Premium
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpCommitmentOutGrmIssPremiumCalcAnnualPremium
        /// </summary>
        public decimal in_annual_premium { get; set; }

        /// <summary>
        /// Serial Number
        /// Data Type: integer
        /// CBS: OutGrpCommitmentOutGrmIssCommitmentTpSoIdentifier
        /// </summary>
        public int in_applicationid { get; set; }

        /// <summary>
        /// Branch
        /// Data Type: varchar (10)
        /// CBS: OutGrpCommitmentOutGrmIssCommitmentFkResponsibleUnit
        /// </summary>
        public string in_branch { get; set; }

        /// <summary>
        /// Not Used
        /// Data Type: varchar (100)
        /// CBS: OutGrpCommitmentOutGrmIssCommitmentFkCnlUsr
        /// </summary>
        public string in_canceluser { get; set; }

        /// <summary>
        /// Currency
        /// Data Type: varchar (10)
        /// CBS: OutGrpCommitmentOutGrmAccCurrencyShortDescr
        /// </summary>
        public string in_ccy { get; set; }

        /// <summary>
        /// Insurance Company
        /// Data Type: varchar (10)
        /// CBS: OutGrpCommitmentOutGrmIssCommitmentCrAccCustomerId
        /// </summary>
        public string in_comp_id { get; set; }

        /// <summary>
        /// Insurance Company Account
        /// Data Type: varchar (40)
        /// CBS: OutGrpCommitmentOutGrmIssCommitmentLoanProfitsAcc
        /// </summary>
        public string in_inscomp_acc { get; set; }

        /// <summary>
        /// Issue Date
        /// Data Type: datetime
        /// CBS: OutGrpCommitmentOutGrmIssCommitmentIssueDate
        /// </summary>
        public DateTime in_issuedate { get; set; }

        /// <summary>
        /// Loading Amount
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpCommitmentOutGrmIssPremiumCalcLoadingAmnt
        /// </summary>
        public decimal in_loading_amnt { get; set; }

        /// <summary>
        /// Modification Date
        /// Data Type: datetime
        /// CBS: OutGrpCommitmentOutGrmIssCommitmentLastUpdateDate
        /// </summary>
        public DateTime in_moddate { get; set; }

        /// <summary>
        /// Monthly Premium
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpCommitmentOutGrmIssPremiumCalcMonthlyPremium
        /// </summary>
        public decimal in_monthly_premium { get; set; }

        /// <summary>
        /// Prorata
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpCommitmentOutGrmIssPremiumCalcProrataPremium
        /// </summary>
        public decimal in_prorata { get; set; }

        /// <summary>
        /// Remaining Amount
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpCommitmentOutGrmIssPremiumCalcRemainingAmnt
        /// </summary>
        public decimal in_remain_amnt { get; set; }

        /// <summary>
        /// Renewal Date
        /// Data Type: datetime
        /// CBS: OutGrpCommitmentOutGrmIssCommitmentRenewalDate
        /// </summary>
        public DateTime in_rendate { get; set; }

        /// <summary>
        /// Insurance Status
        /// Data Type: varchar (4)
        /// CBS: OutGrpCommitmentOutGrmIssCommitmentEntryStatus
        /// </summary>
        public string in_status { get; set; }

        /// <summary>
        /// Not Used
        /// Data Type: varchar (100)
        /// CBS: OutGrpCommitmentOutGrmIssCommitmentFkFinalizeUsr
        /// </summary>
        public string in_user { get; set; }

        /// <summary>
        /// Insurance Id
        /// Data Type: varchar (15)
        /// CBS: OutGrpCommitmentOutGrmProductIdProduct
        /// </summary>
        public string insurance_id { get; set; }

        #endregion Public Properties
    }
}