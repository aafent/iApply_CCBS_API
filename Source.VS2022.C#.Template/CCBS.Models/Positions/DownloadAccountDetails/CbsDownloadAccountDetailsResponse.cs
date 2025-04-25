namespace CCBS.Models
{
    public class CbsDownloadAccountDetailsResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Seq: 10
        /// Entity: cr_cucoba_det
        /// Description: Account Kind
        /// Data Type: varchar (15)
        /// Notes: Agreement (accounType = 19)
        /// CBS: OutAgreementAgreementAccKind
        /// </summary>
        public string cb_acc_kind { get; set; }

        /// <summary>
        /// Seq: 3
        /// Entity: cr_cucoba_det | cr_cucoba_ins
        /// Description: Account Number
        /// Data Type: varchar (30)
        /// Notes: N/A | from ValidateAccount
        /// CBS: OutSelectedProfitsAccountAccountNumber
        /// </summary>
        public string cb_accn { get; set; }

        /// <summary>
        /// Seq: 2
        /// Entity: cr_cucoba_det | cr_cucoba_ins
        /// Description: Account Type
        /// Data Type: integer
        /// Notes: N/A | from ValidateAccounts
        /// CBS: accountType | OutSelectedProfitsAccountPrftSystem
        /// </summary>
        public int cb_accountkind { get; set; }

        /// <summary>
        /// Seq: 13
        /// Entity: cr_cucoba_det
        /// Description: Agreement Limit Usage
        /// Data Type: varchar (15)
        /// Notes: Agreement (accounType = 19)
        /// CBS: OutAgreementAgreementAgrLimitInd
        /// </summary>
        public string cb_agr_lim_use { get; set; }

        /// <summary>
        /// Seq: 12
        /// Entity: cr_cucoba_det
        /// Description: Agreement Limit
        /// Data Type: decimal (19,3)
        /// Notes: Agreement (accounType = 19)
        /// CBS: OutAgreementAgreementAgrLimit
        /// </summary>
        public decimal cb_agr_limit { get; set; }

        /// <summary>
        /// Seq: 14
        /// Entity: cr_cucoba_det
        /// Description: Agreement Signing Date
        /// Data Type: datetime
        /// Notes: Agreement (accounType = 19)
        /// CBS: OutAgreementAgreementAgrSigningDt
        /// </summary>
        public DateTime cb_agr_sign_dt { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq: 15
        /// Entity: cr_cucoba_det
        /// Description: Agreement Utilised Limit
        /// Data Type: decimal (19,3)
        /// Notes: Agreement (accounType = 19)
        /// CBS: OutAgreementAgreementAgrUtilisedLimit
        /// </summary>
        public decimal cb_agr_util_limit { get; set; }

        /// <summary>
        /// Seq: 16
        /// Entity: cr_cucoba_det
        /// Description: Agreement Year
        /// Data Type: integer
        /// Notes: Agreement (accounType = 19)
        /// CBS: OutAgreementAgreementAgrYear
        /// </summary>
        public int cb_agr_year { get; set; }

        /// <summary>
        /// Seq: 6
        /// Entity: cr_cucoba_det
        /// Description: Available Limit
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutAccAvailableIefSuppliedAmount
        /// </summary>
        public decimal cb_av_limit { get; set; }

        /// <summary>
        /// Seq: 28
        /// Entity: cr_cucoba_det
        /// Description: Deposit Book Balance
        /// Data Type: decimal (19,3)
        /// Notes: Deposit (accountType = 3)
        /// CBS: OutSelectedDepositAccountBookBalance
        /// </summary>
        public decimal cb_bk_bal { get; set; }

        /// <summary>
        /// Seq: 11
        /// Entity: cr_cucoba_det
        /// Description: Blocked Limit
        /// Data Type: decimal (19,3)
        /// Notes: Agreement (accounType = 19)
        /// CBS: OutAgreementAgreementAgrBlockedLimit
        /// </summary>
        public decimal cb_blc_limit { get; set; }

        /// <summary>
        /// Seq: 5
        /// Entity: cr_cucoba_det
        /// Description: Branch
        /// Data Type: varchar (10)
        /// Notes: N/A
        /// CBS: OutMonitoringUnitUnitCode
        /// </summary>
        public string cb_branch { get; set; }

        /// <summary>
        /// Seq: 50
        /// Entity: cr_cucoba_det
        /// Description: Capital in Market Funds
        /// Data Type: decimal (19,3)
        /// Notes: Securities (accountType = 18)
        /// CBS: OutTotalsScrAccountCustomerPositionTotalsScrAkddTot
        /// </summary>
        public decimal cb_cap_mrk_funds { get; set; }

        /// <summary>
        /// Seq: 54
        /// Entity: cr_cucoba_det
        /// Description: Capital in Repos
        /// Data Type: decimal (19,3)
        /// Notes: Securities (accountType = 18)
        /// CBS: OutTotalsScrAccountCustomerPositionTotalsScrRepoTot
        /// </summary>
        public decimal cb_cap_repos { get; set; }

        /// <summary>
        /// Seq: 8
        /// Entity: cr_cucoba_det
        /// Description: Currency
        /// Data Type: varchar (10)
        /// Notes: N/A
        /// CBS: OutSelectedProfitsAccountLimitCurrency
        /// </summary>
        public string cb_ccy { get; set; }

        /// <summary>
        /// Seq: 4
        /// Entity: cr_cucoba_det | cr_cucoba_ins
        /// Description: Account Check Digit
        /// Data Type: integer
        /// Notes: N/A | from ValidateAccount
        /// CBS: OutSelectedProfitsAccountAccountCd
        /// </summary>
        public int cb_checkdigit { get; set; }

        /// <summary>
        /// Seq: 26
        /// Entity: cr_cucoba_det
        /// Description: Deposit Available Balance
        /// Data Type: decimal (19,3)
        /// Notes: Deposit (accountType = 3)
        /// CBS: OutSelectedDepositAccountAvailableBalance
        /// </summary>
        public decimal cb_dep_av_bal { get; set; }

        /// <summary>
        /// Seq: 27
        /// Entity: cr_cucoba_det
        /// Description: Deposit Blocked Balance
        /// Data Type: decimal (19,3)
        /// Notes: Deposit (accountType = 3)
        /// CBS: OutSelectedDepositAccountBlockedBalance
        /// </summary>
        public decimal cb_dep_blc_bal { get; set; }

        /// <summary>
        /// Seq: 29
        /// Entity: cr_cucoba_det
        /// Description: Deposit Forecast Balance
        /// Data Type: decimal (19,3)
        /// Notes: Deposit (accountType = 3)
        /// CBS: OutSelectedDepositAccountForecastBalance
        /// </summary>
        public decimal cb_dep_frc_bal { get; set; }

        /// <summary>
        /// Seq: 30
        /// Entity: cr_cucoba_det
        /// Description: Deposit Unclear Balance
        /// Data Type: decimal (19,3)
        /// Notes: Deposit (accountType = 3)
        /// CBS: OutSelectedDepositAccountUnclearBalance
        /// </summary>
        public decimal cb_dep_unclear_bal { get; set; }

        /// <summary>
        /// Seq: 51
        /// Entity: cr_cucoba_det
        /// Description: Evaluated Balance in Mutual Funds
        /// Data Type: decimal (19,3)
        /// Notes: Securities (accountType = 18)
        /// CBS: OutTotalsScrAccountCustomerPositionTotalsScrAkEvalTot
        /// </summary>
        public decimal cb_eval_bal { get; set; }

        /// <summary>
        /// Seq: 37
        /// Entity: cr_cucoba_det
        /// Description: LG Expiry Type
        /// Data Type: varchar (15)
        /// Notes: Letter of Guarantee (accountType = 14) | Trade Finance (accountType = 37)
        /// CBS: OutSelectedLgLgAccountExpirationType
        /// </summary>
        public string cb_exp_type { get; set; }

        /// <summary>
        /// Seq: 53
        /// Entity: cr_cucoba_det
        /// Description: Face Value in Bonds
        /// Data Type: decimal (19,3)
        /// Notes: Securities (accountType = 18)
        /// CBS: OutTotalsScrAccountCustomerPositionTotalsScrBondTot
        /// </summary>
        public decimal cb_fc_val_bonds { get; set; }

        /// <summary>
        /// Seq: 36
        /// Entity: cr_cucoba_det
        /// Description: LG Amount
        /// Data Type: decimal (19,3)
        /// Notes: Letter of Guarantee (accountType = 14)
        /// CBS: OutSelectedLgLgAccountLgAmountBal
        /// </summary>
        public decimal cb_lg_amt { get; set; }

        /// <summary>
        /// Seq: 33
        /// Entity: cr_cucoba_det
        /// Description: LG Commissions Balance | TF Amount | LC Total Issued Amount
        /// Data Type: decimal (19,3)
        /// Notes: Letter of Guarantee (accountType = 14) | Trade Finance (accountType = 37) | Letter of Credit (accountType = 39)
        /// CBS: OutSelectedLgLgAccountCommissionBal | OutSelectedLgLgAccountLgAmountBal | OutSelectedLgLgAccountLgAmountBal
        /// </summary>
        public decimal cb_lg_com_bal { get; set; }

        /// <summary>
        /// Seq: 35
        /// Entity: cr_cucoba_det
        /// Description: LG Expenses Balance | LC Initial Amount
        /// Data Type: decimal (19,3)
        /// Notes: Letter of Guarantee (accountType = 14) |  Letter of Credit (accountType = 39)
        /// CBS: OutSelectedLgLgAccountExpenseBal | OutSelectedLgLgAccountLgInitialAmn
        /// </summary>
        public decimal cb_lg_exp_bal { get; set; }

        /// <summary>
        /// Seq: 34
        /// Entity: cr_cucoba_det
        /// Description: LG Forfeit Amount
        /// Data Type: decimal (19,3)
        /// Notes: Letter of Guarantee (accountType = 14)
        /// CBS: OutSelectedLgLgAccountDefaultAmn
        /// </summary>
        public decimal cb_lg_fr_amt { get; set; }

        /// <summary>
        /// Seq: 32 | 41 | 46
        /// Entity: cr_cucoba_det
        /// Description: LG Limit Amount | TF Used Amount | LC Limit Amount
        /// Data Type: decimal (19,3)
        /// Notes: Letter of Guarantee (accountType = 14) | Trade Finance (accountType = 37) | Letter of Credit (accountType = 39)
        /// CBS: OutSelectedLgLgAccountAccLimitAmn
        /// </summary>
        public decimal cb_lg_lmt_amt { get; set; }

        /// <summary>
        /// Seq: 38 | 39
        /// Entity: cr_cucoba_det
        /// Description: LG Obligation Status
        /// Data Type: varchar (15)
        /// Notes: Letter of Guarantee (accountType = 14) | Letter of Credit (accountType = 39)
        /// CBS: OutSelectedLgLgAccountObligationStatus
        /// </summary>
        public string cb_lg_obl_status { get; set; }

        /// <summary>
        /// Seq: 39
        /// Entity: cr_cucoba_det
        /// Description: LG Requested Amount
        /// Data Type: decimal (19,3)
        /// Notes: Letter of Guarantee (accountType = 14)
        /// CBS: OutSelectedLgLgAccountRqDefaultAmn
        /// </summary>
        public decimal cb_lg_req_amt { get; set; }

        /// <summary>
        /// Seq: 17
        /// Entity: cr_cucoba_det
        /// Description: Loan Account Balance
        /// Data Type: decimal (19,3)
        /// Notes: Loan (accountType = 4)
        /// CBS: OutLnsBalancesLoanAccountDrvWorkAccountBal
        /// </summary>
        public decimal cb_ln_accbal { get; set; }

        /// <summary>
        /// Seq: 18
        /// Entity: cr_cucoba_det
        /// Description: Bank Loan Account Balance
        /// Data Type: decimal (19,3)
        /// Notes: Loan (accountType = 4)
        /// CBS: OutLnsBalancesLoanAccountDrvWorkAccBankBal
        /// </summary>
        public decimal cb_ln_bankbal { get; set; }

        /// <summary>
        /// Seq: 23
        /// Entity: cr_cucoba_det
        /// Description: Loan Limit Amount
        /// Data Type: decimal (19,3)
        /// Notes: Loan (accountType = 4)
        /// CBS: OutSelectedLoanAccountAccLimitAmn
        /// </summary>
        public decimal cb_ln_limitamt { get; set; }

        /// <summary>
        /// Seq: 24
        /// Entity: cr_cucoba_det
        /// Description: Loan Mechanism
        /// Data Type: varchar (15)
        /// Notes: Loan (accountType = 4)
        /// CBS: OutSelectedLoanAccountAccMechanism
        /// </summary>
        public string cb_ln_mech { get; set; }

        /// <summary>
        /// Seq: 20
        /// Entity: cr_cucoba_det
        /// Description: Loan Normal Balance
        /// Data Type: decimal (19,3)
        /// Notes: Loan (accountType = 4)
        /// CBS: OutLnsBalancesLoanAccountDrvWorkNrmAccountBal
        /// </summary>
        public decimal cb_ln_nrm_bal { get; set; }

        /// <summary>
        /// Seq: 21
        /// Entity: cr_cucoba_det
        /// Description: Loan Overdue Balance
        /// Data Type: decimal (19,3)
        /// Notes: Loan (accountType = 4)
        /// CBS: OutLnsBalancesLoanAccountDrvWorkOvAccountBal
        /// </summary>
        public decimal cb_ln_ovd_bal { get; set; }

        /// <summary>
        /// Seq: 52
        /// Entity: cr_cucoba_det
        /// Description: Shares in Mutual Funds
        /// Data Type: decimal (19,3)
        /// Notes: Securities (accountType = 18)
        /// CBS: OutTotalsScrAccountCustomerPositionTotalsScrAkShrTot
        /// </summary>
        public decimal cb_shares { get; set; }

        /// <summary>
        /// Seq: 9 | 25 | 31 | 40 | 45
        /// Entity: cr_cucoba_det
        /// Description: Account Status
        /// Data Type: varchar (10)
        /// Notes: Agreement (accounType = 19) | Deposit (accountType = 3) | Letter of Guarantee (accountType = 14) | Trade Finance (accountType = 37) | Letter of Credit (accountType = 39)
        /// CBS: OutAgreementAgreementAgrStatus | OutSelectedDepositAccountEntryStatus | OutSelectedLgLgAccountAccStatus | OutSelectedLgLgAccountAccStatus | OutSelectedLgLgAccountAccStatus
        /// </summary>
        public string cb_status { get; set; }

        /// <summary>
        /// Seq: 22
        /// Entity: cr_cucoba_det
        /// Description: Total Amount Payed
        /// Data Type: decimal (19,3)
        /// Notes: Loan (accountType = 4)
        /// CBS: OutLnsBalancesLoanAccountDrvWorkTotPaymentAmn
        /// </summary>
        public decimal cb_tot_amt_pd { get; set; }

        /// <summary>
        /// Seq: 19
        /// Entity: cr_cucoba_det
        /// Description: Total Interest for Loan Account
        /// Data Type: decimal (19,3)
        /// Notes: Loan (accountType = 4)
        /// CBS: OutLnsBalancesLoanAccountDrvWorkLstYrIntDbAmn
        /// </summary>
        public decimal cb_tot_interest { get; set; }

        /// <summary>
        /// Seq: 7
        /// Entity: cr_cucoba_det
        /// Description: Utilized Limit
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutAccUtilizedIefSuppliedAmount
        /// </summary>
        public decimal cb_util_limit { get; set; }

        /// <summary>
        /// Seq: 1
        /// Entity: cr_cucoba_det
        /// Description: Customer Id
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: customerId
        /// </summary>
        public string cu_id { get; set; }

        public List<DownloadLoanInsurance> InsuranceDataList { get; set; }

        #endregion Public Properties
    }
}