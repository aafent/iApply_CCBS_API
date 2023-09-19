using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetListMediatorsResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public Mediators[] MediatorsList { get; set; }

        #endregion Public Properties
    }
}