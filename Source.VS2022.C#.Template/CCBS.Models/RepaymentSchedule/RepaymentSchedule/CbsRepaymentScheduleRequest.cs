namespace CCBS.Models
{
    public class CbsRepaymentScheduleFixRequest
    {
        /// <summary>
        /// Seq. 1
        /// Description: Account Number
        /// </summary>
        public string accountNumber { get; set; }

        /// <summary>
        /// Seq. 2
        /// Description: Account Check Digit
        /// </summary>
        public int accountCd { get; set; }
    }

}
