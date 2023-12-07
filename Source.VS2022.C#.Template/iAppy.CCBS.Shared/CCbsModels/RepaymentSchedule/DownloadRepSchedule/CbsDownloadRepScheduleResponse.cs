namespace iApplyShared.CbsModels
{
    public class CbsDownloadRepScheduleResponse : CommonResponseModel
    {
        #region Public Properties

        public List<CbsScheduleInstallment> Installments { get; set; }

        #endregion Public Properties
    }
}