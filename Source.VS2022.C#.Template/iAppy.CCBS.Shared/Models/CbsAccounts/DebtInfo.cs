using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DebtInfo
    {
        #region Public Properties

        [DataMemberAttribute]
        public DateTime AppraisalDate { get; set; }

        [DataMemberAttribute]
        public double CollateralId { get; set; }

        [DataMemberAttribute]
        public int CollateralType { get; set; }

        [DataMemberAttribute]
        public string CollateralTypeDescription { get; set; }

        [DataMemberAttribute]
        public decimal ForcedSaleValue { get; set; }

        [DataMemberAttribute]
        public string ForcedSaleValuecurrency { get; set; }

        [DataMemberAttribute]
        public decimal InsuranceValue { get; set; }

        [DataMemberAttribute]
        public string InsuranceValueCurrency { get; set; }

        [DataMemberAttribute]
        public decimal InvestmentInsuranceValue { get; set; }

        [DataMemberAttribute]
        public string InvestmentValueCurrency { get; set; }

        [DataMemberAttribute]
        public string LRnumber { get; set; }

        [DataMemberAttribute]
        public decimal MarketValue { get; set; }

        [DataMemberAttribute]
        public decimal MortgageValue { get; set; }

        [DataMemberAttribute]
        public string MortgageValueCurrency { get; set; }

        [DataMemberAttribute]
        public decimal OpenMarketValue { get; set; }

        [DataMemberAttribute]
        public string OpenMarketValueCurrency { get; set; }

        [DataMemberAttribute]
        public decimal ReserveValue { get; set; }

        [DataMemberAttribute]
        public string ReserveValueCurrency { get; set; }

        [DataMemberAttribute]
        public decimal SecurityValue { get; set; }

        [DataMemberAttribute]
        public string ValuerName { get; set; }

        [DataMemberAttribute]
        public string ValuerType { get; set; }

        #endregion Public Properties
    }
}