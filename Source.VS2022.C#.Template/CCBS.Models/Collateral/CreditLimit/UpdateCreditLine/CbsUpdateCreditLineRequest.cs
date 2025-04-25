using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsUpdateCreditLineRequest : BaseCbsRequestModel
    {
        #region Public Properties

        public CbsRetrieveCreditLineResponse CbsRetrieveCreditLineResponseModel { get; set; }

        /// <summary>
        /// Entity: Credit Limit Amount
        /// Description: CrAmount
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CrAmount { get; set; }

        /// <summary>
        /// Entity: Credit Limit Currency
        /// Description: CrCcy
        /// Data Type: integer
        /// </summary>
        public int CrCcy { get; set; }

        /// <summary>
        /// Entity: Credit Limit Currency Description
        /// Description: CrCcyDescr
        /// Data Type: varchar (20)
        /// </summary>
        public string CrCcyDescr { get; set; }

        /// <summary>
        /// Entity: Expiry Date
        /// Description: CrExpDate
        /// Data Type: datetime
        /// </summary>
        public DateTime CrExpDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Entity: Next Review Date
        /// Description: CrNextRevDate
        /// Data Type: datetime
        /// </summary>
        public DateTime CrNextRevDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Entity: Review Date
        /// Description: CrRevDate
        /// Data Type: datetime
        /// </summary>
        public DateTime CrRevDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Entity: Credit Limit Type
        /// Description: CrType
        /// Data Type: integer
        /// </summary>
        public int CrType { get; set; }

        /// <summary>
        /// Entity: Customer Check Digit
        /// Description: CustomerCBSCd
        /// Data Type: integer
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Entity: Customer CBS Id
        /// Description: CustomerCBSId
        /// Data Type: integer
        /// </summary>
        [Mockup(1)]
        public int CustomerCBSId { get; set; }

        #endregion Public Properties
    }
}