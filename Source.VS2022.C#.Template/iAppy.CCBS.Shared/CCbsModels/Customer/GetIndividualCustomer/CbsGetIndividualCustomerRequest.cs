namespace iApplyShared.CbsModels
{
    public class CbsGetIndividualCustomerRequest
    {
        #region Public Properties

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar (20))
        /// </summary>
        public string CustomerCBSId { get; set; }

        #endregion Public Properties
    }
}