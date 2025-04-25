namespace CCBS.Models
{
    public class CbsRepaymentScheduleRetrieveResponse : CommonResponseModel
    {
        /// <summary>
        /// Seq. 1
        /// Description: Source
        /// Entities: cr_laresc_save
        /// Notes: 2
        /// </summary>
        public int source { get; set; }

        /// <summary>
        /// Seq. 2
        /// Description: Application Id
        /// Entities: cr_laresc_save
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Seq. 3
        /// Description: Customer Id
        /// Entities: cr_laresc_save
        /// </summary>
        public string cu_id { get; set; }

        /// <summary>
        /// Seq. 4
        /// Description: CBS Serial Num
        /// Entities: cr_laresc_save
        /// </summary>
        public int cbs_serial_num { get; set; }

        /// <summary>
        /// Seq. 5
        /// Description: CBS Requested Date
        /// Entities: cr_laresc_save
        /// </summary>
        public DateTime cbs_request_dt { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq. 6
        /// Description: Loan Expiry Date
        /// Entities: cr_laresc_save
        /// </summary>
        public DateTime la_matur_date { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq. 7
        /// Description: Account Open Date
        /// Entities: cr_laresc_save
        /// </summary>
        public DateTime la_open_date { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq. 8
        /// Description: Disbursement Amount
        /// Entities: cr_laresc_save
        /// </summary>
        public decimal disb_amount { get; set; }

        /// <summary>
        /// Seq. 9
        /// Description: Fixed Expiry Date
        /// Entities: cr_laresc_save
        /// </summary>
        public DateTime la_int_date { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq. 10
        /// Description: Fixed IR
        /// Entities: cr_laresc_save
        /// </summary>
        public string la_intrate { get; set; }

        /// <summary>
        /// Seq. 11
        /// Description: Fixed IR Percentage
        /// Entities: cr_laresc_save
        /// </summary>
        public decimal la_intrate_perc { get; set; }

        /// <summary>
        /// Seq. 12
        /// Description: Fixed IR Start Date
        /// Entities: cr_laresc_save
        /// </summary>
        public DateTime la_fixed_start_dt { get; set; } =  DateTime.Parse("1800-01-01");
        /// <summary>
        /// Seq. 13
        /// Description: Fixed Duration Unit
        /// Entities: cr_laresc_save
        /// </summary>
        public int fixed_durationunit { get; set; }

        /// <summary>
        /// Seq. 14
        /// Description: Fixed Duration
        /// Entities: cr_laresc_save
        /// </summary>
        public decimal fixed_inter_duration { get; set; }

        /// <summary>
        /// Seq. 15
        /// Description: Floating IR
        /// Entities: cr_laresc_save
        /// </summary>
        public string la_flintrate { get; set; }

        /// <summary>
        /// Seq. 16
        /// Description: Floating IR Percentafe
        /// Entities: cr_laresc_save
        /// </summary>
        public decimal la_flintrate_perc { get; set; }

        /// <summary>
        /// Seq. 17
        /// Description: GP IR Install No.
        /// Entities: cr_laresc_save
        /// </summary>
        public int la_tot_morat { get; set; }

        /// <summary>
        /// Seq. 18
        /// Description: Currency
        /// Entities: cr_laresc_save
        /// </summary>
        public string la_ccy { get; set; }

        /// <summary>
        /// Seq. 19
        /// Description: 1st Install.t Date
        /// Entities: cr_laresc_save
        /// </summary>
        public DateTime la_insdate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq. 20
        /// Description: Disbursement Date
        /// Entities: cr_laresc_save
        /// </summary>
        public DateTime disb_date { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq. 21
        /// Description: Non IR Capitalization
        /// Entities: cr_laresc_save
        /// </summary>
        public int non_int_capit_flg { get; set; }

        /// <summary>
        /// Seq. 22
        /// Description: IR Claimed
        /// Entities: cr_laresc_save
        /// </summary>
        public int int_payable_flg { get; set; }

        /// <summary>
        /// Seq. 23
        /// Description: Installment Number
        /// Entities: cr_laresc_save
        /// </summary>
        public int la_instno { get; set; }

        /// <summary>
        /// Seq. 24
        /// Description: Frequency
        /// Entities: cr_laresc_save
        /// </summary>
        public int la_freq { get; set; }

        /// <summary>
        /// Seq. 25
        /// Description: Grace Period Expiry Date
        /// Entities: cr_laresc_save
        /// </summary>
        public DateTime la_morat_enddt { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq. 26
        /// Description: Grace Period IR Frequency
        /// Entities: cr_laresc_save
        /// </summary>
        public int la_freq_morat { get; set; }

        /// <summary>
        /// Seq. 27
        /// Description: IR Claimed at GP
        /// Entities: cr_laresc_save
        /// </summary>
        public int morat_int_pay_flg { get; set; }

        /// <summary>
        /// Seq. 28
        /// Description: Contribution Rate
        /// Entities: cr_laresc_save
        /// </summary>
        public string la_cintrate { get; set; }

        /// <summary>
        /// Seq. 29
        /// Description: Contribution Percentage
        /// Entities: cr_laresc_save
        /// </summary>
        public decimal la_cintrate_perc { get; set; }

        /// <summary>
        /// Seq. 30
        /// Description: IR Capitalization
        /// Entities: cr_laresc_save
        /// Notes: If OutGrpCustDataOutGrmLoanScenarioDataMoratIntPayFlg = 1 then 0 else OutGrpCustDataOutGrmLoanScenarioDataIntCapitalFlg
        /// </summary>
        public int int_capital_flg { get; set; }

        /// <summary>
        /// Seq. 31
        /// Description: Margin
        /// Entities: cr_laresc_save
        /// </summary>
        public decimal la_intloan { get; set; }

        /// <summary>
        /// Seq. 32
        /// Description: Loan Duration
        /// Entities: cr_laresc_save
        /// </summary>
        public int la_durat { get; set; }

        /// <summary>
        /// Seq. 33
        /// Description: Product
        /// Entities: cr_laresc_save
        /// </summary>
        public string la_produ { get; set; }

        /// <summary>
        /// Seq. 34
        /// Description: Agreement Number
        /// Entities: cr_laresc_save
        /// </summary>
        public string agreementno { get; set; }

        /// <summary>
        /// Seq. 35
        /// Description: Agreement Check Digit
        /// Entities: cr_laresc_save
        /// </summary>
        public int agreementnocd { get; set; }

        /// <summary>
        /// Seq. 36
        /// Description: Deposit Account
        /// Entities: cr_laresc_save
        /// </summary>
        public string currentaccount { get; set; }

        /// <summary>
        /// Seq. 37
        /// Description: Deposit Account Check Digit
        /// Entities: cr_laresc_save
        /// </summary>
        public int currentaccount_cd { get; set; }

        /// <summary>
        /// Seq. 38
        /// iApply: transact_ind
        /// Entities: cr_laresc_save
        /// </summary>
        public int transact_ind { get; set; }

        /// <summary>
        /// Seq. 39
        /// iApply: transact_sm
        /// Entities: cr_laresc_save
        /// </summary>
        public int transact_sm { get; set; }

        /// <summary>
        /// Seq. 40
        /// Description: Branch
        /// Entities: cr_laresc_save
        /// Data Type: varchar (15)
        /// </summary>
        public string la_branc { get; set; }

        /// <summary>
        /// Seq. 41
        /// Description: Application Date
        /// Entities: cr_laresc_save
        /// Data Type: datetime
        /// </summary>
        public DateTime la_date { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq. 42
        /// Description: Product Category
        /// Entities: cr_laresc_save
        /// Data Type: varchar (15)
        /// </summary>
        public string la_mark_id { get; set; }

        /// <summary>
        /// Seq. 43
        /// Description: Customer Category
        /// Entities: cr_laresc_save
        /// Data Type: varchar (15)
        /// </summary>
        public string la_custcat { get; set; }

        /// <summary>
        /// Seq. 44
        /// Description: Approved Amount
        /// Entities: cr_laresc_save
        /// Data Type: decimal (19,3)
        /// </summary>
        public decimal la_appamt { get; set; }

        /// <summary>
        /// Seq. 45
        /// Description: Financial Sector
        /// Entities: cr_laresc_save
        /// Data Type: varchar (15)
        /// </summary>
        public string la_finsec { get; set; }

        /// <summary>
        /// Seq. 46
        /// Description: Activity Sector
        /// Entities: cr_laresc_save
        /// Data Type: varchar (15)
        /// </summary>
        public string la_actsec { get; set; }

        /// <summary>
        /// Seq. 47
        /// Description: Loan Purpose
        /// Entities: cr_laresc_save
        /// Data Type: varchar (15)
        /// </summary>
        public string la_lpurp { get; set; }

        /// <summary>
        /// Seq. 48
        /// Description: Statement Frequency
        /// Entities: cr_laresc_save
        /// Data Type: varchar (15)
        /// </summary>
        public string la_lfreq { get; set; }
        /// <summary>
        /// Seq. 49
        /// Description: Central Bank Tenor
        /// Entities: cr_laresc_save
        /// Data Type: varchar (15)
        /// </summary>
        public string la_btenor { get; set; }

        /// <summary>
        /// Seq. 50
        /// Description: Division Address
        /// Entities: cr_laresc_save
        /// Data Type: varchar (15)
        /// </summary>
        public string la_divadd { get; set; }

        /// <summary>
        /// Seq. 51
        /// Description: CBS Application Id
        /// Entities: cr_laresc_save
        /// Data Type: varchar (15)
        /// </summary>
        public string cbs_applid { get; set; }

        /// <summary>
        /// Seq. 52
        /// Description: CBS Final
        /// Entities: cr_laresc_save
        /// Data Type: integer
        /// </summary>
        public int la_final { get; set; }

        /// <summary>
        /// Seq. 53
        /// Description: Sales Unit
        /// Entities: cr_laresc_save
        /// Data Type: varchar (15)
        /// </summary>
        public string la_salesunit { get; set; }

        /// <summary>
        /// Seq. 54
        /// Description: Seller
        /// Entities: cr_laresc_save
        /// Data Type: varchar (15)
        /// </summary>
        public string la_seller { get; set; }

        /// <summary>
        /// Seq. 55
        /// Description: Penalty Rate
        /// Entities: cr_laresc_save
        /// Data Type: varchar (15)
        /// </summary>
        public string la_pintrate { get; set; }

        /// <summary>
        /// Seq. 56
        /// Description: GP IR Amortization
        /// Entities: cr_laresc_save
        /// Data Type: integer
        /// </summary>
        public int amort_gp_inter { get; set; }

        /// <summary>
        /// Seq. 58
        /// Description: Serial Number
        /// Entities: cr_laresc_insur_save
        /// Data Type: integer
        /// </summary>
        public int serial_num { get; set; }

        /// <summary>
        /// Seq. 59
        /// Description: Main Beneficiary
        /// Entities: cr_laresc_insur_save
        /// Data Type: varchar (1)
        /// </summary>
        public string insurer_mainbf { get; set; }

        /// <summary>
        /// Seq. 60
        /// Description: Applicant Birth Date
        /// Entities: cr_laresc_insur_save
        /// Data Type: datetime
        /// </summary>
        public DateTime insurer_birthdate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq. 61
        /// Description: Insurance Id
        /// Entities: cr_laresc_insur_save
        /// Data Type: varchar (15)
        /// </summary>
        public string insurance_id { get; set; }

        /// <summary>
        /// Seq. 62
        /// Description: Insurance Amount
        /// Entities: cr_laresc_insur_save
        /// Data Type: decimal (19,3)
        /// </summary>
        public decimal insured_amnt { get; set; }

        /// <summary>
        /// Seq. 63
        /// Description: Type
        /// Entities: cr_laresc_insur_save
        /// Data Type: varchar (15)
        /// </summary>
        public string type { get; set; }


        /// <summary>
        /// Seq. 64
        /// Description: Application Id
        /// Entities: cr_laresc_insur_save
        /// Data Type: varchar (15)
        /// changed because of the same name different entities of Application Id
        /// </summary>
        public string Application_Id { get; set; }

        /// <summary>
        /// Seq. 65
        /// Description: Type
        /// Entities: cr_laresc_insur_save
        /// Data Type: varchar (15)
        /// </summary>
        public string co_relat { get; set; }

        /// <summary>
        /// Seq. 66
        /// Description: Mediator CBS Id
        /// Entities: cr_laresc_insur_save
        /// Data Type: varchar (20)
        /// </summary>
        public string clnum2 { get; set; }

        /// <summary>
        /// Seq. 67
        /// Description: Mediator Check Digit
        /// Entities: cr_laresc_insur_save
        /// Data Type: integer
        /// </summary>
        public int checkdigit2 { get; set; }

        /// <summary>
        /// Seq. 68
        /// Description: Deposit Account
        /// Entities: cr_laresc_insur_save
        /// Data Type: varchar (20)
        /// Duplicate value with different Entity
        /// </summary>
        public string deposit_account { get; set; }

        /// <summary>
        /// Seq. 69
        /// Description: Deposit Account Check Digit
        /// Entities: cr_laresc_insur_save
        /// Data Type: integer
        /// Duplicate Value with different Entity
        /// </summary>
        public int depositaAcount_cd { get; set; }

        /// <summary>
        /// Seq. 71
        /// Description: Mediator Full Name
        /// Entities: cr_laresc_insur_save
        /// Data Type: varchar (100)
        /// </summary>
        public string co_sunam { get; set; }
    }
}
