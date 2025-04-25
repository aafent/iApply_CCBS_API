namespace CCBS.Models
{
    public class CbsUpdateCreditLineResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Entity: cr_cucreditline
        /// Description: Source
        /// Data Type: varchar (1)
        /// </summary>
        public string CrFromCbs { get; set; }

        #endregion Public Properties
    }
}