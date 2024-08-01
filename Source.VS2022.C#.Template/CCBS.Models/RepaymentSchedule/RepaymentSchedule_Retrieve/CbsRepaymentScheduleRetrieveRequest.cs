namespace CCBS.Models
{
    public class CbsRepaymentScheduleRetrieveRequest
    {
        /// <summary>
        /// Seq. 1
        /// Description: Customer CBS Id
        /// Entities: v_CBS_RepScheduleSim_Save
        /// </summary>
        public string CustomerCBSId { get; set; }

        /// <summary>
        /// Seq. 2
        /// Description: GP IR Amortization
        /// Entities: v_CBS_RepScheduleSim_Save
        /// </summary>
        public int AmortGPInter { get; set; }

        /// <summary>
        /// Seq. 3
        /// Description: Customer Check Digit
        /// Entities: v_CBS_RepScheduleSim_Save
        /// </summary>
        public int CustomerCBSCd { get; set; }
    }

}
