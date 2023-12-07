namespace iApplyShared.CbsModels
{
    public class PropertyCollateral
    {
        #region Public Properties

        /// <summary>
        /// Forced Sale Currency
        /// Data Type: varchar (10)
        /// Entities: cr_lacola
        /// </summary>
        public string co_forceccy { get; set; }

        /// <summary>
        /// Forced Sale Value
        /// Data Type: decimal (19,3)
        /// Entities: cr_lacola
        /// </summary>
        public decimal co_forceval { get; set; }

        /// <summary>
        /// Property Id
        /// Data Type: varchar (30)
        /// Entities: cr_lacola
        /// </summary>
        public string co_id { get; set; }

        /// <summary>
        /// Insurance Value Currency
        /// Data Type: varchar (10)
        /// Entities: cr_lacola
        /// </summary>
        public string co_insccy { get; set; }

        /// <summary>
        /// Insurance Value
        /// Data Type: decimal (19,3)
        /// Entities: cr_lacola
        /// </summary>
        public decimal co_insval { get; set; }

        /// <summary>
        /// Investment Value Currency
        /// Data Type: varchar (10)
        /// Entities: cr_lacola
        /// </summary>
        public string co_investccy { get; set; }

        /// <summary>
        /// Investment Value
        /// Data Type: decimal (19,3)
        /// Entities: cr_lacola
        /// </summary>
        public decimal co_investval { get; set; }

        /// <summary>
        /// Open Market Currency
        /// Data Type: varchar (10)
        /// Entities: cr_lacola
        /// </summary>
        public string co_markccy { get; set; }

        /// <summary>
        /// Open Market Value
        /// Data Type: decimal (19,3)
        /// Entities: cr_lacola
        /// </summary>
        public decimal co_markval { get; set; }

        /// <summary>
        /// Mortgage Value Currency
        /// Data Type: varchar (10)
        /// Entities: cr_lacola
        /// </summary>
        public string co_mortccy { get; set; }

        /// <summary>
        /// Mortgage Value
        /// Data Type: decimal (19,3)
        /// Entities: cr_lacola
        /// </summary>
        public decimal co_mortval { get; set; }

        /// <summary>
        /// Reserve Value Currency
        /// Data Type: varchar (10)
        /// Entities: cr_lacola
        /// </summary>
        public string co_reserccy { get; set; }

        /// <summary>
        /// Reserve Value
        /// Data Type: decimal (19,3)
        /// Entities: cr_lacola
        /// </summary>
        public decimal co_reserval { get; set; }

        /// <summary>
        /// Valuation Date
        /// Data Type: datetime
        /// Entities: cr_lacola
        /// </summary>
        public DateTime co_revdate { get; set; }

        /// <summary>
        /// Market Value
        /// Data Type: decimal (19,3)
        /// Entities: cr_lacola
        /// </summary>
        public decimal co_sum { get; set; }

        /// <summary>
        /// Collateral Type
        /// Data Type: varchar (10)
        /// Entities: cr_lacola
        /// </summary>
        public string co_type { get; set; }

        /// <summary>
        /// Valuer
        /// Data Type: varchar (15)
        /// Entities: cr_lacola
        /// </summary>
        public string co_valuer { get; set; }

        /// <summary>
        /// Valuer Type
        /// Data Type: varchar (15)
        /// Entities: cr_lacola
        /// </summary>
        public string co_valuetype { get; set; }

        /// <summary>
        /// LR Number
        /// Data Type: varchar (150)
        /// Entities: cr_lacola
        /// </summary>
        public string ip_lrnum { get; set; }

        #endregion Public Properties
    }
}