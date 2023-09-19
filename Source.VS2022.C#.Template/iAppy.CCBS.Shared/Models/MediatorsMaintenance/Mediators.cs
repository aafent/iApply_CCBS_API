using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    public class Mediators
    {
        #region Public Properties

        [DataMember]
        public int MediatorAgreementNo { get; set; }

        [DataMember]
        public string MediatorName { get; set; }

        #endregion Public Properties
    }
}