using iApply.CCBS.Shared.CCbsModels;
using IApplyDataAccess.DataModel;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsDownloadRepScheduleSimRequest : MockupModel
    {
        #region Public Properties

        [Mockup(1)]
        public string ApplicationId { get; set; }

        public List<RepaymentScheduleSimInsuranceData> RepaymentScheduleSimInsuranceData { get; set; }

        public RepaymentScheduleSimView RepaymentScheduleSimViews { get; set; }

        #endregion Public Properties
    }
}