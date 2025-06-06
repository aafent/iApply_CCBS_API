namespace CCBS.Models
{
    /// <summary>
    /// Common fields to all responses. 
    /// </summary>
    public class CommonResponseModel : ICommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// An error message to return to the caller. 
        /// </summary>
        public string Message { get; set; } = null!;

        /// <summary>
        /// true is the request succeed, false if an error occurred
        /// </summary>
        public bool Success { get; set; } = false;


        /// <summary>
        /// Extensions to the standard specification
        /// </summary>
        public object extensions { get; set; } = null!;
        #endregion Public Properties
    }
}