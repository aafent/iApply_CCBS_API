namespace iApplyShared.CbsModels
{
    public class CbsUpdateLegalCustomerResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// CBS S/N (integer)
        /// </summary>
        public int AddressSerialNum { get; set; }

        public List<CustomerIdentification> CustomerIdentificationList { get; set; }

        #endregion Public Properties
    }
}