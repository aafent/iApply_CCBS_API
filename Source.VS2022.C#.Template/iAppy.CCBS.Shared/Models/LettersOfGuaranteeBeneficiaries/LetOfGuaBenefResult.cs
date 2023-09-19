using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class LetOfGuaBenefResult
    {
        #region Public Properties

        [DataMember]
        public string BenefAddress { get; set; }

        [DataMember]
        public string BenefAddress2 { get; set; }

        [DataMember]
        public string BenefAfmNo { get; set; }

        [DataMember]
        public string BenefCity { get; set; }

        [DataMember]
        public string BenefCode { get; set; }

        [DataMember]
        public string BenefComments { get; set; }

        [DataMember]
        public string BenefIdNo { get; set; }

        [DataMember]
        public string BenefName { get; set; }

        [DataMember]
        public string BenefPhone { get; set; }

        [DataMember]
        public string BenefProfess { get; set; }

        [DataMember]
        public string BenefRegion { get; set; }

        [DataMember]
        public string BenefSurname { get; set; }

        [DataMember]
        public string BenefZipCode { get; set; }

        #endregion Public Properties
    }
}