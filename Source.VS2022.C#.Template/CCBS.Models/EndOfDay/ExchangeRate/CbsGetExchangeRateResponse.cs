namespace CCBS.Models
{
    /// <summary>
    /// Response of the ExchangeRates for the CBS
    /// </summary>
    public class CbsGetExchangeRateResponse : CommonResponseModel
    {
        #region Public Properties

        public CurrencyInfo currencyInfo { get; set; }

        #endregion Public Properties
    }
}
