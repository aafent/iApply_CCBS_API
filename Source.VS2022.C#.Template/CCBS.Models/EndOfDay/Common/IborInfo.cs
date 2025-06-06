namespace CCBS.Models
{
    public class IborInfo
    {
        #region Public Properties

        /// <summary>
        /// The iApply IBOR Name as requested
        /// </summary>
        public string iborName { get; set; }

        /// <summary>
        /// Optional, default is null,
        /// The CBS code that is responding to the request for the IBOR iApply name.
        /// </summary>
        public string cbsCode { get; set; }

        /// <summary>
        /// Date of the interest rate (format: "YYYY-MM-DD").
        /// </summary>
        public string rateDate { get; set; }

        /// <summary>
        /// Optional default is null.
        /// A timestamp of the rate data from the CBS.
        /// </summary>
        public int rateTimestamp { get; set; }

        /// <summary>
        /// The interest rate of the requested IBOR
        /// </summary>
        public decimal interestRate { get; set; }

        /// <summary>
        /// Optional, default is CBS
        /// Name of the data source or financial institution.
        /// </summary>
        public string provider { get; set; }

        /// <summary>
        /// Optional, CBS Specific reference
        /// </summary>
        public string referenceKey { get; set; }

        #endregion Public Properties
    }
}
