namespace iApplyShared.CbsModels
{
    public class CbsDownloadAccountDetailsResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Account Kind
        /// </summary>
        /// <remarks>Agreement (accounType = 19)</remarks>
        public string cb_acc_kind { get; set; }

        /// <summary>
        /// Account Number
        /// </summary>
        public string cb_accn { get; set; }

        /// <summary>
        /// Account Type
        /// </summary>
        public int cb_accountkind { get; set; }

        /// <summary>
        /// Agreement Limit Usage
        /// </summary>
        /// <remarks>Agreement (accounType = 19)</remarks>
        public string cb_agr_lim_use { get; set; }

        /// <summary>
        /// Agreement Limit
        /// </summary>
        /// <remarks>Agreement (accounType = 19)</remarks>
        public decimal cb_agr_limit { get; set; }

        /// <summary>
        /// Agreement Signing Date
        /// </summary>
        /// <remarks>Agreement (accounType = 19)</remarks>
        public DateTime cb_agr_sign_dt { get; set; }

        /// <summary>
        /// Agreement Utilised Limit
        /// </summary>
        /// <remarks>Agreement (accounType = 19)</remarks>
        public decimal cb_agr_util_limit { get; set; }

        /// <summary>
        /// Agreement Year
        /// </summary>
        /// <remarks>Agreement (accounType = 19)</remarks>
        public int cb_agr_year { get; set; }

        /// <summary>
        /// Available Limit
        /// </summary>
        public decimal cb_av_limit { get; set; }

        /// <summary>
        /// Deposit Book Balance
        /// </summary>
        /// <remarks>
        /// Deposit (accountType = 3)
        /// </remarks>
        public decimal cb_bk_bal { get; set; }

        /// <summary>
        /// Blocked Limit
        /// </summary>
        /// <remarks>Agreement (accounType = 19)</remarks>
        public decimal cb_blc_limit { get; set; }

        /// <summary>
        /// Branch
        /// </summary>
        public string cb_branch { get; set; }

        /// <summary>
        /// Capital in Market Funds
        /// </summary>
        public decimal cb_cap_mrk_funds { get; set; }

