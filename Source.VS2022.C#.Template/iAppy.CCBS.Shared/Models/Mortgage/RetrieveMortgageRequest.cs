using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveMortgageRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string ApplicationID { get; set; }

        [DataMember]
        public int MortgageCBSID { get; set; }

        #endregion Public Properties
    }
}