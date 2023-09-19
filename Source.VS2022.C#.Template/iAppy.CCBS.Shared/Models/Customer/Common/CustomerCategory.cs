using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CustomerCategory
    {
        #region Public Properties

        [DataMember]
        public string CategoryCode { get; set; }

        [DataMember]
        public string CategoryDescription { get; set; }

        [DataMember]
        public DateTime CategoryTmstamp { get; set; }

        [DataMember]
        public string DetailDescription { get; set; }

        [DataMember]
        public int DetailSerialNum { get; set; }

        [DataMember]
        public string HeaderParameterType { get; set; }

        [DataMember]
        public string SuppliedFlag { get; set; }

        [DataMember]
        public string SuppliedSelectChar { get; set; }

        #endregion Public Properties
    }
}