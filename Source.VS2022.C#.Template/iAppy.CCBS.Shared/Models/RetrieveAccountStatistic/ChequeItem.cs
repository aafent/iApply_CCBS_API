using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class ChequeItem
    {
        #region Public Properties

        [DataMember]
        public DateTime BouncedDate { get; set; }

        [DataMember]
        public decimal ChequeAmt { get; set; }

        [DataMember]
        public decimal ChequeCd { get; set; }

        [DataMember]
        public DateTime DishonorDate { get; set; }

        [DataMember]
        public decimal SerialNum { get; set; }

        #endregion Public Properties
    }
}