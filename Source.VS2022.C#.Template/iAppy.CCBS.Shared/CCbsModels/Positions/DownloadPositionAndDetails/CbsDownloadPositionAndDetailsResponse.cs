namespace iApplyShared.CbsModels
{
    public class CbsDownloadPositionAndDetailsResponse : CommonResponseModel
    {
        #region Public Properties
        public List<DownloadLoanInsurance> Insurances { get; set; }

        /// <summary>
        /// Customer CBS Id
        /// Data Type: varchar (15)
        /// CBS: OutGrpOutGrmSearchCustPositionCustId
        /// </summary>
        public string cb_cusnum { get; set; }

        /// <summary>
        /// Customer Check Digit
        /// Data Type: integer
        /// CBS: OutGrpOutGrmSearchCustPositionCustCd
        /// </summary>
        public int cb_cuscd { get; set; }

        /// <summary>
        /// Customer First Name
        /// Data Type: varchar (30)
        /// CBS: OutGrpOutGrmSearchCustPositionCustFirstName
        /// </summary>
        public string cb_cus_fname { get; set; }

        /// <summary>
        /// Customer Last Name
        /// Data Type: varchar (70)
        /// CBS: OutGrpOutGrmSearchCustPositionCustSurname
        /// </summary>
        public string cb_cu_lname { get; set; }

        /// <summary>
        /// Account Relation
        /// Data Type: varchar (20)
        /// CBS: OutGrpOutGrmSearchCustPositionNumber16
        /// </summary>
        public string cb_acountrel { get; set; }

        /// <summary>
        /// Account Type
        /// Data Type: integer
        /// CBS: OutGrpOutGrmSearchCustPositionPrftSystem
        /// </summary>
        public int cb_accountkind { get; set; }

        /// <summary>
        /// Account Category
        /// Data Type: varchar (10)
        /// CBS: OutGrpOutGrmSearchCustPositionEntryType
        /// </summary>
        public string cb_accd { get; set; }

        /// <summary>
        /// Account Number
        /// Data Type: varchar (30)
        /// CBS: OutGrpOutGrmSearchCustPositionAccountNumber
        /// </summary>
        public string cb_accn { get; set; }

        /// <summary>
        /// Account Check Digit
        /// Data Type: integer
        /// CBS: OutGrpOutGrmSearchCustPositionAccountCd
        /// </summary>
        public int cb_checkdigit { get; set; }

        /// <summary>
        /// Currency
        /// Data Type: varchar (10)
        /// CBS: OutGrpOutGrmSearchCustPositionCurrencyDesc OutGrpOutGrmSearchCustPositionCurrencyId
        /// Value: If currency description is null, the currency id
        /// </summary>
        public string cb_ccy { get; set; }

        /// <summary>
        /// Balance
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpOutGrmSearchCustPositionAmount14
        /// </summary>
        public decimal cb_balan { get; set; }

        /// <summary>
        /// Product
        /// Data Type: integer
        /// CBS: OutGrpOutGrmSearchCustPositionProductId
        /// </summary>
        public int cb_prdcat { get; set; }

        /// <summary>
        /// Product Description
        /// Data Type: varchar (100)
        /// CBS: OutGrpOutGrmSearchCustPositionProductDesc
        /// </summary>
        public string cb_proddesc { get; set; }

        /// <summary>
        /// Available Balance
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpOutGrmSearchCustPositionAmount10
        /// </summary>
        public decimal cb_avbalan { get; set; }


        /// <summary>
        /// Account Limit
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpOutGrmSearchCustPositionAmount20
        /// </summary>
        public decimal cb_limit { get; set; }

        /// <summary>
        /// Overdue Amount
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpOutGrmSearchCustPositionAmount15
        /// </summary>
        public decimal cb_outamt { get; set; }

        /// <summary>
        /// Unclear Balance
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpOutGrmSearchCustPositionAmount22
        /// </summary>
        public decimal cb_unbalan { get; set; }

        /// <summary>
        /// Securities Evaluation
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpOutGrmSearchCustPositionAmount23
        /// </summary>
        public decimal cb_seceval { get; set; }

        /// <summary>
        /// Open Date
        /// Data Type: datetime
        /// CBS: OutGrpOutGrmSearchCustPositionDate8
        /// </summary>
        public DateTime cb_opendt { get; set; }

        /// <summary>
        /// Expiry Date
        /// Data Type: datetime
        /// CBS: OutGrpOutGrmSearchCustPositionDate1 OutGrpOutGrmSearchCustPositionDate9 OutGrpOutGrmSearchCustPositionDate15
        ///      OutGrpOutGrmSearchCustPositionDate4 OutGrpOutGrmSearchCustPositionDate5 OutGrpOutGrmSearchCustPositionDate7
        ///      OutGrpOutGrmSearchCustPositionDate8
        /// Value: If date1 is null then date9, if date9 is null then date15, if date15 is null then date4, if date4 is null then date5,
        ///        if date5 is null then date7, if date7 is null then date8
        /// </summary>
        public DateTime cb_expdt { get; set; }

        /// <summary>
        /// Application Id (iApply)
        /// Data Type: varchar (15)
        /// CBS: OutGrpOutGrmSearchCustPositionText30
        /// Value: If OutGrpOutGrmSearchCustPositionEntryType then text30 else null
        /// </summary>
        public string cbs_la_id { get; set; }

        /// <summary>
        /// Capital Outstanding Amount
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpOutGrmSearchCustPositionAmount26
        /// </summary>
        public decimal cb_capitalamt { get; set; }

        /// <summary>
        /// Monthly Installment Amount
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpOutGrmSearchCustPositionAmount27 OutGrpOutGrmSearchCustPositionAmount23
        /// Value: If amount27 is zero then amount23
        /// </summary>
        public decimal cb_lastinstamt { get; set; }

        /// <summary>
        /// Not Used
        /// Data Type: decimal (19,3)
        /// CBS: OutGrpOutGrmSearchCustPositionAmount9
        /// </summary>
        public decimal cb_outint { get; set; }

        /// <summary>
        /// Not Used
        /// Data Type: varchar (200)
        /// CBS: OutGrpOutGrmSearchCustPositionFlag09
        /// </summary>
        public string cb_status1 { get; set; }

        /// <summary>
        /// Not Used
        /// Data Type: varchar (20)
        /// CBS: OutGrpOutGrmSearchCustPositionFlag10
        /// Value: For all the banks except HF
        /// </summary>
        public string cb_self { get; set; }

        /// <summary>
        /// Account Status
        /// Data Type: varchar (10)
        /// CBS: OutGrpOutGrmSearchCustPositionText6 OutGrpOutGrmSearchCustPositionText8 OutGrpOutGrmSearchCustPositionText9
        /// Value: If cb_accd = 3 then code from grp =G0223, if cb_accd = 5 then code from grp =G0221, if cb_accd = 6 then code from grp =G0222
        /// </summary>
        public string cb_status { get; set; }

        /// <summary>
        /// Customer Id
        /// Data Type: varchar (15)
        /// CBS: customerId
        /// </summary>
        public string cu_id { get; set; }

        /// <summary>
        /// Branch
        /// Data Type: varchar (10)
        /// CBS: OutMonitoringUnitUnitCode
        /// </summary>
        public string cb_branch { get; set; }

        /// <summary>
        /// Available Limit
        /// Data Type: decimal (19,3)
        /// CBS: OutAccAvailableIefSuppliedAmount
        /// </summary>
        public decimal cb_av_limit { get; set; }

        /// <summary>
        /// Utilized Limit
        /// Data Type: decimal (19,3)
        /// CBS: OutAccUtilizedIefSuppliedAmount
        /// </summary>
        public decimal cb_util_limit { get; set; }

        /// <summary>
        /// Account Kind (Agreement, accounType = 19)
        /// Data Type: varchar (15)
        /// CBS: OutAgreementAgreementAccKind
        /// </summary>
        public string cb_acc_kind { get; set; }

        /// <summary>
        /// Blocked Limit (Agreement, accounType = 19)
        /// Data Type: decimal (19,3)
        /// CBS: OutAgreementAgreementAgrBlockedLimit
        /// </summary>
        public decimal cb_blc_limit { get; set; }

        /// <summary>
        /// Agreement Limit (Agreement, accounType = 19)
        /// Data Type: decimal (19,3)
        /// CBS: OutAgreementAgreementAgrLimit
        /// </summary>
        public decimal cb_agr_limit { get; set; }

        /// <summary>
        /// Agreement Limit Usage (Agreement, accounType = 19)
        /// Data Type: varchar (15)
        /// CBS: OutAgreementAgreementAgrLimitInd
        /// </summary>
        public string cb_agr_lim_use { get; set; }

        /// <summary>
        /// Agreement Signing Date (Agreement, accounType = 19)
        /// Data Type: datetime
        /// CBS: OutAgreementAgreementAgrSigningDt
        /// </summary>
        public DateTime cb_agr_sign_dt { get; set; }

        /// <summary>
        /// Agreement Utilised Limit (Agreement, accounType = 19)
        /// Data Type: decimal (19,3)
        /// CBS: OutAgreementAgreementAgrUtilisedLimit
        /// </summary>
        public decimal cb_agr_util_limit { get; set; }

        /// <summary>
        /// Agreement Year (Agreement, accounType = 19)
        /// Data Type: integer
        /// CBS: OutAgreementAgreementAgrYear
        /// </summary>
        public int cb_agr_year { get; set; }

        /// <summary>
        /// Loan Account Balance (Loan, accountType = 4)
        /// Data Type: decimal (19,3)
        /// CBS: OutLnsBalancesLoanAccountDrvWorkAccountBal
        /// </summary>
        public decimal cb_ln_accbal { get; set; }

        /// <summary>
        /// Bank Loan Account Balance (Loan, accountType = 4)
        /// Data Type: decimal (19,3)
        /// CBS: OutLnsBalancesLoanAccountDrvWorkAccBankBal
        /// </summary>
        public decimal cb_ln_bankbal { get; set; }

        /// <summary>
        /// Total Interest for Loan Account (Loan, accountType = 4)
        /// Data Type: decimal (19,3)
        /// CBS: OutLnsBalancesLoanAccountDrvWorkLstYrIntDbAmn
        /// </summary>
        public decimal cb_tot_interest { get; set; }

        /// <summary>
        /// Loan Normal Balance (Loan, accountType = 4)
        /// Data Type: decimal (19,3)
        /// CBS: OutLnsBalancesLoanAccountDrvWorkNrmAccountBal
        /// </summary>
        public decimal cb_ln_nrm_bal { get; set; }

        /// <summary>
        /// Loan Overdue Balance (Loan, accountType = 4)
        /// Data Type: decimal (19,3)
        /// CBS: OutLnsBalancesLoanAccountDrvWorkOvAccountBal
        /// </summary>
        public decimal cb_ln_ovd_bal { get; set; }

        /// <summary>
        /// Total Amount Paid (Loan, accountType = 4)
        /// Data Type: decimal (19,3)
        /// CBS: OutLnsBalancesLoanAccountDrvWorkTotPaymentAmn
        /// </summary>
        public decimal cb_tot_amt_pd { get; set; }

        /// <summary>
        /// Loan Limit Amount (Loan, accountType = 4)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLoanAccountAccLimitAmn
        /// </summary>
        public decimal cb_ln_limitamt { get; set; }

        /// <summary>
        /// Loan Mechanism (Loan, accountType = 4)
        /// Data Type: varchar (15)
        /// CBS: OutSelectedLoanAccountAccMechanism
        /// </summary>
        public string cb_ln_mech { get; set; }

        /// <summary>
        /// Deposit Available Balance (Deposit, accountType = 3)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedDepositAccountAvailableBalance
        /// </summary>
        public decimal cb_dep_av_bal { get; set; }

        /// <summary>
        /// Deposit Blocked Balance (Deposit, accountType = 3)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedDepositAccountBlockedBalance
        /// </summary>
        public decimal cb_dep_blc_bal { get; set; }

        /// <summary>
        /// Deposit Book Balance (Deposit, accountType = 3)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedDepositAccountBookBalance
        /// </summary>
        public decimal cb_bk_bal { get; set; }

        /// <summary>
        /// Deposit Forecast Balance (Deposit, accountType = 3)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedDepositAccountForecastBalance
        /// </summary>
        public decimal cb_dep_frc_bal { get; set; }

        /// <summary>
        /// Deposit Unclear Balance (Deposit, accountType = 3)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedDepositAccountUnclearBalance
        /// </summary>
        public decimal cb_dep_unclear_bal { get; set; }

        /// <summary>
        /// LG Limit Amount (Letter of Guarantee, accountType = 14)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLgLgAccountAccLimitAmn
        /// </summary>
        public decimal cb_lg_lmt_amt { get; set; }

        /// <summary>
        /// LG Commissions Balance (Letter of Guarantee, accountType = 14)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLgLgAccountCommissionBal
        /// </summary>
        public decimal cb_lg_com_bal { get; set; }

        /// <summary>
        /// LG Forfeit Amount (Letter of Guarantee, accountType = 14)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLgLgAccountDefaultAmn
        /// </summary>
        public decimal cb_lg_fr_amt { get; set; }

        /// <summary>
        /// LG Expenses Balance (Letter of Guarantee, accountType = 14)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLgLgAccountExpenseBal
        /// </summary>
        public decimal cb_lg_exp_bal { get; set; }

        /// <summary>
        /// LG Amount (Letter of Guarantee, accountType = 14)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLgLgAccountLgAmountBal
        /// </summary>
        public decimal cb_lg_amt { get; set; }

        /// <summary>
        /// LG Expiry Type (Letter of Guarantee, accountType = 14)
        /// Data Type: varchar (15)
        /// CBS: OutSelectedLgLgAccountExpirationType
        /// </summary>
        public string cb_exp_type { get; set; }

        /// <summary>
        /// LG Obligation Status (Letter of Guarantee, accountType = 14)
        /// Data Type: varchar (15)
        /// CBS: OutSelectedLgLgAccountObligationStatus
        /// </summary>
        public string cb_lg_obl_status { get; set; }

        /// <summary>
        /// LG Requested Amount (Letter of Guarantee, accountType = 14)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLgLgAccountRqDefaultAmn
        /// </summary>
        public decimal cb_lg_req_amt { get; set; }


        /// <summary>
        /// TF Expiry Type (Trade Finance, accountType = 37)
        /// Data Type: varchar (15)
        /// CBS: OutSelectedLgLgAccountExpirationType
        /// </summary>
        public string cb_exp_type_tf { get; set; }

        /// <summary>
        /// TF Amount (Trade Finance, accountType = 37)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLgLgAccountLgAmountBal
        /// </summary>
        public decimal cb_lg_com_bal_tf { get; set; }

        /// <summary>
        /// Account Status (Letter of Credit, accountType = 39)
        /// Data Type: varchar (10)
        /// CBS: OutSelectedLgLgAccountAccStatus
        /// </summary>
        public string cb_status_lc { get; set; }

        /// <summary>
        /// LC Limit Amount (Letter of Credit, accountType = 39)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLgLgAccountAccLimitAmn
        /// </summary>
        public decimal cb_lg_lmt_amt_lc { get; set; }

        /// <summary>
        /// LC Initial Amount (Letter of Credit, accountType = 39)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLgLgAccountLgInitialAmn
        /// </summary>
        public decimal cb_lg_exp_bal_lc { get; set; }

        /// <summary>
        /// LC Total Issued Amount (Letter of Credit, accountType = 39)
        /// Data Type: decimal (19,3)
        /// CBS: OutSelectedLgLgAccountLgAmountBal
        /// </summary>
        public decimal cb_lg_com_bal_lc { get; set; }

        /// <summary>
        /// LC Obligation Status (Letter of Credit, accountType = 39)
        /// Data Type: varchar (15)
        /// CBS: OutSelectedLgLgAccountObligationStatus
        /// </summary>
        public string cb_lg_obl_status_lc { get; set; }

        /// <summary>
        /// Capital in Market Funds (Securities, accountType = 18)
        /// Data Type: decimal (19,3)
        /// CBS: OutTotalsScrAccountCustomerPositionTotalsScrAkddTot
        /// </summary>
        public decimal cb_cap_mrk_funds { get; set; }

        /// <summary>
        /// Evaluated Balance in Mutual Funds (Securities, accountType = 18)
        /// Data Type: decimal (19,3)
        /// CBS: OutTotalsScrAccountCustomerPositionTotalsScrAkEvalTot
        /// </summary>
        public decimal cb_eval_bal { get; set; }


        /// <summary>
        /// Shares in Mutual Funds (Securities, accountType = 18)
        /// Data Type: decimal (19,3)
        /// CBS: OutTotalsScrAccountCustomerPositionTotalsScrAkShrTot
        /// </summary>
        public decimal cb_shares { get; set; }

        /// <summary>
        /// Face Value in Bonds (Securities, accountType = 18)
        /// Data Type: decimal (19,3)
        /// CBS: OutTotalsScrAccountCustomerPositionTotalsScrBondTot
        /// </summary>
        public decimal cb_fc_val_bonds { get; set; }

        /// <summary>
        /// Capital in Repos (Securities, accountType = 18)
        /// Data Type: decimal (19,3)
        /// CBS: OutTotalsScrAccountCustomerPositionTotalsScrRepoTot
        /// </summary>
        public decimal cb_cap_repos { get; set; }

        #endregion Public Properties
    }
}