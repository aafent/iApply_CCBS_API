using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DownloadTradeFinanceRequest : BaseRequest
    {
        /// <summary>
        /// Trade finance account check digit	InTradeFinance.TfCd	Numeric
        /// </summary>
        [DataMember]
        public string AccountNumber { get; set; }
        /// <summary>
        ///Trade finance account number	InTradeFinance.TfNumber	Text
        /// </summary>
        [DataMember]
        public short? AccountCd { get; set; }
        /// <summary>
        /// True if account is IMPORT
        /// False if account is EXPORT
        /// </summary>
        [DataMember]
        public bool IsImport { get; set; }
    }
}
