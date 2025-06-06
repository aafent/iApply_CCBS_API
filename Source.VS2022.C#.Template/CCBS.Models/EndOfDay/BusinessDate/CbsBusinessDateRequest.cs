namespace CCBS.Models
{
    public class CbsGetBusinessDateRequest : BaseCbsRequestModel
    {
        #region Public Properties
        public string bankGroup {  get; set; }
        public string bankCode { get; set; }  

        #endregion Public Properties
    }
}
