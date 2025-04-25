namespace CCBS.Models
{
    public class CbsCreateInsuranceResponse : CommonResponseModel
    {
        #region Public Properties

        public decimal? AddInstalmAmnt { get; set; }

        public decimal? AnnualPremium { get; set; }

        public decimal? DailyPremium { get; set; }

        public string EntryStatus { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public decimal? LoadingAmnt { get; set; }

        public decimal? MonthlyPremium { get; set; }

        public decimal? ProrataPremium { get; set; }

        public decimal? RemainingAmnt { get; set; }

        public DateTime? RenewalDate { get; set; }

        public int TpSoIdentifier { get; set; }

        public double CbsId { get; set; }

        #endregion Public Properties
    }
}