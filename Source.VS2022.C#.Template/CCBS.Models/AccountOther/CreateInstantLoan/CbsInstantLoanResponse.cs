namespace CCBS.Models
{
    public class CbsInstantLoanResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Entity: cr_lamast
        /// Description: Agreement Status
        /// Data Type: varchar (1)
        /// Notes: This property has a note indicating the lack of a description in your provided data.
        /// </summary>
        public string agree_status { get; set; }

        /// <summary>
        /// Entity: cr_lamast
        /// Description: Agreement Number
        /// Data Type: varchar (30)
        /// </summary>
        public string agreementno { get; set; }

        /// <summary>
        /// Entity: cr_lamast
        /// Description: Agreement Check Digit
        /// Data Type: integer
        /// </summary>
        public int agreementnocd { get; set; }

        /// <summary>
        /// Entity: cr_lamast
        /// Description: Agreement Limit
        /// Data Type: decimal (19,3)
        /// </summary>
        public decimal cbs_agreementlimit { get; set; }

        /// <summary>
        /// Entity: cr_lamast
        /// Description: Status
        /// Data Type: varchar (1)
        /// Notes: This property has a note indicating the lack of a description in your provided data.
        /// </summary>
        public string cbs_apid_status { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateInstantLoan
        /// Description: Application Id
        /// Data Type: varchar (15)
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Entity: cr_ladis
        /// Description: Loan Account
        /// Data Type: varchar (30)
        /// </summary>
        public string loanaccount { get; set; }

        /// <summary>
        /// Entity: cr_ladis
        /// Description: Loan Account Check Digit
        /// Data Type: integer
        /// </summary>
        public int profitsaccountcd { get; set; }

        #endregion Public Properties
    }
}