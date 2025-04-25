namespace CCBS.Models
{
    public class CbsFinalizeInsuranceResponse : CommonResponseModel
    {
        #region Public Properties

        public string CbsId { get; set; }

        public decimal? AddInstalmAmnt { get; set; }

        public decimal? AnnualPremium { get; set; }

        public decimal? MonthlyPremium { get; set; }

        public decimal? DailyPremium { get; set; }

        public decimal? ProrataPremium { get; set; }

        public decimal? LoadingAmnt { get; set; }

        public decimal? RemainingAmnt { get; set; }

        public string EntryStatus { get; set; }

        public int TpSoIdentifier { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public DateTime? RenewalDate { get; set; }

        #endregion Public Properties
    }
}