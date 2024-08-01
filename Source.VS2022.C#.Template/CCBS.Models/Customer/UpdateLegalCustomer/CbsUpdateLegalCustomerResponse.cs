namespace CCBS.Models
{
    public class CbsUpdateLegalCustomerResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// CBS S/N (integer)
        /// </summary>
        public int AddressSerialNum { get; set; }

        public List<CbsCustomerIdentification> CustomerIdentificationList { get; set; }

        #endregion Public Properties
    }
}