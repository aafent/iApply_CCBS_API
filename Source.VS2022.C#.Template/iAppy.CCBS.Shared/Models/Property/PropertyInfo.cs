using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class PropertyInfo
    {
        #region Public Properties

        [DataMember]
        public decimal GRMAgreemnentValue { get; set; }

        [DataMember]
        public decimal GRMOriginalAmount { get; set; }

        [DataMember]
        public string GRMRegistrationID { get; set; }

        [DataMember]
        public string GRMStatus { get; set; }

        [DataMember]
        public string GRMType { get; set; }

        [DataMember]
        public string RealEstateDescription { get; set; }

        [DataMember]
        public double RealEstateID { get; set; }

        #endregion Public Properties
    }
}