using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsRetrieveCbsCollateralRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Collateral CBS Id
        /// Data Type: integer
        /// </summary>
        [Mockup(1)]
        public int? collateralSn { get; set; }

        public int CollType { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Opening Branch
        /// Data Type: integer
        /// </summary>
        public int openingUnit { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Collateral Product
        /// Data Type: integer
        /// </summary>
        public int? product { get; set; }

        #endregion Public Properties
    }
}