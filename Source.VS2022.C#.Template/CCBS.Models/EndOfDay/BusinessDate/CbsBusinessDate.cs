namespace CCBS.Models
{
    public class CbsBusinessDate : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The current banking date of the CBS. (format: "YYYY-MM-DD")
        /// </summary>
        public string currentDate {get;set;}

        /// <summary>
        /// Optional, default is null, The previous banking date (format: "YYYY-MM-DD").
         /// </summary>
        public string prevDate {get; set;}

        /// <summary>
        /// Optional, default is null, The next banking date (format: "YYYY-MM-DD").
        /// </summary>
        public string nextDate {get; set; }
        #endregion Public Properties
    }
}
