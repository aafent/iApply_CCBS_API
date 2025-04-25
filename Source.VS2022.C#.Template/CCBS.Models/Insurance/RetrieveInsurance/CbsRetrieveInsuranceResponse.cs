namespace CCBS.Models
{
    public class CbsRetrieveInsuranceResponse : CommonResponseModel
    {
        #region Public Properties

        public decimal? AddInstalmAmnt { get; set; }

        public decimal? AnnualPremium { get; set; }

        public DateTime? CalculationDate { get; set; }

        public double CbsId { get; set; }
        public string DebitAccount { get; set; }

        public string Comments { get; set; }

        public decimal CoverRatio { get; set; }

        public string CurrencyIdCurrency { get; set; }

        public decimal? DailyPremium { get; set; }

        public string EntryStatus { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public string FkDebitAccount { get; set; }

        public decimal GradAppExpRatio { get; set; }

        public decimal InsuranceValue { get; set; }

        public decimal? LoadingAmnt { get; set; }

        public decimal? MonthlyPremium { get; set; }

        public decimal? ProrataPremium { get; set; }

        public decimal? RemainingAmnt { get; set; }

        public DateTime? RenewalDate { get; set; }

        public DateTime? Tmstamp { get; set; }
        public string FkAccSn { get; set; }
        public string FkAccType { get; set; }
        public string FkAccUnit { get; set; }

        #endregion Public Properties
    }
}