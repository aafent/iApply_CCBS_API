using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DownloadDepositAccountRequest : BaseRequest
    {
        #region Public Properties

        /// <summary>
        ///Deposit account number	InDepositAccount.AccountNumber	Numeric
        /// </summary>
        [DataMember]
        public short? AccountCd { get; set; }

        /// <summary>
        ///Deposit account number	InDepositAccount.AccountNumber	Numeric
        /// </summary>
        [DataMember]
        public string AccountNumber { get; set; }

        #endregion Public Properties
    }
}