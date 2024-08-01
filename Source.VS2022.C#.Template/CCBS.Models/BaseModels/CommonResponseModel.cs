namespace CCBS.Models
{
    public class CommonResponseModel : ICommonResponseModel
    {
        #region Public Properties

        public string Message { get; set; }

        public bool Success { get; set; }

        #endregion Public Properties
    }
}