using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveMediatorsRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public virtual int AgreementCode { get; set; }

        #endregion Public Properties
    }
}