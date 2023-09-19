using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class SearchPropertyResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public PropertyInfo[] PropertyInfos { get; set; }

        #endregion Public Properties
    }
}