namespace CCBS.Models
{
    public class CbsIborResponse : CommonResponseModel
    {
        #region Public Properties
        public IborInfo[] ibors {get; set; }
        #endregion Public Properties
    }
}
