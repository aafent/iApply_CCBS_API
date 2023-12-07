namespace iApplyShared.CbsModels
{
    public class CbsSaveRepScenarioResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Seq: 3
        /// Entity: cr_laresc_save
        /// Description: CBS Serial Num
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int cbs_serial_num { get; set; }

        /// <summary>
        /// Seq: 1
        /// Entity: cr_laresc_save
        /// Description: Application Id
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Seq: 2
        /// Entity: cr_laresc_save
        /// Description: Serial Num
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int serial_num { get; set; }

        #endregion Public Properties
    }
}