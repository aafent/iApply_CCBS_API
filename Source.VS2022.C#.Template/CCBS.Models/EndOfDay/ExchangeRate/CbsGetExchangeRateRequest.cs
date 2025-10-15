namespace CCBS.Models
{
    /// <summary>
    /// Request for exchangeRate
    /// </summary>
    public class CbsGetExchangeRateRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The 3-letter ISO code of the base currency(e.g., "USD").
        /// </summary>
        public string baseCCY { get; set; }

        /// <summary>
        /// The 3-letter ISO code of the target currency(e.g., "EUR").
        /// </summary>
        public string targetCCY { get; set; }

        /// <summary>
        /// Optional, default is null. Date of the exchange rate (format: "YYYY-MM-DD").
        /// </summary>
        public DateTime rateDate { get; set; }
        #endregion Public Properties
    }
}
