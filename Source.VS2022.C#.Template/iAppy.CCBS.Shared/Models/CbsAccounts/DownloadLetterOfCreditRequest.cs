using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DownloadLetterOfCreditRequest : BaseRequest
    {
        #region Public Properties

        /// <summary>
        ///The LC account check digit	InLcAccount.LcAccCd	Numeric
        /// </summary>
        [DataMember]
        public short? AccountCd { get; set; }

        /// <summary>
        /// The LC account number	InLcAccount.LcAccountNumber	Text
        /// </summary>
        [DataMember]
        public string AccountNumber { get; set; }

        /// <summary>
        ///True if Account is Incoming
        ///False if Account is Outgoing
        /// </summary>
        [DataMember]
        public bool IsIncoming { get; set; }

        #endregion Public Properties
    }
}