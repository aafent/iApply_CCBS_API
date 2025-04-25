namespace CCBS.Models
{
    public class CbsCreateInsuranceRequest : BaseCbsRequestModel
    {
        #region Public Properties

        public DateTime? ActivationDate { get; set; }

        public DateTime? CalculationDate { get; set; }

        public List<CbsCoinsured> Coinsured { get; set; }

        public string Comments1 { get; set; }

        public string CompanyBankNo { get; set; }

        public decimal CoverRatio { get; set; }

        public string CrAccCustomerId { get; set; }

        public double CrDepAccount { get; set; }

        public string CurrencyId { get; set; }

        public short CurrentAccountCd { get; set; }

        public string CurrentAccountNumber { get; set; }

        public int DrAccCustomerId { get; set; }

        public string EntryStatus { get; set; }

        public int FkResponsibleUnit { get; set; }

        //public int FkCategory { get; set; }
        public short Frequency { get; set; }

        public string FrequencyUnit { get; set; }

        public decimal GradAppExpRatio { get; set; }

        public decimal InsuranceValue { get; set; }

        //public short InLoanAccProfitsAccountPrftSystem { get; set; }
        public DateTime? IssueDate { get; set; }

        //public short InDepositAccProfitsAccountPrftSystem { get; set; }
        public short IssueType { get; set; }

        public short LoanAccountCd { get; set; }

        public string LoanAccountNumber { get; set; }

        //public short InCrDepProfitsAccountPrftSystem { get; set; }
        public string LoanInd { get; set; }

        public string SaleUser { get; set; }

        public int ServiceProduct { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public DateTime? RenewalDate { get; set; }

        #endregion Public Properties
    }
}