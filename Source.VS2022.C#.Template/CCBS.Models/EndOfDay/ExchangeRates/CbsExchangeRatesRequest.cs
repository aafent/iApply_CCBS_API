namespace CCBS.Models
{
    /// <summary>
    /// Request of the ExchangeRates for the CBS
    /// </summary>
    public class CbsExchangeRatesRequest : BaseCbsRequestModel
    {
        #region Public Properties
        /// <summary>
        /// The 3-letter ISO code of the base currency(e.g., "USD").
        /// </summary>
        public string baseCCY { get; set; }

        /// <summary>
        /// Optional, default is null. Date of the exchange rate (format: "YYYY-MM-DD").
        /// </summary>
        public DateTime rateDate { get; set; }
        #endregion Public Properties
    }
}
