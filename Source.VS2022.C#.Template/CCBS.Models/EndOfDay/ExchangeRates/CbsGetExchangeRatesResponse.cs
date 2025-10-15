namespace CCBS.Models
{
    /// <summary>
    /// Response of the ExchangeRates for the CBS
    /// </summary>
    public class CbsGetExchangeRatesResponse : CommonResponseModel
    {
        #region Public Properties

        public List<CurrencyInfo> currenciesInfo { get; set; }

        #endregion Public Properties
    }
}
