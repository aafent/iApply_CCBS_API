using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsUpdateCreditLineRequest : MockupModel
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
        public DateTime CrExpDate { get; set; }

        /// <summary>
        /// Entity: Next Review Date
        /// Description: CrNextRevDate
        /// Data Type: datetime
        /// </summary>
        public DateTime CrNextRevDate { get; set; }

        /// <summary>
        /// Entity: Review Date
        /// Description: CrRevDate
        /// Data Type: datetime
        /// </summary>
        public DateTime CrRevDate { get; set; }

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