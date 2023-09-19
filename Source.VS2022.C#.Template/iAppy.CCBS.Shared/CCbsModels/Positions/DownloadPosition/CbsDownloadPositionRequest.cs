namespace iApplyShared.CbsModels
{
    public class CbsDownloadPositionRequest
    {
        #region Public Properties

        /// <summary>
        /// Customer Check Digit
        /// </summary>
        public int CustomerCbsCd { get; set; }

        /// <summary>
        /// Customer CBS Id
        /// </summary>
        public string customerCbsId { get; set; }

        #endregion Public Properties
    }
}