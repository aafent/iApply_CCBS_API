using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class LoanCalculatorResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public decimal FinalQualifyingAmount { get; set; }

        [DataMember]
        public decimal NetTakeHome { get; set; }

        [DataMember]
        public decimal QualifyingDepositAmount { get; set; }

        [DataMember]
        public decimal QualifyingIncomeAmount { get; set; }

        #endregion Public Properties
    }
}