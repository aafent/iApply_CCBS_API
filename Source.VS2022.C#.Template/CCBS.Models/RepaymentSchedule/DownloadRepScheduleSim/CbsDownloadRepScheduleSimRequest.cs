using CCBS.Attributes;

namespace CCBS.Models
{
    /// <summary>
    /// Repayment Schedule Simulation - Request
    /// </summary>
    public class CbsDownloadRepScheduleSimRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Application ID. 
        /// Key for mock-up service
        /// </summary>
        [Mockup(1)]
        public string ApplicationId { get; set; }

        public List<RepaymentScheduleSimInsuranceData> RepaymentScheduleSimInsuranceData { get; set; }
        
        /// <summary>
        /// Repayment Schedule parameters (product details)
        /// </summary>
        public CbsRepaymentScheduleSimView RepaymentScheduleSimViews { get; set; }

        /// <summary>
        /// Fees array
        /// </summary>
        public CbsFees[] fees { get; set; } = null; 

        #endregion Public Properties
    }
}