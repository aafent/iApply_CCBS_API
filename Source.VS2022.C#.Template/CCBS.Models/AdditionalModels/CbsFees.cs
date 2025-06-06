namespace CCBS.Models
{
    /// <summary>
    /// Fees
    /// </summary>
    public class CbsFees
    {
        /// <summary>
        /// Fee ID 
        /// </summary>
        public string feeID { get; set; } = null!;

        /// <summary>
        /// Fee type
        /// 1=amount, 2=presentence
        /// </summary>
        public string type { get; set; } = null!;

        /// <summary>
        /// Fee frequency type
        /// 1 once, 2 monthly, 3 yearly
        /// </summary>
        public string frequencyType { get; set; } = null!;

        /// <summary>
        /// Fee value
        /// </summary>
        public decimal value { get; set; }
    }
}
