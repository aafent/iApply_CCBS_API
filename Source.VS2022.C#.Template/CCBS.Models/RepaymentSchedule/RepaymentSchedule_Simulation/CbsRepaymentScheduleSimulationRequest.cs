namespace CCBS.Models
{
    public class CbsRepaymentScheduleSimulationRequest
    {
        /// <summary>
        /// Seq.: 1
        /// Applicant Birth Date
        /// </summary>
        public DateTime BirthDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq.: 2
        /// Main Beneficiary
        /// </summary>
        /// <remarks>
        /// 1 = Yes
        /// 0 = No
        /// </remarks>
        public string MainBenef { get; set; }

        /// <summary>
        /// Seq.: 3
        /// Insurance Code
        /// </summary>
        public int InsuranceCode { get; set; }

        /// <summary>
        /// Seq.: 4
        /// Insured Amount
        /// </summary>
        public decimal InsuredAmount { get; set; }

        /// <summary>
        /// Seq.: 5
        /// Installment Number
        /// </summary>
        public int InstallmentsNo { get; set; }

        /// <summary>
        /// Seq.: 6
        /// Frequency
        /// </summary>
        public int Frequency { get; set; }

        /// <summary>
        /// Seq.: 7
        /// Loan Expiry Date
        /// </summary>
        public DateTime MaturityDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq.: 8
        /// Account Open Date
        /// </summary>
        public DateTime AccountOpenDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq.: 9
        /// 1st Install.t Date
        /// </summary>
        public DateTime FirstInstallmentDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq.: 10
        /// Currency Code
        /// </summary>
        public int CurrencyCode { get; set; }

        /// <summary>
        /// Seq.: 11
        /// Currency Description
        /// </summary>
        public string CurrencyDescription { get; set; }

        /// <summary>
        /// Seq.: 12
        /// Fixed Interest Rate
        /// </summary>
        public int FixedInterestRate { get; set; }

        /// <summary>
        /// Seq.: 13
        /// Fixed Duration
        /// </summary>
        /// <remarks>
        /// If duration unit = 1 DAYS then 0,
        /// If duration unit = 2 MONTHS then interest duration,
        /// If duration unit = 3 YEARS then interest duration/12
        /// </remarks>
        public int FixedDurationInMonths { get; set; }

        /// <summary>
        /// Seq.: 14
        /// Floating Interest Rate
        /// </summary>
        public int FloatingInterestRateCode { get; set; }

        /// <summary>
        /// Seq.: 15
        /// Fixed Percentage
        /// </summary>
        public decimal FixedInterestPerc { get; set; }

        /// <summary>
        /// Seq.: 16
        /// Floating Percentage
        /// </summary>
        public decimal FloatingInterestPerc { get; set; }

        /// <summary>
        /// Seq.: 17
        /// Loan Duration
        /// </summary>
        public decimal Term { get; set; }

        /// <summary>
        /// Seq.: 18
        /// Contribution Percentage
        /// </summary>
        public decimal ContributionInterestPerc { get; set; }

        /// <summary>
        /// Seq.: 19
        /// Margin
        /// </summary>
        public decimal Spread { get; set; }

        /// <summary>
        /// Seq.: 20
        /// Grace Period Expiry Date
        /// </summary>
        public DateTime GracePeriodExpiryDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq.: 21
        /// Requested or Approved Amount
        /// </summary>
        /// <remarks>
        /// If approved amount is empty then requested amount else approved amount
        /// </remarks>
        public decimal DrawdownCapitalAmount { get; set; }

        /// <summary>
        /// Seq.: 22
        /// Product Code
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Seq.: 23
        /// Requested or Approved Amount
        /// </summary>
        /// <remarks>
        /// If approved amount is empty then requested amount else approved amount
        /// </remarks>
        public decimal Amount { get; set; }

        /// <summary>
        /// Seq.: 24
        /// Grace Period Expiry Date
        /// </summary>
        public DateTime DrawDownExpDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq.: 25
        /// Grace Period Frequency
        /// </summary>
        public int FreqMorat { get; set; }

        /// <summary>
        /// Seq.: 26
        /// Supplied
        /// </summary>
        /// <remarks>
        /// 1 = Yes
        /// </remarks>
        public string Supplied { get; set; }

        /// <summary>
        /// Seq.: 27
        /// Base Days
        /// </summary>
        /// <remarks>
        /// If fixed base days are zero then floating base days else fixed base days,
        /// For MCB, base days are the base days for the currency
        /// </remarks>
        public int DaysBase { get; set; }

        /// <summary>
        /// Seq.: 28
        /// DiffIntAlgorithm
        /// </summary>
        /// <remarks>
        /// 0 = No
        /// </remarks>
        public string DiffIntAlgorithm { get; set; }

        /// <summary>
        /// Seq.: 29
        /// Disbursement Date
        /// </summary>
        public DateTime DisbDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq.: 30
        /// Fixed Rate Expiry Date
        /// </summary>
        public DateTime FixedIntExpDate { get; set; } =  DateTime.Parse("1800-01-01");


        /// <summary>
        /// Seq.: 31
        /// Maintain Eq.Inst
        /// </summary>
        public string MaintainEqInst { get; set; }

        /// <summary>
        /// Seq.: 32
        /// IR Claimed
        /// </summary>
        public string CapitFlg { get; set; }

        /// <summary>
        /// Seq.: 33
        /// PayFlg
        /// </summary>
        /// <remarks>
        /// If GP IR Amortization=1 then 1 else, if IR Claimed at GP = '1' THEN 1 else IR Capitalization
        /// </remarks>
        public string PayFlg { get; set; }

        /// <summary>
        /// Seq.: 34
        /// IR Claimed at GP
        /// </summary>
        public string IntPayFlg { get; set; }

        /// <summary>
        /// Seq.: 35
        /// Non IR Capitalization
        /// </summary>
        public string NonCapitFlg { get; set; }

        /// <summary>
        /// Seq.: 36
        /// Flag1
        /// </summary>
        public int Flag1 { get; set; }

        /// <summary>
        /// Seq.: 37
        /// Flag2
        /// </summary>
        public int Flag2 { get; set; }

        /// <summary>
        /// Seq.: 38
        /// Flag3
        /// </summary>
        /// <remarks>
        /// 1 = Yes
        /// </remarks>
        public int Flag3 { get; set; }

        /// <summary>
        /// Seq.: 39
        /// Decimal Place
        /// </summary>
        /// <remarks>
        /// 2
        /// </remarks>
        public int DecimalPlace { get; set; }

        /// <summary>
        /// Seq.: 40
        /// IPF Type
        /// </summary>
        /// <remarks>
        /// If product category is IPF then 1 else 0
        /// </remarks>
        public string IsIpf { get; set; }

        /// <summary>
        /// Seq.: 41
        /// GP IR Amortization
        /// </summary>
        public int AmortGPInter { get; set; }

        /// <summary>
        /// Seq.: 42
        /// Product General Flags
        /// </summary>
        public int GeneralFlags { get; set; }
    }
}
