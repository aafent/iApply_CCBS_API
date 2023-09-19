namespace iApplyShared.CbsModels
{
    public class CbsDownloadPositionAndDetailsResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Account Kind (iApply)
        /// </summary>
        /// <remarks>
        /// Agreement (accounType = 19)
        /// </remarks>
        public string cb_acc_kind { get; set; }

        /// <summary>
        /// Account Category
        /// </summary>
        public string cb_accd { get; set; }

        /// <summary>
        /// Account Number
        /// </summary>
        public string cb_accn { get; set; }

        /// <summary>
        /// Account Type
        /// </summary>
        public int cb_accountkind { get; set; }

        /// <summary>
        /// Account Relation
        /// </summary>
        public string cb_acountrel { get; set; }

        /// <summary>
        /// Agreement Limit Usage (iApply)
        /// </summary>
        /// <remarks>
        /// Agreement (accounType = 19)
        /// </remarks>
        public string cb_agr_lim_use { get; set; }

        /// <summary>
        /// Agreement Limit (iApply)
        /// </summary>
        /// <remarks>
        /// Agreement (accounType = 19)
        /// </remarks>
        public decimal cb_agr_limit { get; set; }

        /// <summary>
        /// Agreement Signing Date (iApply)
        /// </summary>
        /// <remarks>
        /// Agreement (accounType = 19)
        /// </remarks>
        public DateTime cb_agr_sign_dt { get; set; }

        /// <summary>
        /// Agreement Utilised Limit (iApply)
        /// </summary>
        /// <remarks>
        /// Agreement (accounType = 19)
        /// </remarks>
        public decimal cb_agr_util_limit { get; set; }

        /// <summary>
        /// Agreement Year (iApply)
        /// </summary>
        /// <remarks>
        /// Agreement (accounType = 19)
        /// </remarks>
        public int cb_agr_year { get; set; }

        /// <summary>
        /// Available Limit (iApply)
        /// </summary>
        public decimal cb_av_limit { get; set; }

        /// <summary>
        /// Available Balance
        /// </summary>
        public decimal cb_avbalan { get; set; }

        /// <summary>
        /// Balance
        /// </summary>
        public decimal cb_balan { get; set; }

        /// <summary>
        /// Deposit Book Balance
        /// Deposit (accountType = 3)
        /// </summary>
        public decimal cb_bk_bal { get; set; }

        /// <summary>
        /// Blocked Limit (iApply)
        /// </summary>
        /// <remarks>
        /// Agreement (accounType = 19)
        /// </remarks>
        public decimal cb_blc_limit { get; set; }

        /// <summary>
        /// Branch (iApply)
        /// </summary>
        public string cb_branch { get; set; }

        /// <summary>
        /// Capital in Market Funds
        /// </summary>
        /// <remarks>
        /// Securities (accountType = 18)
        /// </remarks>
        public decimal cb_cap_mrk_funds { get; set; }

        /// <summary>
        /// Capital in Repos
        /// </summary>
        public decimal cb_cap_repos { get; set; }

        /// <summary>
        /// Capital Outstanding Amount (iApply)
        /// </summary>
        public decimal cb_capitalamt { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        /// <remarks>If currency description is null, the currency id</remarks>
        public string cb_ccy { get; set; }

        /// <summary>
        /// Account Check Digit
        /// </summary>
        public int cb_checkdigit { get; set; }

        /// <summary>
        /// Customer Last Name
        /// </summary>
        public string cb_cu_lname { get; set; }

        /// <summary>
        /// Customer First Name
        /// </summary>
        public string cb_cus_fname { get; set; }

        /// <summary>
        /// Customer Check Digit
        /// </summary>
        public int cb_cuscd { get; set; }

        /// <summary>
        /// Customer CBS Id
        /// </summary>
        public string cb_cusnum { get; set; }

        /// <summary>
        /// Deposit Available Balance
        /// Deposit (accountType = 3)
        /// </summary>
        public decimal cb_dep_av_bal { get; set; }

        /// <summary>
        /// Deposit Blocked Balance
        /// Deposit (accountType = 3)
        /// </summary>
        public decimal cb_dep_blc_bal { get; set; }

        /// <summary>
        /// Deposit Forecast Balance
        /// Deposit (accountType = 3)
        /// </summary>
        public decimal cb_dep_frc_bal { get; set; }

        /// <summary>
        /// Deposit Unclear Balance
        /// Deposit (accountType = 3)
        /// </summary>
        public decimal cb_dep_unclear_bal { get; set; }

        /// <summary>
        /// Evaluated Balance in Mutual Funds
        /// </summary>
        /// <remarks>
        /// Securities (accountType = 18)
        /// </remarks>
        public decimal cb_eval_bal { get; set; }

        /// <summary>
        /// LG Expiry Type
        /// </summary>
        /// <remarks>
        /// Letter of Guarantee (accountType = 14)
        /// </remarks>
        public string cb_exp_type { get; set; }

        /// <summary>
        /// Expiry Date
        /// </summary>
        /// <remarks>If date1 is null, then date9
        /// If date9 is null, then date15
        /// If date15 is null, then date4
        /// If date4 is null, then date5
        /// If date5 is null, then date7
        /// If date7 is null, then date8</remarks>
        public DateTime cb_expdt { get; set; }

        /// <summary>
        /// Face Value in Bonds
        /// </summary>
        /// <remarks>
        /// Securities (accountType = 18)
        /// </remarks>
        public decimal cb_fc_val_bonds { get; set; }

        /// <summary>
        /// Monthly Installment Amount (iApply)
        /// </summary>
        /// <remarks>
        /// If amount27 is zero then amount23
        /// </remarks>
        public decimal cb_lastinstamt { get; set; }

        /// <summary>
        /// LG Amount
        /// Letter of Guarantee (accountType = 14)
        /// </summary>
        public decimal cb_lg_amt { get; set; }

        /// <summary>
        /// LG Commissions Balance
        /// Letter of Guarantee (accountType = 14)
        /// </summary>
        public decimal cb_lg_com_bal { get; set; }

        /// <summary>
        /// LG Expenses Balance
        /// Letter of Guarantee (accountType = 14)
        /// </summary>
        public decimal cb_lg_exp_bal { get; set; }

        /// <summary>
        /// LG Forfeit Amount
        /// Letter of Guarantee (accountType = 14)
        /// </summary>
        public decimal cb_lg_fr_amt { get; set; }

        /// <summary>
        /// LG Limit Amount
        /// Letter of Guarantee (accountType = 14)
        /// </summary>
        public decimal cb_lg_lmt_amt { get; set; }

        /// <summary>
        /// LG Obligation Status
        /// </summary>
        /// <remarks>
        /// Letter of Guarantee (accountType = 14)
        /// </remarks>
        public string cb_lg_obl_status { get; set; }

        /// <summary>
        /// LG Requested Amount
        /// </summary>
        /// <remarks>
        /// Letter of Guarantee (accountType = 14)
        /// </remarks>
        public decimal cb_lg_req_amt { get; set; }

        /// <summary>
        /// Account Limit
        /// </summary>
        public decimal cb_limit { get; set; }

        /// <summary>
        /// Loan Account Balance
        /// Loan (accountType = 4)
        /// </summary>
        public decimal cb_ln_accbal { get; set; }

        /// <summary>
        /// Bank Loan Account Balance
        /// Loan (accountType = 4)
        /// </summary>
        public decimal cb_ln_bankbal { get; set; }

        /// <summary>
        /// Loan Limit Amount
        /// Loan (accountType = 4)
        /// </summary>
        public decimal cb_ln_limitamt { get; set; }

        /// <summary>
        /// Loan Mechanism
        /// Loan (accountType = 4)
        /// </summary>
        public string cb_ln_mech { get; set; }

        /// <summary>
        /// Loan Normal Balance
        /// Loan (accountType = 4)
        /// </summary>
        public decimal cb_ln_nrm_bal { get; set; }

        /// <summary>
        /// Loan Overdue Balance
        /// Loan (accountType = 4)
        /// </summary>
        public decimal cb_ln_ovd_bal { get; set; }

        /// <summary>
        /// Open Date
        /// </summary>
        public DateTime cb_opendt { get; set; }

        /// <summary>
        /// Overdue Amount
        /// </summary>
        public decimal cb_outamt { get; set; }

        /// <summary>
        /// Not Used (iApply)
        /// </summary>
        public decimal cb_outint { get; set; }

        /// <summary>
        /// Product
        /// </summary>
        public int cb_prdcat { get; set; }

        /// <summary>
        /// Product Description
        /// </summary>
        public string cb_proddesc { get; set; }

        /// <summary>
        /// Securities Evaluation
        /// </summary>
        public decimal cb_seceval { get; set; }

        /// <summary>
        /// Not Used (iApply)
        /// </summary>
        /// <remarks>
        /// For all the banks except HF
        /// </remarks>
        public string cb_self { get; set; }

        /// <summary>
        /// Shares in Mutual Funds
        /// </summary>
        /// <remarks>
        /// Securities (accountType = 18)
        /// </remarks>
        public decimal cb_shares { get; set; }

        /// <summary>
        /// Account Status (iApply)
        /// </summary>
        /// <remarks>
        /// If cb_accd = 3 then code from grp = G0223
        /// If cb_accd = 5 then code from grp = G0221
        /// If cb_accd = 6 then code from grp = G0222
        /// </remarks>
        public string cb_status { get; set; }

        /// <summary>
        /// Total Amount Paid
        /// Loan (accountType = 4)
        /// </summary>
        public decimal cb_tot_amt_pd { get; set; }

        /// <summary>
        /// Total Interest for Loan Account
        /// Loan (accountType = 4)
        /// </summary>
        public decimal cb_tot_interest { get; set; }

        /// <summary>
        /// Unclear Balance
        /// </summary>
        public decimal cb_unbalan { get; set; }

        /// <summary>
        /// Utilized Limit (iApply)
        /// </summary>
        public decimal cb_util_limit { get; set; }

        /// <summary>
        /// Application Id (iApply)
        /// </summary>
        /// <remarks>
        /// If OutGrpOutGrmSearchCustPositionEntryType then text30 else null
        /// </remarks>
        public string cbs_la_id { get; set; }

        /// <summary>
        /// Customer Id (iApply)
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
        /// <remarks>
        /// from ValidateAccount
        /// </remarks>
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