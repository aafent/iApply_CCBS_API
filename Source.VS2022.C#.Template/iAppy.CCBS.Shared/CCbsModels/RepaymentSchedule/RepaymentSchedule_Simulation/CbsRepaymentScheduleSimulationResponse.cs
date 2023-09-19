using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsRepaymentScheduleSimulationResponse : CommonResponseModel
    {

        /// <summary>
        /// Seq.: 1
        /// Application Id
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Seq.: 2
        /// Payment Date
        /// </summary>
        public DateTime rs_paydate { get; set; }

        /// <summary>
        /// Seq.: 3
        /// Installment Type
        /// original name is type 
        /// same name different Entity
        /// </summary>
        /// <remarks>
        /// 1 = Yes
        /// </remarks>
        public string Installment_Type { get; set; }

        /// <summary>
        /// Seq.: 4
        /// Monthly Installment
        /// </summary>
        public decimal rs_minstal { get; set; }

        /// <summary>
        /// Seq.: 5
        /// Principal Payment
        /// </summary>
        public decimal rs_payprin { get; set; }

        /// <summary>
        /// Seq.: 6
        /// Normal Interest
        /// </summary>
        public decimal rs_norm_int { get; set; }

        /// <summary>
        /// Seq.: 7
        /// Interest Payment
        /// </summary>
        public decimal rs_intrpay { get; set; }

        /// <summary>
        /// Seq.: 8
        /// Contribution
        /// </summary>
        public decimal rs_contrib { get; set; }

        /// <summary>
        /// Seq.: 9
        /// Spread
        /// </summary>
        public decimal rs_spread { get; set; }

        /// <summary>
        /// Seq.: 10
        /// Residual principal
        /// </summary>
        public decimal rs_resprin { get; set; }

        /// <summary>
        /// Seq.: 11
        /// Insurance
        /// </summary>
        public decimal rs_insurance { get; set; }

        /// <summary>
        /// Seq.: 12
        /// Insurance with Installments
        /// </summary>
        public decimal rs_insurance2 { get; set; }

        /// <summary>
        /// Seq.: 13
        /// Commission
        /// </summary>
        public decimal rs_commision { get; set; }

        /// <summary>
        /// Seq.: 14
        /// Serial Number
        /// </summary>
        public int rs_paysn { get; set; }

        /// <summary>
        /// Seq.: 15
        /// Application Id
        /// Duplicate Value with different Entity
        /// </summary>
        public string la_id_insurance { get; set; }

        /// <summary>
        /// Seq.: 16
        /// Serial Number
        /// </summary>
        public int serial_num { get; set; }

        /// <summary>
        /// Seq.: 17
        /// Insurance Id
        /// </summary>
        public string insurance_id { get; set; }

        /// <summary>
        /// Seq.: 18
        /// Main Beneficiary
        /// </summary>
        public string insurer_mainbf { get; set; }

        /// <summary>
        /// Seq.: 19
        /// Birth Date
        /// </summary>
        public DateTime insurer_birthdate { get; set; }

        /// <summary>
        /// Seq.: 20
        /// Insured Amount
        /// </summary>
        public decimal insured_amnt { get; set; }

        /// <summary>
        /// Seq.: 21
        /// Type
        /// </summary>
        /// <remarks>
        /// 1 = Yes
        /// </remarks>
        public string type { get; set; }

        /// <summary>
        /// Seq.: 22
        /// Type
        /// </summary>
        public string co_relat { get; set; }

        /// <summary>
        /// Seq.: 23
        /// Mediator CBS Id
        /// </summary>
        public string clnum2 { get; set; }

        /// <summary>
        /// Seq.: 24
        /// Mediator Check Digit
        /// </summary>
        public int checkdigit2 { get; set; }

        /// <summary>
        /// Seq.: 25
        /// Deposit Account
        /// </summary>
        public string currentaccount { get; set; }

        /// <summary>
        /// Seq.: 26
        /// Deposit Account Check Digit
        /// </summary>
        public int currentaccount_cd { get; set; }

        /// <summary>
        /// Seq.: 27
        /// Mediator Full Name
        /// </summary>
        public string co_sunam { get; set; }
    }
}

