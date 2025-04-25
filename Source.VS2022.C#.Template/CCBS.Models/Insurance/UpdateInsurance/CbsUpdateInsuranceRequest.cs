namespace CCBS.Models
{
    public class CbsCoinsured
    {
        #region Public Properties

        public string CustId { get; set; }

        public decimal? LoadingPercentage { get; set; }

        #endregion Public Properties
    }

    public class CbsUpdateInsuranceRequest : BaseCbsRequestModel
    {
        #region Public Properties

        public string ApplicationBranch { get; set; }

        public string CbsId { get; set; }

        public List<CbsCoinsured> Coinsured { get; set; }

        public string Comments { get; set; }

        public int? CompanyAccount { get; set; }

        public string CompanyBankNo { get; set; }

        public string CompanyId { get; set; }

        public decimal? CoverageRatio { get; set; }

        public string CurrencyId { get; set; }

        public string CurrentAccountCd { get; set; }

        public string CurrentAccountNumber { get; set; }

        public decimal? CustLoadPerc { get; set; }

        public string CustomerCBSId { get; set; }

        public string DebitAccount { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public string FkAccSn { get; set; }

        public string FkAccType { get; set; }

        public string FkAccUnit { get; set; }

        public int? InsuranceFrequency { get; set; }

        public string InsuranceFrequencyUnit { get; set; }

        public string InsuranceType { get; set; }

        public decimal? InsuredAmount { get; set; }

        public decimal? LoadingPercentage { get; set; }

        public string LoanAccountCd { get; set; }

        public string LoanAccountNumber { get; set; }

        public string ProductId { get; set; }

        public DateTime? RenewalDate { get; set; }

        public string SaleUser { get; set; }

        public string Status { get; set; }

        public DateTime? Timestamp { get; set; }

        #endregion Public Properties
    }
}