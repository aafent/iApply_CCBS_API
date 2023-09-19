using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class AgreementBeneficiary
    {
        #region Public Properties

        /// <summary>
        /// Name and surname concatination of beneficiary	OutListGrp[]OutListCustomerGrmListSet.Description	Text
        /// </summary>
        [DataMember]
        public string BeneficiaryFullName { get; set; }

        /// <summary>
        ///Beneficiary status	OutListGrp[]OutListGrmAgreementBenef.BenefStatus	Text
        ///The value '0' indicates that the beneficiary is deleted whereas the value '1' indicates that the beneficiary is active.
        /// </summary>
        [DataMember]
        public string BeneficiaryStatus { get; set; }

        /// <summary>
        /// Customers Check digit	OutListGrp[]OutListGrmCustomer.CDigit	Numeric
        /// </summary>
        [DataMember]
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Customers ID	OutListGrp[]OutListGrmCustomer.CustId	Numeric
        /// </summary>
        [DataMember]
        public int CustomerCBSId { get; set; }

        /// <summary>
        /// Main beneficiary flag	OutListGrp[]OutGrmAgreementWork.MainBenefFlg	Text
        /// The field is set to 'K' for the main beneficiary.
        /// </summary>
        [DataMember]
        public string MainBeneficiaryFlag { get; set; }

        #endregion Public Properties
    }
}