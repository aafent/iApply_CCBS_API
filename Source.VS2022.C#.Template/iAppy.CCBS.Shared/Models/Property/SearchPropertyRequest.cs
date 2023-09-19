using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class SearchPropertyRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public short? CheckDigit { get; set; }

        [DataMember]
        public double? CollateralInternalSerialNumber { get; set; }

        [DataMember]
        public int? CustomerId { get; set; }

        [DataMember]
        public string LandRegistrationID { get; set; }

        [DataMember]
        public double? RealEstateID { get; set; }

        #endregion Public Properties
    }
}