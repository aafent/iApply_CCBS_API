namespace iApplyShared.CbsModels
{
    public class CbsSearchCustomerAccountsResponse : CommonResponseModel
    {
        #region Public Properties

        public List<CustomerAccount> CustomerAccounts { get; set; }

        #endregion Public Properties
    }

    public class CustomerAccount
    {
        #region Public Properties

        /// <summary>
        /// Account Check Digit (integer)
        /// </summary>
        public int AccountCd { get; set; }

        /// <summary>
        /// Account Number (varchar (40))
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Monitoring Unit (varchar (15))
        /// </summary>
        public string MonotoringUnit { get; set; }

        /// <summary>
        /// Currency (varchar (15))
        /// </summary>
        public string MovementCurrency { get; set; }

        /// <summary>
        /// Account Type (varchar (15))
        /// </summary>
        public string PrftSystem { get; set; }

        /// <summary>
        /// Product Id (varchar (15))
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Account Status (varchar (15))
        /// </summary>
        public string Status { get; set; }

        #endregion Public Properties
    }
}