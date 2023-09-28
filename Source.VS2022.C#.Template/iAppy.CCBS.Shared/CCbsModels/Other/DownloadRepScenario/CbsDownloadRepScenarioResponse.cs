namespace iApplyShared.CbsModels
{
    public class CbsDownloadRepScenarioResponse : CommonResponseModel
    {

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Source
        /// Data Type: N/A
        /// Notes: 2
        /// CBS: N/A
        /// </summary>
        public string source { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Application Id
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: request.ApplicationId
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Customer Id
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: sourceData.CustomerId
        /// </summary>
        public string cu_id { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: CBS Serial Num
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataInstallSn
        /// </summary>
        public int cbs_serial_num { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: CBS Requested Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataInstallDt
        /// </summary>
        public DateTime cbs_request_dt { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Loan Expiry Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataAccExpDt
        /// </summary>
        public DateTime la_matur_date { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Account Open Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataAccOpetDt
        /// </summary>
        public DateTime la_open_date { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Disbursement Amount
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataDrawdownAmn
        /// </summary>
        public decimal disb_amount { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Fixed Expiry Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataFixedIntExpDt
        /// </summary>
        public DateTime la_int_date { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Fixed IR
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataFixedIntId
        /// </summary>
        public string la_intrate { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Fixed IR Percentage
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataFixedIntPrc
        /// </summary>
        public decimal la_intrate_perc { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Fixed IR Start Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataFixedIntStDt
        /// </summary>
        public DateTime la_fixed_start_dt { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Fixed Duration Unit
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataFixDurationUnit
        /// </summary>
        public int fixed_durationunit { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Fixed Duration
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataFixIndDuration
        /// </summary>
        public decimal fixed_inter_duration { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Floating IR
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataFloatingIntId
        /// </summary>
        public string la_flintrate { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Floating IR Percentafe
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataFloatingIntPrc
        /// </summary>
        public decimal la_flintrate_perc { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: GP IR Install No.
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataGracePdInstCnt
        /// </summary>
        public int la_tot_morat { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Currency
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataIdCurrency
        /// </summary>
        public string la_ccy { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: 1st Install.t Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataInstallFirstDt
        /// </summary>
        public DateTime la_insdate { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Disbursement Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataInstFirstDrwDt
        /// </summary>
        public DateTime disb_date { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Non IR Capitalization
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataNonIntCapitFlg
        /// </summary>
        public int non_int_capit_flg { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: IR Claimed
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataIntPayableFlg
        /// </summary>
        public int int_payable_flg { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Installment Number
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataLoanInstallCnt
        /// </summary>
        public int la_instno { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Frequency
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataLoanInstallFreq
        /// </summary>
        public int la_freq { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Grace Period Expiry Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataMoratorEndDt
        /// </summary>
        public DateTime la_morat_enddt { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Grace Period IR Frequency
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataMoratorIntFrq
        /// </summary>
        public int la_freq_morat { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: IR Claimed at GP
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataMoratIntPayFlg
        /// </summary>
        public int morat_int_pay_flg { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Contribution Rate
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataN128IntId
        /// </summary>
        public string la_cintrate { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Contribution Percentage
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataN128IntPrc
        /// </summary>
        public decimal la_cintrate_perc { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: IR Capitalization
        /// Data Type: integer
        /// Notes: If OutGrpCustDataOutGrmLoanScenarioDataMoratIntPayFlg = 1 then 0 else OutGrpCustDataOutGrmLoanScenarioDataIntCapitalFlg
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataMoratIntPayFlg
        /// OutGrpCustDataOutGrmLoanScenarioDataIntCapitalFlg
        /// </summary>
        public int int_capital_flg { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Margin
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataSpreadIntPrc
        /// </summary>
        public decimal la_intloan { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Loan Duration
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataLoanInstTotInt
        /// </summary>
        public int la_durat { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Product
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataProductId
        /// </summary>
        public string la_produ { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Agreement Number
        /// Data Type: varchar (30)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataAgrAccountNum
        /// </summary>
        public string agreementno { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Agreement Check Digit
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataAgrAccountCd
        /// </summary>
        public int agreementnocd { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Deposit Account
        /// Data Type: varchar (30)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataDepAccountNum
        /// </summary>
        public string currentaccount { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Deposit Account Check Digit
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataDepAccountCd
        /// </summary>
        public int currentaccount_cd { get; set; }

        ///// <summary>
        ///// Seq: N/A
        ///// Entity: cr_laresc_save
        ///// Description: N/A
        ///// Data Type: N/A
        ///// Notes: N/A
        ///// CBS: OutGrpCustDataOutGrmLoanScenarioDataTransactInd
        ///// </summary>
        //public NoType transact_ind { get; set; }

        ///// <summary>
        ///// Seq: N/A
        ///// Entity: cr_laresc_save
        ///// Description: N/A
        ///// Data Type: N/A
        ///// Notes: N/A
        ///// CBS: OutGrpCustDataOutGrmLoanScenarioDataTransactSm
        ///// </summary>
        //public NoType transact_sm { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Branch
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: sourceData.Branch
        /// </summary>
        public string la_branc { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Application Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: sourceData.ApplicationDate
        /// </summary>
        public DateTime la_date { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Product Category
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: sourceData.ProductCategory
        /// </summary>
        public string la_mark_id { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Customer Category
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: sourceData.CustomerCategory
        /// </summary>
        public string la_custcat { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Approved Amount
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: sourceData.Amount
        /// </summary>
        public decimal la_appamt { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Financial Sector
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataFinscSn
        /// </summary>
        public string la_finsec { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Activity Sector
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataActscSn
        /// </summary>
        public string la_actsec { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Loan Purpose
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataLpurpSn
        /// </summary>
        public string la_lpurp { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Statement Frequency
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataStatementFreq
        /// </summary>
        public string la_lfreq { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Central Bank Tenor
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataCbpurSn
        /// </summary>
        public string la_btenor { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Division Address
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataBsectSn
        /// </summary>
        public string la_divadd { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: CBS Application Id
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataApplicationId
        /// </summary>
        public string cbs_applid { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: CBS Final
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataApplicationSts
        /// </summary>
        public int la_final { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Sales Unit
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataSaleUnitSn
        /// </summary>
        public string la_salesunit { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Seller
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataSalePersonSn
        /// </summary>
        public string la_seller { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: Penalty Rate
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataPenaltyIntId
        /// </summary>
        public string la_pintrate { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_save
        /// Description: GP IR Amortization
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataMoratIntAmortized
        /// </summary>
        public int amort_gp_inter { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Serial Number
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataInstallSn
        /// </summary>
        public int serial_num { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Main Beneficiary
        /// Data Type: varchar (1)
        /// Notes: N/A
        /// CBS: OutCoinsuredGrpOutGrmMainBenefIefSuppliedFlag
        /// </summary>
        public string insurer_mainbf { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Applicant Birth Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: OutCoinsuredGrpOutBirthdatesBenefGrmIefSuppliedDate
        /// </summary>
        public DateTime insurer_birthdate { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Insurance Id
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutCoinsuredGrpOutGrmInsProdInsurProdCodeProdId
        /// </summary>
        public string insurance_id { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Insurance Amount
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpDbSelectedInsProdsInGrmInsuranceVlIefSuppliedAmount
        /// </summary>
        public decimal insured_amnt { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Type
        /// Data Type: varchar (15)
        /// Notes: 1
        /// CBS: N/A
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Type
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpMediatorsOutGrmMedtpGenericDetailSerialNum
        /// </summary>
        public string co_relat { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Mediator CBS Id
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: OutGrpMediatorsOutGrmCustomerCustomerCustId
        /// </summary>
        public string clnum2 { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Mediator Check Digit
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpMediatorsOutGrmCustomerCustomerCDigit
        /// </summary>
        public int checkdigit2 { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Mediator Full Name
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: OutGrpMediatorsOutGrmLnsMediatorName
        /// </summary>
        public string co_sunam { get; set; }
    }
}