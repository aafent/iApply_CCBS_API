using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetAccountInfoRequest : BaseRequest
    {
        #region Public Properties

        /// <summary>
        ///Account Check Digit InProfitsAccount.AccountCd
        /// </summary>
        [DataMember(IsRequired = true)]
        public short AccountCd { get; set; }

        /// <summary>
        ///Account number	InProfitsAccount.AccountNumber
        /// </summary>
        [DataMember(IsRequired = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        ///Account type	InProfitsSystemProfitsAccount.PrftSystem
        /// Description: The system of the Account, 3 - Deposit 4 - Loans 14 - LG 19 - Agreements etc…
        /// </summary>
        [DataMember(IsRequired = true)]
        public short AccountType { get; set; }

        [DataMember(IsRequired = true)]
        public string CustomerId { get; set; }

        #endregion Public Properties
    }
}