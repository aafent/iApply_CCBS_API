namespace iApplyShared.CbsModels
{
    public class CbsUpdateLGBeneficiaryResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// LG CBS Id (varchar (20))
        /// </summary>
        public string clnum { get; set; }

        /// <summary>
        /// Customer Id (varchar (15))
        /// </summary>
        public string cu_id { get; set; }

        #endregion Public Properties
    }
}