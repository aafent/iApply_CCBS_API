namespace iApplyShared.CbsModels
{
    public class CbsInsertFeeResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Source
        /// Data Type: varchar (1)
        /// Entities: crp_CBS_updatefees
        /// Notes: 2
        /// </summary>
        public string source { get; set; }

        #endregion Public Properties
    }
}