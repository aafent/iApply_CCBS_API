using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsDownloadRepScenarioSimRequest : BaseCbsRequestModel
    {
        #region Public Properties


        /// <summary>
        /// Product Code (integer)
        /// </summary>
        [Mockup(1)]
        public int ProductId { get; set; }

        public CbsRepaymentScenarioView RepaymentScenarioViews { get; set; }

        public List<RepaymentScheduleInsuranceData> RepaymentScheduleInsuranceData { get; set; }

        #endregion Public Properties

        #region Public Constructors

        public CbsDownloadRepScenarioSimRequest()
        {
        }

        public CbsDownloadRepScenarioSimRequest(CbsRepaymentScenarioView view, List<RepaymentScheduleInsuranceData> data)
        {
            RepaymentScenarioViews = view;
            RepaymentScheduleInsuranceData = data;
        }

        #endregion Public Constructors
    }
}