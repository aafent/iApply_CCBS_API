namespace CCBS.Models
{
    public class CbsDownloadRepScenarioSimResponse : CommonResponseModel
    {
        #region Public Properties

        public List<CbsGrace> Grace { get; set; }

        public List<CbsScenarioInstallment> Installments { get; set; }

        public List<CbsInsurance> Insurance { get; set; }

        public List<CbsMediators> Mediators { get; set; }

        #endregion Public Properties
    }
}