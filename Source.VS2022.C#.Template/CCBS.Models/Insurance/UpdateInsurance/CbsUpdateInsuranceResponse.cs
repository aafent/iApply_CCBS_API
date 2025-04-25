namespace CCBS.Models
{
    public class CbsUpdateInsuranceResponse : CommonResponseModel
    {
        #region Public Properties

        public decimal? AddInstalmAmnt { get; set; }

        public decimal? AnnualPremium { get; set; }

        public string CbsId { get; set; }

        public decimal? DailyPremium { get; set; }
        public string DebitAccount { get; set; }

        public string EntryStatus { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public decimal? LoadingAmnt { get; set; }

        public decimal? MonthlyPremium { get; set; }

        public decimal? ProrataPremium { get; set; }

        public decimal? RemainingAmnt { get; set; }

        public DateTime? RenewalDate { get; set; }

        #endregion Public Properties
    }
}