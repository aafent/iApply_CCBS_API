using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsSearchCustomerAccountsRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Account Type (varchar (10))
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar (20))
        /// </summary>
        [Mockup(1)]
        public string CustomerID { get; set; }

        /// <summary>
        /// Account Customer Type (varchar (10))
        /// Cod from G015
        /// </summary>
        public string CustomerType { get; set; }

        /// <summary>
        /// Product Id (varchar (30))
        /// </summary>
        public string ProductID { get; set; }

        #endregion Public Properties
    }
}