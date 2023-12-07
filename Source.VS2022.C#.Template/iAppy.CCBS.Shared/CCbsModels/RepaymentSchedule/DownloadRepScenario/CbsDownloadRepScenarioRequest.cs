using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsDownloadRepScenarioRequest : MockupModel
    {
        #region Public Properties

        public int AmortGPInter { get; set; }

        public int CustomerCBSCd { get; set; }

        [Mockup(1)]
        public string CustomerCBSId { get; set; }

        #endregion Public Properties
    }
}