using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsDownloadRepScenarioRequest : BaseCbsRequestModel
    {
        #region Public Properties

        public int AmortGPInter { get; set; }

        public int CustomerCBSCd { get; set; }

        [Mockup(1)]
        public string CustomerCBSId { get; set; }

        #endregion Public Properties
    }
}