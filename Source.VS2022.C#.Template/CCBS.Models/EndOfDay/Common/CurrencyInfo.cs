namespace CCBS.Models
{
    public class CurrencyInfo
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
        /// Date of the exchange rate(format: "YYYY-MM-DD").
        /// </summary>
        public string rateDate { get; set; }

        /// <summary>
        /// Optional default is null.
        /// A timestamp of the rate data from the CBS.
        /// </summary>
        public int rateTimestamp { get; set; }

        /// <summary>
        /// The mid-market rate(average between buy and sell).
        /// </summary>
        public float midRate { get; set; }

        /// <summary>
        /// The rate at which the bank or service buys the base currency(customer sells).
        /// </summary>
        public float buyRate { get; set; }

        /// <summary>
        /// The rate at which the bank or service sells the base currency(customer buys).
        /// </summary>
        public float sellRate { get; set; }

        /// <summary>
        /// Optional, default is CBS
        /// Name of the data source or financial institution.
        /// </summary>
        public string provider { get; set; }

        /// <summary>
        /// Optional, default is 1 The amount for which the rate applies(useful for tiered rates).
        /// Many times referred as “market amount”
        /// </summary>
        public int amount { get; set; }

        /// <summary>
        /// Optional,
        /// Any additional service or transaction fees.
        /// </summary>
        public float fees { get; set; }

        #endregion Public Properties
    }
}
