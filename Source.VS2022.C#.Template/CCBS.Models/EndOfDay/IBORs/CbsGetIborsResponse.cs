namespace CCBS.Models
{
    public class CbsGetIborsResponse : CommonResponseModel
    {
        #region Public Properties
        public List<IborInfo> iborInfos { get; set; }
        #endregion Public Properties
    }
}
