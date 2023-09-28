using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsDownloadDebtResponse : CommonResponseModel
    {
        /// <summary>
        /// Overdue Balance
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_ln_ovd_bal { get; set; }

        /// <summary>
        /// Arrears Classification
        /// Data Type: varchar (15)
        /// Entities: cr_cucoba_det
        /// </summary>
        public string cb_arrclass { get; set; }

        /// <summary>
        /// Currency
        /// Data Type: varchar (10)
        /// Entities: cr_cucoba_det
        /// </summary>
        public string cb_ccy { get; set; }

        /// <summary>
        /// Disbursement Date
        /// Data Type: datetime
        /// Entities: cr_cucoba_det
        /// </summary>
        public DateTime cb_disdate { get; set; }

        /// <summary>
        /// Book Value
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_bookval { get; set; }

        /// <summary>
        /// Monthly Due
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_mondue { get; set; }

        /// <summary>
        /// Frequency
        /// Data Type: integer
        /// Entities: cr_cucoba_det
        /// </summary>
        public int cb_freq { get; set; }

        /// <summary>
        /// Loan duration
        /// Data Type: integer
        /// Entities: cr_cucoba_det
        /// </summary>
        public int cb_term { get; set; }

        /// <summary>
        /// Last payment
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_lastpay { get; set; }

        /// <summary>
        /// Last payment made on
        /// Data Type: datetime
        /// Entities: cr_cucoba_det
        /// </summary>
        public DateTime cb_lastpaydate { get; set; }

        /// <summary>
        /// Overdue Installments
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_overinst { get; set; }


        /// <summary>
        /// Overdue Days
        /// Data Type: integer
        /// Entities: cr_cucoba_det
        /// </summary>
        public int cb_days { get; set; }

        /// <summary>
        /// Total Installments
        /// Data Type: integer
        /// Entities: cr_cucoba_det
        /// </summary>
        public int cb_totinst { get; set; }

        /// <summary>
        /// Remaining Amount
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_totremain { get; set; }

        /// <summary>
        /// Specific provision
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_lesspeprov { get; set; }

        /// <summary>
        /// Suspended interest
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_lessusint { get; set; }

        /// <summary>
        /// Net Debt
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_sumnetdebt { get; set; }

        /// <summary>
        /// Amount Disbursed
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_disamnt { get; set; }

        /// <summary>
        /// Payments Received to date
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_payrec { get; set; }

        /// <summary>
        /// Normal Balance
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_ln_nrm_bal { get; set; }

        /// <summary>
        /// Total Provision
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_netdebt { get; set; }

        /// <summary>
        /// Suspended interest
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_lesunint { get; set; }


        /// <summary>
        /// Interest rate on Capital
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_intrate { get; set; }

        /// <summary>
        /// Arrears rate
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_arrates { get; set; }

        /// <summary>
        /// Loan duration left
        /// Data Type: integer
        /// Entities: cr_cucoba_det
        /// </summary>
        public int cb_termleft { get; set; }

        /// <summary>
        /// Branch
        /// Data Type: varchar (10)
        /// Entities: cr_cucoba_det
        /// </summary>
        public string cb_branch { get; set; }

        /// <summary>
        /// Product
        /// Data Type: varchar (10)
        /// Entities: cr_cucoba_det
        /// </summary>
        public string cb_produ { get; set; }

        /// <summary>
        /// Customer Category
        /// Data Type: varchar (10)
        /// Entities: cr_cucoba_det
        /// </summary>
        public string cb_custcat { get; set; }

        /// <summary>
        /// Book Balance
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_ln_accbal { get; set; }

        /// <summary>
        /// Customer Total Balance
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucoba_det
        /// </summary>
        public decimal cb_totcusbal { get; set; }

        /// <summary>
        /// Property CBS Id
        /// Data Type: integer
        /// Entities: cr_curees_other
        /// </summary>
        public int cbsid { get; set; }

        /// <summary>
        /// Property Type
        /// Data Type: varchar (10)
        /// Entities: cr_curees_other
        /// </summary>
        public string CollateralType { get; set; }

        /// <summary>
        /// Market Value
        /// Data Type: decimal (19,3)
        /// Entities: cr_lacola
        /// </summary>
        public decimal co_sum { get; set; }

        /// <summary>
        /// Security Value
        /// Data Type: decimal (19,3)
        /// Entities: cr_lacola
        /// </summary>
        public decimal co_secval { get; set; }

        /// <summary>
        /// Open Market Value
        /// Data Type: decimal (19,3)
        /// Entities: cr_lacola
        /// </summary>
        public decimal co_markval { get; set; }

        /// <summary>
        /// Property Id
        /// Data Type: varchar (30)
        /// Entities: cr_lacola
        /// </summary>
        public string co_id { get; set; }

        /// <summary>
        /// Collateral Type
        /// Data Type: varchar (10)
        /// Entities: cr_lacola
        /// </summary>
        public string co_type { get; set; }

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
        /// Open Market Currency
        /// Data Type: varchar (10)
        /// Entities: cr_lacola
        /// </summary>
        public string co_markccy { get; set; }

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
        /// LR Number
        /// Data Type: varchar (150)
        /// Entities: cr_lacola
        /// </summary>
        public string ip_lrnum { get; set; }
        

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
        /// Valuation Date
        /// Data Type: datetime
        /// Entities: cr_lacola
        /// </summary>
        public DateTime co_revdate { get; set; }

        public List<OtherCollateral> OtherCollateralList { get; set; }

        public List<PropertyCollateral> PropertyCollateralList { get; set; }
    }
}
