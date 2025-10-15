namespace CCBS.Models
{
    public class CbsGetIborRequest : BaseCbsRequestModel
    {
        #region Public Properties
        public string iborName { get; set; }
        public DateTime rateDate { get; set; }

        #endregion Public Properties
    }
}
