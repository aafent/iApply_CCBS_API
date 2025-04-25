namespace CCBS.Models
{
    public class CbsInsuranceForecastRequest : BaseCbsRequestModel
    {
        #region Public Properties

        public string CbsId { get; set; }

        public List<CbsCoinsured> Coinsured;

        public int CurrencyIdCurrency { get; set; }

        public int CustomerCustId { get; set; }

        public decimal InsuredAmountIefSuppliedNumber184 { get; set; }

        public decimal InterestRateIefSuppliedRate84 { get; set; }

        public DateTime IssCommitmentExpirationDate { get; set; }

        public DateTime IssCommitmentRenewalDate { get; set; }

        public int IssProductProductIdProduct { get; set; }

        public decimal LoadingPercentIefSuppliedNumber96 { get; set; }

        public System.DateTime LoanAccountDrawdownFstDt { get; set; }

        public short LoanTermIefSuppliedNumber3 { get; set; }

        public decimal ReinstatementValueIefSuppliedNumber184 { get; set; }

        #endregion Public Properties
    }
}