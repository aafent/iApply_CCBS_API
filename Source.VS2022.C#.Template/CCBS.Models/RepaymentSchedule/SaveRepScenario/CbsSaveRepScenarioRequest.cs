using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsSaveRepScenarioRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Seq: 39
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Account Open Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public DateTime? AccountOpenDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq: 59
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Activity Sector
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int ActivitySector { get; set; }

        /// <summary>
        /// Seq: 49
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Agreement Check Digit
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int AgreementCd { get; set; }

        /// <summary>
        /// Seq: 48
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Agreement Number
        /// Data Type: varchar (30)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string AgreementNo { get; set; }

        /// <summary>
        /// Seq: 67
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: GP IR Amortization
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int AmortGPInter { get; set; }

        /// <summary>
        /// Seq: 33
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Approved Amount
        /// Data Type: decimal (19,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Seq: 62
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Application Id
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        [Mockup(1)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Seq: 10
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Applicant Birth Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public DateTime BirthDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq: 41
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: IR Claimed
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int CapitFlg { get; set; }

        /// <summary>
        /// Seq: 56
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Central Bank Tenor
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int CentralBank { get; set; }

        public RepaymentScheduleInsuranceData[] CoinsuredArray { get; set; }

        /// <summary>
        /// Seq: 29
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Contribution Percentage
        /// Data Type: decimal (19,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal ContributionInterestPerc { get; set; }

        /// <summary>
        /// Seq: 26
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Contribution Interest Rate
        /// Data Type: decimal (19,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal ContributionInterestRate { get; set; }

        /// <summary>
        /// Seq: 21
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Currency
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int CurrencyCode { get; set; }

        /// <summary>
        /// Seq: 22
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Currency Description
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string CurrencyDescription { get; set; }

        /// <summary>
        /// Seq: 52
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Customer Category
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int CustomerCategory { get; set; }

        /// <summary>
        /// Seq: 14
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Customer Check Digit
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Seq: 13
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Customer CBS Id
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        [Mockup(2)]
        public string CustomerCBSId { get; set; }

        /// <summary>
        /// Seq: 51
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Deposit Check Digit
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int DepositCd { get; set; }

        /// <summary>
        /// Seq: 50
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Deposit Account
        /// Data Type: varchar (30)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string DepositNo { get; set; }

        /// <summary>
        /// Seq: 36
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Disbursement Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public DateTime DisbDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq: 57
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Division Address
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int DivisionAddress { get; set; }

        /// <summary>
        /// Seq: 32
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Disbursement Amount
        /// Data Type: decimal (19,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal DrawdownCapitalAmount { get; set; }

        /// <summary>
        /// Seq: 63
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Final Scenario
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int FinalScenario { get; set; }

        /// <summary>
        /// Seq: 60
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Financial Sector
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int FinancialSector { get; set; }

        /// <summary>
        /// Seq: 20
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: 1st Install.t Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public DateTime FirstInstallmentDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq: 16
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Fixed Duration
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int FixedDuration { get; set; }

        /// <summary>
        /// Seq: 15
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Fixed Duration Unit
        /// Data Type: varchar (10)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string FixedDurationUnit { get; set; }

        /// <summary>
        /// Seq: 25
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Fixed Percentage
        /// Data Type: decimal (19,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal FixedInterestPerc { get; set; }

        /// <summary>
        /// Seq: 23
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Fixed Interest Rate
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int FixedInterestRate { get; set; }

        /// <summary>
        /// Seq: 37
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Fixed Rate Expiry Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public DateTime FixedIntExpDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq: 43
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Flag1
        /// Data Type: integer
        /// Notes: 0
        /// CBS: N/A
        /// </summary>
        public int Flag1 { get; set; }

        /// <summary>
        /// Seq: 44
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Flag2
        /// Data Type: integer
        /// Notes: 0
        /// CBS: N/A
        /// </summary>
        public int Flag2 { get; set; }

        /// <summary>
        /// Seq: 45
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Flag3
        /// Data Type: integer
        /// Notes: 1
        /// CBS: N/A
        /// </summary>
        public int Flag3 { get; set; }

        /// <summary>
        /// Seq: 46
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Flag4
        /// Data Type: integer
        /// Notes: 0
        /// CBS: N/A
        /// </summary>
        public int Flag4 { get; set; }

        /// <summary>
        /// Seq: 27
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Floating Percentage
        /// Data Type: decimal (19,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal FloatingInterestPerc { get; set; }

        /// <summary>
        /// Seq: 24
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Floating Interest Rate
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int FloatingInterestRateCode { get; set; }

        /// <summary>
        /// Seq: 35
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Grace Period Frequency
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int FreqMorat { get; set; }

        /// <summary>
        /// Seq: 18
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Frequency
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int Frequency { get; set; }

        /// <summary>
        /// Seq: 31
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Grace Period Expiry Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public DateTime GracePeriodExpiryDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq: 47
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: GP IR Install No.
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int InGracePeriod { get; set; }

        /// <summary>
        /// Seq: 17
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Installment Number
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int InstallmentsNo { get; set; }

        public RepaymentScheduleInsuranceData[] InsuranceArray { get; set; }

        /// <summary>
        /// Seq: 9
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Insurance Code
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int InsuranceCode { get; set; }

        /// <summary>
        /// Seq: 12
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Insured Amount
        /// Data Type: decimal (14,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal InsuredAmount { get; set; }

        /// <summary>
        /// Seq: 40
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: IR Claimed at GP
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int IntPayFlg { get; set; }

        /// <summary>
        /// Seq: 58
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Loan Purpose
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int LoanPurpose { get; set; }

        /// <summary>
        /// Seq: 11
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Main Beneficiary
        /// Data Type: varchar (1)
        /// Notes: 1 = Yes
        ///0 = No
        /// CBS: N/A
        /// </summary>
        public string MainBenef { get; set; }

        /// <summary>
        /// Seq: 38
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: MaintainEqInst
        /// Data Type: varchar (1)
        /// Notes: 0
        /// CBS: N/A
        /// </summary>
        public string MaintainEqInst { get; set; }

        /// <summary>
        /// Seq: 19
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Loan Expiry Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public DateTime MaturityDate { get; set; } =  DateTime.Parse("1800-01-01");

        public CbsRepaymentScenarioView[] MediatorsArray { get; set; }

        /// <summary>
        /// Seq: 42
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Non IR Capitalization
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int NonCapitFlg { get; set; }

        /// <summary>
        /// Seq: 66
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Penalty Code
        /// Data Type: decimal (19,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal PenaltyInterestRateCode { get; set; }

        /// <summary>
        /// Seq: 34
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Product Code
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Seq: 55
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Request_Dt
        /// Data Type: datetime
        /// Notes: business datetime
        /// CBS: N/A
        /// </summary>
        public DateTime Request_Dt { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq: 64
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Sales Unit
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int SalesUnit { get; set; }

        /// <summary>
        /// Seq: 65
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Seller
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int Seller { get; set; }

        /// <summary>
        /// Seq: 30
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Margin
        /// Data Type: decimal (19,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal Spread { get; set; }

        /// <summary>
        /// Seq: 61
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Statement Frequency
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int StmFrequency { get; set; }

        /// <summary>
        /// Seq: 28
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: Loan Duration
        /// Data Type: decimal (19,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal? Term { get; set; }

        /// <summary>
        /// Seq: 53
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: TransactInd
        /// Data Type: varchar (1)
        /// Notes: 0
        /// CBS: N/A
        /// </summary>
        public string TransactInd { get; set; }

        /// <summary>
        /// Seq: 54
        /// Entity: v_CBS_RepScheduleSim_Save
        /// Description: TransactSm
        /// Data Type: integer
        /// Notes: 0
        /// CBS: N/A
        /// </summary>
        public int TransactSm { get; set; }

        #endregion Public Properties
    }
}