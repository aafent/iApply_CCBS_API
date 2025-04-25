namespace CCBS.Models
{
    public class CommonResponseModel : ICommonResponseModel
    {
        #region Public Properties

        public string Message { get; set; }

        public bool Success { get; set; }


        // added to keep extra information, customer specific
        public object extensions { get; set; }
        #endregion Public Properties
    }
}