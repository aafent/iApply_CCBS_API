using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetListMediatorsResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public List<Mediators> MediatorsList { get; set; } = new();

        #endregion Public Properties
    }
}