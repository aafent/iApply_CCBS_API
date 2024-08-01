namespace CCBS.Models
{
    public class CbsCoinsuredDataModel
    {
        #region Public Properties

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Insurance Id
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutCoinsuredGrpOutGrmInsProdInsurProdCodeProdId
        /// </summary>
        public string insurance_id { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Insurance Amount
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpDbSelectedInsProdsInGrmInsuranceVlIefSuppliedAmount
        /// </summary>
        public decimal insured_amnt { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Applicant Birth Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: OutCoinsuredGrpOutBirthdatesBenefGrmIefSuppliedDate
        /// </summary>
        public DateTime insurer_birthdate { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Main Beneficiary
        /// Data Type: varchar (1)
        /// Notes: N/A
        /// CBS: OutCoinsuredGrpOutGrmMainBenefIefSuppliedFlag
        /// </summary>
        public string insurer_mainbf { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_laresc_insur_save
        /// Description: Serial Number
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpCustDataOutGrmLoanScenarioDataInstallSn
        /// </summary>
        public int serial_num { get; set; }

        #endregion Public Properties
    }
}