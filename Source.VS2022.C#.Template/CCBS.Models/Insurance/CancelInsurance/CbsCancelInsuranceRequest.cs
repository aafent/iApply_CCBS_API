namespace CCBS.Models
{
    public class CbsCancelInsuranceRequest : BaseCbsRequestModel
    {
        #region Public Properties

        public string CbsId { get; set; }

        public string DebitAccount { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public int? InsuranceFrequency { get; set; }

        public string InsuranceFrequencyUnit { get; set; }

        public DateTime? RenewalDate { get; set; }

        public DateTime? Timestamp { get; set; }

        #endregion Public Properties
    }
}