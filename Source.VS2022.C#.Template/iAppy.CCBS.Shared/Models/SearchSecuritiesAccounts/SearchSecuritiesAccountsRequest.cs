using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class SearchSecuritiesAccountsRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string FilterBondDescGr { get; set; }

        [DataMember]
        public string FilterBondIsIn { get; set; }

        [DataMember]
        public short SecuritiesTypeId { get; set; }

        #endregion Public Properties
    }
}