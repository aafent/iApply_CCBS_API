namespace CCBS.Models
{
    public class CbsScenarioInstallment
    {
        #region Public Properties

        /// <summary>
        /// Application Id (varchar (15))
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Commission (decimal (19,3))
        /// </summary>
        public decimal rs_commision { get; set; }

        /// <summary>
        /// Contribution (decimal (19,3))
        /// </summary>
        public decimal rs_contrib { get; set; }

        /// <summary>
        /// Insurance (decimal (19,3))
        /// </summary>
        public decimal rs_insurance { get; set; }

        /// <summary>
        /// Insurance with Installments (decimal (19,3))
        /// </summary>
        public decimal rs_insurance2 { get; set; }

        /// <summary>
        /// Interest Payment (decimal (19,3))
        /// </summary>
        public decimal rs_intrpay { get; set; }

        /// <summary>
        /// Monthly Installment (decimal (19,3))
        /// </summary>
        public decimal rs_minstal { get; set; }

        /// <summary>
        /// Normal Interest (decimal (19,3))
        /// </summary>
        public decimal rs_norm_int { get; set; }

        /// <summary>
        /// Payment Date (datetime)
        /// </summary>
        public DateTime rs_paydate { get; set; }

        /// <summary>
        /// Principal Payment (decimal (19,3))
        /// </summary>
        public decimal rs_payprin { get; set; }

        /// <summary>
        /// Serial Number (integer)
        /// </summary>
        public int rs_paysn { get; set; }

        /// <summary>
        /// Residual principal (decimal (19,3))
        /// </summary>
        public decimal rs_resprin { get; set; }

        /// <summary>
        /// Spread (decimal (19,3))
        /// </summary>
        public decimal rs_spread { get; set; }

        /// <summary>
        /// Installment Type (varchar (15))
        /// 1
        /// </summary>
        public string type { get; set; }

        #endregion Public Properties
    }

    public class CbsScheduleInstallment
    {
        #region Public Properties

        /// <summary>
        /// Seq. 22
        /// Description: Customer Id
        /// Entities: cr_laresc_save
        /// </summary>
        public string cu_id { get; set; }

        /// <summary>
        /// Seq. 1
        /// Description: Application Id
        /// Entities: cr_laresc
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Seq. 21
        /// Description: Application Id
        /// Entities: cr_laresc_save
        /// its the same property with Application id but different Entity so i added
        /// the entity name in the property so to not have the same name
        /// </summary>
        public string la_id_laresc { get; set; }

        /// <summary>
        /// Seq. 11
        /// Description: Commission
        /// Entities: cr_laresc
        /// </summary>
        public decimal rs_commision { get; set; }

        /// <summary>
        /// Seq. 8
        /// Description: Contribution
        /// Entities: cr_laresc
        /// </summary>
        public decimal rs_contrib { get; set; }

        /// <summary>
        /// Seq. 13
        /// Description: Cost of option
        /// Entities: cr_laresc
        /// </summary>
        public decimal rs_cost_opt { get; set; }

        /// <summary>
        /// Seq. 12
        /// Description: Expense
        /// Entities: cr_laresc
        /// </summary>
        public decimal rs_expense { get; set; }

        /// <summary>
        /// Seq. 14
        /// Description: Insurance
        /// Entities: cr_laresc
        /// </summary>
        public decimal rs_insurance { get; set; }

        /// <summary>
        /// Seq. 5
        /// Description: Interest Payment
        /// Entities: cr_laresc
        /// </summary>
        public decimal rs_intrpay { get; set; }

        /// <summary>
        /// Seq. 16
        /// Description: Last Payment Date
        /// Entities: cr_laresc
        /// </summary>
        public DateTime rs_lst_paydt { get; set; }

        /// <summary>
        /// Seq. 6
        /// Description: Monthly Installment
        /// Entities: cr_laresc
        /// </summary>
        public decimal rs_minstal { get; set; }

        /// <summary>
        /// Seq. 7
        /// Description: Normal Interest
        /// Entities: cr_laresc
        /// </summary>
        public decimal rs_norm_int { get; set; }

        /// <summary>
        /// Seq. 17
        /// Description: Overdue Days
        /// Entities: cr_laresc
        /// </summary>
        public int rs_ovd_days { get; set; }

        /// <summary>
        /// Seq. 2
        /// Description: Payment Date
        /// Entities: cr_laresc
        /// </summary>
        public DateTime rs_paydate { get; set; }

        /// <summary>
        /// Seq. 4
        /// Description: Principal Payment
        /// Entities: cr_laresc
        /// </summary>
        public decimal rs_payprin { get; set; }

        /// <summary>
        /// Seq. 20
        /// Description: Serial Number
        /// Entities: cr_laresc
        /// </summary>
        public int rs_paysn { get; set; }

        /// <summary>
        /// Seq. 3
        /// Description: Residual principal
        /// Entities: cr_laresc
        /// </summary>
        public decimal rs_resprin { get; set; }

        /// <summary>
        /// Seq. 18
        /// Description: Request Balance
        /// Entities: cr_laresc
        /// </summary>
        public decimal rs_rq_balance { get; set; }

        /// <summary>
        /// Seq. 15
        /// Description: Request Status
        /// Entities: cr_laresc
        /// Notes: If result = '1' then UNPAID\nIf result = '2' then PAID\nIf result = '3' then P.PAID\nelse FUTURE
        /// </summary>
        public string rs_rq_status { get; set; }

        /// <summary>
        /// Seq. 9
        /// Description: Spread
        /// Entities: cr_laresc
        /// </summary>
        public decimal rs_spread { get; set; }

        /// <summary>
        /// Seq. 10
        /// Description: Subsidy
        /// Entities: cr_laresc
        /// </summary>
        public decimal rs_subsidy { get; set; }

        /// <summary>
        /// Seq. 23
        /// Description: Serial Number
        /// Entities: cr_laresc_save
        /// Notes: 900
        /// </summary>
        public int serial_num { get; set; }

        /// <summary>
        /// Seq. 19
        /// Description: Installment Type
        /// Entities: cr_laresc
        /// </summary>
        public string type { get; set; }

        #endregion Public Properties
    }
}