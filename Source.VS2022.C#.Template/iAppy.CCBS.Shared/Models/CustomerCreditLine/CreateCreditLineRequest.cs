using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CreateCreditLineRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string CustomerID { get; set; }

        [DataMember]
        public int RowIndex { get; set; }

        #endregion Public Properties
    }
}