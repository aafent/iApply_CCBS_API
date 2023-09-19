using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveMediatorsResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public virtual short AccountCd { get; set; }

        [DataMember]
        public virtual string AccountNumber { get; set; }

        [DataMember]
        public virtual short CheckDigit { get; set; }

        [DataMember]
        public virtual string Comments { get; set; }

        [DataMember]
        public virtual int Customer { get; set; }

        [DataMember]
        public virtual int MediatorCode { get; set; }

        [DataMember]
        public virtual string MeditorName { get; set; }

        [DataMember]
        public virtual int Type { get; set; }

        #endregion Public Properties
    }
}