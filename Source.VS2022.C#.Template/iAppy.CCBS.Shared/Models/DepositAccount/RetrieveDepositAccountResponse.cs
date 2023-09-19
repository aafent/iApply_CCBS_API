using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveDepositAccountResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public int AccountCategory { get; set; }

        [DataMember]
        public string AccountDescr { get; set; }

        [DataMember]
        public int AccountIndicator { get; set; }

        [DataMember]
        public decimal AccountLimit { get; set; }

        [DataMember]
        public string AccountOfficer { get; set; }

        [DataMember]
        public string AccountStatus { get; set; }

        [DataMember]
        public string AccountType { get; set; }

        [DataMember]
        public int Activity { get; set; }

        [DataMember]
        public short AfterMaturity { get; set; }

        [DataMember]
        public string AgreementNo { get; set; }

        [DataMember]
        public short AgreementNo_Cd { get; set; }

        [DataMember]
        public int AlterDebitIR { get; set; }

        [DataMember]
        public DateTime AppDateCheque { get; set; }

        [DataMember]
        public string AsCollateral { get; set; }

        [DataMember]
        public string AtmCard { get; set; }

        [DataMember]
        public string AutoCheque { get; set; }

        [DataMember]
        public string AutoRenewal { get; set; }

        [DataMember]
        public short BeforeMaturity { get; set; }

        [DataMember]
        public int BTenor { get; set; }

        [DataMember]
        public string CapAccNumber { get; set; }

        [DataMember]
        public short CapAccNumber_Cd { get; set; }

        [DataMember]
        public decimal CapIncreaseAmnt { get; set; }

        [DataMember]
        public decimal ChangePerc { get; set; }

        [DataMember]
        public short ChequeTollDays { get; set; }

        [DataMember]
        public DateTime CollateralDate { get; set; }

        [DataMember]
        public string ConditionalAccount { get; set; }

        [DataMember]
        public short CorrespondenseCustomerSN { get; set; }

        [DataMember]
        public short CorrespondenseHolderSN { get; set; }

        [DataMember]
        public DateTime CreditExpDate { get; set; }

        [DataMember]
        public string CreditFixed { get; set; }

        [DataMember]
        public string CreditIndicator { get; set; }

        [DataMember]
        public int CreditInterestRate { get; set; }

        [DataMember]
        public decimal CreditSpread { get; set; }

        [DataMember]
        public int CurrencyID { get; set; }

        [DataMember]
        public int CustomerCBSCd { get; set; }

        [DataMember]
        public int CustomerCBSCd2 { get; set; }

        [DataMember]
        public int CustomerCBSCd3 { get; set; }

        [DataMember]
        public int CustomerCBSCd4 { get; set; }

        [DataMember]
        public int CustomerCBSCd5 { get; set; }

        [DataMember]
        public int CustomerCBSCd6 { get; set; }

        [DataMember]
        public int CustomerCBSCd7 { get; set; }

        [DataMember]
        public int CustomerCBSCd8 { get; set; }

        [DataMember]
        public int CustomerCBSCd9 { get; set; }

        [DataMember]
        public int CustomerCBSId { get; set; }

        [DataMember]
        public int CustomerCBSId2 { get; set; }

        [DataMember]
        public int CustomerCBSId3 { get; set; }

        [DataMember]
        public int CustomerCBSId4 { get; set; }

        [DataMember]
        public int CustomerCBSId5 { get; set; }

        [DataMember]
        public int CustomerCBSId6 { get; set; }

        [DataMember]
        public int CustomerCBSId7 { get; set; }

        [DataMember]
        public int CustomerCBSId8 { get; set; }

        [DataMember]
        public int CustomerCBSId9 { get; set; }

        [DataMember]
        public int DayFrom { get; set; }

        [DataMember]
        public int DayTo { get; set; }

        [DataMember]
        public DateTime DebitExpDate { get; set; }

        [DataMember]
        public string DebitIndicator { get; set; }

        [DataMember]
        public int DebitInterestRate { get; set; }

        [DataMember]
        public decimal DebitSpread { get; set; }

        [DataMember]
        public decimal DiscPerc { get; set; }

        [DataMember]
        public DateTime ExpDateCheque { get; set; }

        [DataMember]
        public string ExternalAccount { get; set; }

        [DataMember]
        public decimal FIAmount { get; set; }

        [DataMember]
        public int FIFrequency { get; set; }

        [DataMember]
        public string IRDISAccNumber { get; set; }

        [DataMember]
        public short IRDISAccNumber_Cd { get; set; }

        [DataMember]
        public decimal IssCheque { get; set; }

        [DataMember]
        public decimal LimitToll { get; set; }

        [DataMember]
        public decimal MarginChange { get; set; }

        [DataMember]
        public decimal MaxDrawAmnt { get; set; }

        [DataMember]
        public int MaxPeriod { get; set; }

        [DataMember]
        public short MonthFrom { get; set; }

        [DataMember]
        public short MonthlyGross { get; set; }

        [DataMember]
        public short MonthTo { get; set; }

        [DataMember]
        public string MovedByHouse { get; set; }

        [DataMember]
        public string MutualFunds { get; set; }

        [DataMember]
        public int NoCheque { get; set; }

        [DataMember]
        public string NonDeduction { get; set; }

        [DataMember]
        public string Notes { get; set; }

        [DataMember]
        public int OpeningUnit { get; set; }

        [DataMember]
        public decimal OverdraftLimitMargin { get; set; }

        [DataMember]
        public DateTime OverdraftMaturity { get; set; }

        [DataMember]
        public int PenaltyIR { get; set; }

        [DataMember]
        public string PrintMandate { get; set; }

        [DataMember]
        public int ProductID { get; set; }

        [DataMember]
        public string ProductType { get; set; }

        [DataMember]
        public int Purpose { get; set; }

        [DataMember]
        public DateTime RenewalDate { get; set; }

        [DataMember]
        public DateTime ReviewDate { get; set; }

        [DataMember]
        public decimal Risk { get; set; }

        [DataMember]
        public int SalesUnit { get; set; }

        [DataMember]
        public string SecondaryAccountNumber { get; set; }

        [DataMember]
        public short SecondaryAccountNumber_Cd { get; set; }

        [DataMember]
        public string Seller { get; set; }

        [DataMember]
        public decimal ServiceCharges { get; set; }

        [DataMember]
        public string SNCheque { get; set; }

        [DataMember]
        public string SpecialAccount { get; set; }

        [DataMember]
        public string Statement { get; set; }

        [DataMember]
        public string StatementFreq { get; set; }

        [DataMember]
        public string TaxCountryDescr { get; set; }

        [DataMember]
        public string Telebank { get; set; }

        [DataMember]
        public decimal TempLimit { get; set; }

        [DataMember]
        public DateTime TempLimitEnd { get; set; }

        [DataMember]
        public DateTime TempLimitStart { get; set; }

        [DataMember]
        public short ValPeriod { get; set; }

        [DataMember]
        public string WithdrawalUnclear { get; set; }

        #endregion Public Properties
    }
}