        /// <summary>
        /// Capital in Repos
        /// </summary>
        public decimal cb_cap_repos { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        public string cb_ccy { get; set; }

        /// <summary>
        /// Account Check Digit
        /// </summary>
        public int cb_checkdigit { get; set; }

        /// <summary>
        /// Deposit Available Balance
        /// </summary>
        /// <remarks>
        /// Deposit (accountType = 3)
        /// </remarks>
        public decimal cb_dep_av_bal { get; set; }

        /// <summary>
        /// Deposit Blocked Balance
        /// </summary>
        /// <remarks>
        /// Deposit (accountType = 3)
        /// </remarks>
        public decimal cb_dep_blc_bal { get; set; }

        /// <summary>
        /// Deposit Forecast Balance
        /// </summary>
        /// <remarks>
        /// Deposit (accountType = 3)
        /// </remarks>
        public decimal cb_dep_frc_bal { get; set; }

        /// <summary>
        /// Deposit Unclear Balance
        /// </summary>
        public decimal cb_dep_unclear_bal { get; set; }

        /// <summary>
        /// Evaluated Balance in Mutual Funds
        /// </summary>
        public decimal cb_eval_bal { get; set; }

        /// <summary>
        /// LG Expiry Type
        /// </summary>
        public string cb_exp_type { get; set; }

        /// <summary>
        /// Face Value in Bonds
        /// </summary>
        public decimal cb_fc_val_bonds { get; set; }

        /// <summary>
        /// LG Amount
        /// </summary>
        public decimal cb_lg_amt { get; set; }

        /// <summary>
        /// LG Commissions Balance
        /// </summary>
        public decimal cb_lg_com_bal { get; set; }

        /// <summary>
        /// LG Expenses Balance
        /// </summary>
        public decimal cb_lg_exp_bal { get; set; }

        /// <summary>
        /// LG Forfeit Amount
        /// </summary>
        public decimal cb_lg_fr_amt { get; set; }

        /// <summary>
        /// LG Limit Amount
        /// </summary>
        public decimal cb_lg_lmt_amt { get; set; }

        /// <summary>
        /// LG Obligation Status
        /// </summary>
        public string cb_lg_obl_status { get; set; }

        /// <summary>
        /// LG Requested Amount
        /// </summary>
        public decimal cb_lg_req_amt { get; set; }

        /// <summary>
        /// Loan Account Balance
        /// </summary>
        /// <remarks>Loan (accountType = 4)</remarks>
        public decimal cb_ln_accbal { get; set; }

        /// <summary>
        /// Bank Loan Account Balance
        /// </summary>
        /// <remarks>Loan (accountType = 4)</remarks>
        public decimal cb_ln_bankbal { get; set; }

        /// <summary>
        /// Loan Limit Amount
        /// </summary>
        /// <remarks>
        /// Loan (accountType = 4)
        /// </remarks>
        public decimal cb_ln_limitamt { get; set; }

        /// <summary>
        /// Loan Mechanism
        /// </summary>
        /// <remarks>
        /// Loan (accountType = 4)
        /// </remarks>
        public string cb_ln_mech { get; set; }

        /// <summary>
        /// Loan Normal Balance
        /// </summary>
        /// <remarks>
        /// Loan (accountType = 4)
        /// </remarks>
        public decimal cb_ln_nrm_bal { get; set; }

        /// <summary>
        /// Loan Overdue Balance
        /// </summary>
        /// <remarks>
        /// Loan (accountType = 4)
        /// </remarks>
        public decimal cb_ln_ovd_bal { get; set; }

        /// <summary>
        /// Shares in Mutual Funds
        /// </summary>
        public decimal cb_shares { get; set; }

        /// <summary>
        /// Account Status
        /// </summary>
        /// <remarks>Agreement (accounType = 19)</remarks>
        public string cb_status { get; set; }

        /// <summary>
        /// Total Amount Paid
        /// </summary>
        /// <remarks>
        /// Loan (accountType = 4)
        /// </remarks>
        public decimal cb_tot_amt_pd { get; set; }

        /// <summary>
        /// Total Interest for Loan Account
        /// </summary>
        /// <remarks>Loan (accountType = 4)</remarks>
        public decimal cb_tot_interest { get; set; }

        /// <summary>
        /// Utilized Limit
        /// </summary>
        public decimal cb_util_limit { get; set; }

        /// <summary>
        /// Customer Id
        /// </summary>
        public string cu_id { get; set; }

        /// <summary>
        /// Additional Amount
        /// </summary>
        public decimal in_add_first_inst_amt { get; set; }

        /// <summary>
        /// Annual Premium
        /// </summary>
        public decimal in_annual_premium { get; set; }

        /// <summary>
        /// Serial Number
        /// </summary>
        public int in_applicationid { get; set; }

        /// <summary>
        /// Branch
        /// </summary>
        public string in_branch { get; set; }

        /// <summary>
        /// Not Used
        /// </summary>
        public string in_canceluser { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        public string in_ccy { get; set; }

        /// <summary>
        /// Insurance Company
        /// </summary>
        public string in_comp_id { get; set; }

        /// <summary>
        /// Insurance Company Account
        /// </summary>
        public string in_inscomp_acc { get; set; }

        /// <summary>
        /// Issue Date
        /// </summary>
        public DateTime in_issuedate { get; set; }

        /// <summary>
        /// Loading Amount
        /// </summary>
        public decimal in_loading_amnt { get; set; }

        /// <summary>
        /// Modification Date
        /// </summary>
        public DateTime in_moddate { get; set; }

        /// <summary>
        /// Monthly Premium
        /// </summary>
        public decimal in_monthly_premium { get; set; }

        /// <summary>
        /// Prorata
        /// </summary>
        public decimal in_prorata { get; set; }

        /// <summary>
        /// Remaining Amount
        /// </summary>
        public decimal in_remain_amnt { get; set; }

        /// <summary>
        /// Renewal Date
        /// </summary>
        public DateTime in_rendate { get; set; }

        /// <summary>
        /// Insurance Status
        /// </summary>
        public string in_status { get; set; }

        /// <summary>
        /// Not Used
        /// </summary>
        public string in_user { get; set; }

        /// <summary>
        /// Insurance Id
        /// </summary>
        public string insurance_id { get; set; }

        #endregion Public Properties
    }
}