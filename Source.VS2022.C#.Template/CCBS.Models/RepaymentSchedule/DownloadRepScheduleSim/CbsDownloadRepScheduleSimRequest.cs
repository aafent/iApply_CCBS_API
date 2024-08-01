using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsDownloadRepScheduleSimRequest : BaseCbsRequestModel
    {
        #region Public Properties

        [Mockup(1)]
        public string ApplicationId { get; set; }

        public List<RepaymentScheduleSimInsuranceData> RepaymentScheduleSimInsuranceData { get; set; }

        public CbsRepaymentScheduleSimView RepaymentScheduleSimViews { get; set; }

        #endregion Public Properties
    }
}