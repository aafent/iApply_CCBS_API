using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DownloadLetterOfGuaranteeRequest : BaseRequest
    {
        #region Public Properties

        /// <summary>
        ///LG account number Check Digit	ProfitsAccountCd as clarified by Intrasoft
        /// </summary>
        [DataMember]
        public short? AccountCd { get; set; }

        /// <summary>
        ///LG account number	ProfitsAccountNumber 	as clarified by Intrasoft
        /// </summary>
        [DataMember]
        public string AccountNumber { get; set; }

        #endregion Public Properties
    }
}