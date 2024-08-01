namespace CCBS.Models
{
    public class CbsRepaymentScheduleSimView
    {
        #region Public Properties

        public virtual DateTime? AccountOpenDate { get; set; }

        public virtual int? ActivitySector { get; set; }

        public virtual short? AgreementCd { get; set; }

        public virtual string AgreementNo { get; set; }

        public virtual string AmortGPInter { get; set; }

        public virtual decimal? Amount { get; set; }

        public virtual DateTime? ApplicationDate { get; set; }

        public virtual string ApplicationId { get; set; }

        public virtual DateTime? BirthDate { get; set; }

        public virtual string Branch { get; set; }

        public virtual string CapitFlg { get; set; }

        public virtual int? CentralBank { get; set; }

        public virtual decimal? ContributionInterestPerc { get; set; }

        public virtual int? ContributionInterestRate { get; set; }

        public virtual int? ContributionInterestRateCode { get; set; }

        public virtual int? CurrencyCode { get; set; }

        public virtual string CurrencyDescription { get; set; }

        public virtual int? CustomerCategory { get; set; }

        public virtual int? CustomerCBSCd { get; set; }

        public virtual int? CustomerCBSId { get; set; }

        public virtual string CustomerId { get; set; }

        public virtual int? DaysBase { get; set; }

        public virtual int DecimalPlace { get; set; }

        public virtual short? DepositCd { get; set; }

        public virtual string DepositNo { get; set; }

        public virtual string DiffIntAlgorithm { get; set; }

        public virtual DateTime? DisbDate { get; set; }

        public virtual int? DivisionAddress { get; set; }

        public virtual decimal? DrawdownCapitalAmount { get; set; }

        public virtual DateTime? DrawDownExpDate { get; set; }

        public virtual string FinalScenario { get; set; }

        public virtual int? FinancialSector { get; set; }

        public virtual DateTime? FirstInstallmentDate { get; set; }

        public virtual short? FixedDuration { get; set; }

        public virtual short? FixedDurationInMonths { get; set; }

        public virtual string FixedDurationUnit { get; set; }

        public virtual decimal? FixedInterestPerc { get; set; }

        public virtual int? FixedInterestRate { get; set; }

        public virtual DateTime? FixedIntExpDate { get; set; }

        public virtual int Flag1 { get; set; }

        public virtual int Flag2 { get; set; }

        public virtual int Flag3 { get; set; }

        public virtual int Flag4 { get; set; }

        public virtual decimal? FloatingInterestPerc { get; set; }

        public virtual int? FloatingInterestRateCode { get; set; }

        public virtual int? FreqMorat { get; set; }

        public virtual short? Frequency { get; set; }

        public virtual string GeneralFlags { get; set; }

        public virtual DateTime? GracePeriodExpiryDate { get; set; }

        public virtual short? InGracePeriod { get; set; }

        public virtual short? InstallmentsNo { get; set; }

        public virtual int? InsuranceCode { get; set; }

        public virtual decimal? InsuredAmount { get; set; }

        public virtual string IntPayFlg { get; set; }

        public virtual string IsIpf { get; set; }

        public virtual int? LoanPurpose { get; set; }

        public virtual string MainBenef { get; set; }

        public virtual string MaintainEqInst { get; set; }

        public virtual DateTime? MaturityDate { get; set; }

        public virtual string NonCapitFlg { get; set; }

        public virtual string PayFlg { get; set; }

        public virtual int? PenaltyInterestRateCode { get; set; }

        public virtual string ProductCategory { get; set; }

        public virtual int? ProductId { get; set; }

        public virtual DateTime Request_Dt { get; set; }

        public virtual int? SalesUnit { get; set; }

        public virtual int? Seller { get; set; }

        public virtual decimal? Spread { get; set; }

        public virtual int? StmFrequency { get; set; }

        public virtual string Supplied { get; set; }

        public virtual decimal? Term { get; set; }

        public virtual int? TransactInd { get; set; }

        public virtual int? TransactSm { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as CbsRepaymentScheduleSimView;
            if (t == null) return false;
            return (GetHashCode() == t.GetHashCode());
        }

        public override int GetHashCode()
        {
            return ApplicationId.GetHashCode();
        }

        #endregion Public Methods
    }
}