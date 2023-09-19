using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class LoanCalculatorRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string BasicIncome { get; set; }

        [DataMember]
        public string CheckDigit { get; set; }

        [DataMember]
        public string Duration { get; set; }

        [DataMember]
        public string Expenses { get; set; }

        [DataMember]
        public string MemberId { get; set; }

        [DataMember]
        public string OtherIncome { get; set; }

        [DataMember]
        public string Product { get; set; }

        [DataMember]
        public string RequestAmount { get; set; }

        [DataMember]
        public List<TopUpAccounts> TopUpAccountsList { get; set; }

        #endregion Public Properties

        #region Public Classes

        [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
        public class TopUpAccounts
        {
            #region Public Properties

            [DataMember]
            public string AccountDescription { get; set; }

            [DataMember]
            public string AccountNumber { get; set; }

            #endregion Public Properties
        }

        #endregion Public Classes
    }
}