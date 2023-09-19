using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveMortgageResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public MortgageProperty[] MissingProperties { get; set; }

        [DataMember]
        public string mort_id { get; set; }

        #endregion Public Properties
    }
}