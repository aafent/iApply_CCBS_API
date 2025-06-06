namespace CCBS.Models
{
    /// <summary>
    /// Response of the ExchangeRates for the CBS
    /// </summary>
    public class CbsExchangeRatesResponse : CommonResponseModel
    {
        #region Public Properties

        public List<CurrencyInfo> CurrenciesInfo { get; set; }

        #endregion Public Properties
    }
}
