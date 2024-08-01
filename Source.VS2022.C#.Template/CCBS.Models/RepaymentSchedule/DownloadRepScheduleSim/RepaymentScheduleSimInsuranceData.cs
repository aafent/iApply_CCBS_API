namespace CCBS.Models
{
    public class RepaymentScheduleSimInsuranceData
    {
        /// <summary>
        /// Applicant Birth Date
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Main beneficiary flag	OutListGrp[]OutGrmAgreementWork.MainBenefFlg	Text
        /// The field is set to 'K' for the main beneficiary.
        /// </summary>
        public string MainBeneficiaryFlag { get; set; }

        /// <summary> 
        /// Insurance Code (integer) 
        /// </summary> 
        /// 
        public int? InsuranceCode { get; set; }

        /// <summary>
        /// Insured Amount
        /// </summary>
        public decimal? InsuredAmount { get; set; }
    }
}
