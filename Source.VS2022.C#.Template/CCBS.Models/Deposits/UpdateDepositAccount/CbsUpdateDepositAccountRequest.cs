using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsUpdateDepositAccountRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Customer Category (varchar (10))
        /// </summary>
        public string AccountCategory { get; set; }

        public short? AccountCd { get; set; }

        /// <summary>
        /// Account Description (varchar (40))
        /// </summary>
        public string AccountDescr { get; set; }

        /// <summary>
        /// Account Limit (decimal (15,2))
        /// </summary>
        public decimal AccountLimitUpd { get; set; }

        public string AccountNumber { get; set; }

        /// <summary>
        /// Account Officer (varchar (10))
        /// </summary>
        public string AccountOfficer { get; set; }

        /// <summary>
        /// Account Type (varchar (1))
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// G.Ledger Acct Group (integer)
        /// </summary>
        public int Activity { get; set; }

        /// <summary>
        /// Margin of Warning Validity - After Maturity (integer)
        /// </summary>
        public int AfterMaturity { get; set; }

        /// <summary>
        /// Agreement Number (varchar (40))
        /// </summary>
        public string AgreementNo { get; set; }

        /// <summary>
        /// Agreement Check Digit (integer)
        /// </summary>
        public int AgreementNo_Cd { get; set; }

        /// <summary>
        /// Cheque Approval Date (datetime)
        /// </summary>
        public DateTime AppDateCheque { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// As Collateral (varchar (1))
        /// </summary>
        public string AsCollateral { get; set; }

        /// <summary>
        /// Atm Card (varchar (1))
        /// </summary>
        public string AtmCard { get; set; }

        /// <summary>
        /// Auto. Chequebook Order (integer)
        /// </summary>
        public int AutoCheque { get; set; }

        /// <summary>
        /// Automatic Renewal (varchar (1))
        /// </summary>
        public string AutoRenewal { get; set; }

        /// <summary>
        /// Margin of Warning Validity - Before Maturity (integer)
        /// </summary>
        public int BeforeMaturity { get; set; }

        /// <summary>
        /// CP Disposal Account Number (varchar (40))
        /// </summary>
        public string CapAccNumber { get; set; }

        /// <summary>
        /// CP Disposal Account Check Digit (integer)
        /// </summary>
        public int CapAccNumber_Cd { get; set; }

        /// <summary>
        /// Capital Incr. Amount (decimal (15,2))
        /// </summary>
        public decimal CapIncreaseAmnt { get; set; }

        /// <summary>
        /// Change % (decimal (8,4))
        /// </summary>
        public decimal ChangePerc { get; set; }

        /// <summary>
        /// ChequeTollDays (datetime)
        /// </summary>
        public DateTime ChequeTollDays { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Collateral Date (datetime)
        /// </summary>
        public DateTime CollateralDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Conditional Account (varchar (1))
        /// </summary>
        public string ConditionalAccount { get; set; }

        /// <summary>
        /// Main Participant Main Address CBS S/N (integer)
        /// </summary>
        public int CorrespondenseCustomerSN { get; set; }

        /// <summary>
        /// CorrespondenseHolderSN (integer)
        /// </summary>
        public int CorrespondenseHolderSN { get; set; }

        /// <summary>
        /// Credit Expiry Date (datetime)
        /// </summary>
        public DateTime CreditExpDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Fixed Credit IR (varchar (1))
        /// </summary>
        public string CreditFixed { get; set; }

        /// <summary>
        /// Credit IR (integer)
        /// </summary>
        public int CreditInterestRate { get; set; }

        /// <summary>
        /// Credit Spread (decimal (8,4))
        /// </summary>
        public decimal CreditSpread { get; set; }

        /// <summary>
        /// Currency (integer)
        /// </summary>
        public int CurrencyID { get; set; }

        /// <summary>
        /// Main Applicant CBS Id (integer)
        /// </summary>
        [Mockup(1)]
        public int CustomerCBSId { get; set; }

        /// <summary>
        /// Withdrawals From Day (integer)
        /// </summary>
        public int DayFrom { get; set; }

        /// <summary>
        /// Withdrawals To Day (integer)
        /// </summary>
        public int DayTo { get; set; }

        /// <summary>
        /// Debit Expiry Date (datetime)
        /// </summary>
        public DateTime DebitExpDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Debit Indicator (varchar (1))
        /// </summary>
        public string DebitIndicator { get; set; }

        /// <summary>
        /// Debit IR (integer)
        /// </summary>
        public int DebitInterestRate { get; set; }

        /// <summary>
        /// Debit Spread (decimal (8,4))
        /// </summary>
        public decimal DebitSpread { get; set; }

        /// <summary>
        /// Discount Cheques Percentage (decimal (8,4))
        /// </summary>
        public decimal DiscPerc { get; set; }

        /// <summary>
        /// Cheque Expiry Date (datetime)
        /// </summary>
        public DateTime ExpDateCheque { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// External Account (varchar (1))
        /// </summary>
        public string ExternalAccount { get; set; }

        /// <summary>
        /// Fixed Income Amount (decimal (15,2))
        /// </summary>
        public decimal FIAmount { get; set; }

        /// <summary>
        /// Fixed Income Frequency (integer)
        /// </summary>
        public int FIFrequency { get; set; }

        /// <summary>
        /// Holders Count (integer)
        /// </summary>
        public int HoldersCount { get; set; }

        /// <summary>
        /// IR Disposal Account Number (varchar (40))
        /// </summary>
        public string IRDISAccNumber { get; set; }

        /// <summary>
        /// IR Disposal Account Check Digit (integer)
        /// </summary>
        public int IRDISAccNumber_Cd { get; set; }

        /// <summary>
        /// Cheque Iss. Exp. % (decimal (15,2))
        /// </summary>
        public decimal IssCheque { get; set; }

        /// <summary>
        /// Limit Encr/nt Toler. (decimal (15,2))
        /// </summary>
        public decimal LimitToll { get; set; }

        /// <summary>
        /// Margin Changed IR (decimal (8,4))
        /// </summary>
        public decimal MarginChange { get; set; }

        /// <summary>
        /// Withdrawals Max drawdown Amt (decimal (15,2))
        /// </summary>
        public decimal MaxDrawAmnt { get; set; }

        /// <summary>
        /// Max Period Disc. Cheque(M) (integer)
        /// </summary>
        public int MaxPeriod { get; set; }

        /// <summary>
        /// Withdrawals From Month (integer)
        /// </summary>
        public int MonthFrom { get; set; }

        /// <summary>
        /// Mon. Gross Salary Multip. (integer)
        /// </summary>
        public int MonthlyGross { get; set; }

        /// <summary>
        /// Withdrawals To Month (integer)
        /// </summary>
        public int MonthTo { get; set; }

        /// <summary>
        /// Moved by House Unit (varchar (1))
        /// </summary>
        public string MovedByHouse { get; set; }

        /// <summary>
        /// Mutual Funds of Own Capital (varchar (1))
        /// </summary>
        public string MutualFunds { get; set; }

        /// <summary>
        /// No. of Approved Cheques (integer)
        /// </summary>
        public int NoCheque { get; set; }

        /// <summary>
        /// Non Tax Inter Deduction (varchar (1))
        /// </summary>
        public string NonDeduction { get; set; }

        /// <summary>
        /// Notes (varchar (40))
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Monit/Agree Branch (integer)
        /// </summary>
        public int OpeningUnit { get; set; }

        /// <summary>
        /// Over. Limit Margin (decimal (15,2))
        /// </summary>
        public decimal OverdraftLimitMargin { get; set; }

        /// <summary>
        /// Overdraft Maturity Date (datetime)
        /// </summary>
        public DateTime OverdraftMaturity { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Print Mandate Instr. Statement (varchar (1))
        /// </summary>
        public string PrintMandate { get; set; }

        /// <summary>
        /// Product CBS Id (integer)
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// ProductType (varchar)
        /// </summary>
        public string ProductType { get; set; }

        /// <summary>
        /// Purpose (integer)
        /// </summary>
        public int Purpose { get; set; }

        /// <summary>
        /// Renewal Date (datetime)
        /// </summary>
        public DateTime RenewalDate { get; set; } =  DateTime.Parse("1800-01-01");

        public CbsRetrieveDepositAccountResponse RetrieveDepositAccountModel { get; set; }

        /// <summary>
        /// Review Date (datetime)
        /// </summary>
        public DateTime ReviewDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Discount Cheques Risk Diversification (decimal (8,4))
        /// </summary>
        public decimal Risk { get; set; }

        /// <summary>
        /// Sales Unit (integer)
        /// </summary>
        public int SalesUnit { get; set; }

        /// <summary>
        /// Seller (varchar (20))
        /// </summary>
        public string Seller { get; set; }

        /// <summary>
        /// Service Charges % (decimal (8,4))
        /// </summary>
        public decimal ServiceCharges { get; set; }

        /// <summary>
        /// Approval S/N Cheques (integer)
        /// </summary>
        public int SNCheque { get; set; }

        /// <summary>
        /// Special Account (varchar (1))
        /// </summary>
        public string SpecialAccount { get; set; }

        /// <summary>
        /// Statement (integer)
        /// </summary>
        public int Statement { get; set; }

        /// <summary>
        /// Statement Frequency (varchar (15))
        /// </summary>
        public string StatementFreq { get; set; }

        /// <summary>
        /// Tax Country Description (varchar (20))
        /// </summary>
        public string TaxCountryDescr { get; set; }

        /// <summary>
        /// Telebank (varchar (1))
        /// </summary>
        public string Telebank { get; set; }

        /// <summary>
        /// Temporary Limit Excess (decimal (15,2))
        /// </summary>
        public decimal TempLimit { get; set; }

        /// <summary>
        /// Temporary Limit Expiry Date (datetime)
        /// </summary>
        public DateTime TempLimitEnd { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Temporary Limit Start Date (datetime)
        /// </summary>
        public DateTime TempLimitStart { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Withdrawals Validity Period (integer)
        /// </summary>
        public int ValPeriod { get; set; }

        /// <summary>
        /// Withdrawal from Unclear (varchar (1))
        /// </summary>
        public string WithdrawalUnclear { get; set; }

        #endregion Public Properties
    }
}