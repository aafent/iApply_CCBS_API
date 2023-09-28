using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class RepaymentScheduleInsuranceData
    {
        public DateTime? BirthDate { get; set; }
        public string MainBeneficiaryFlag { get; set; }
        public int? InsuranceCode { get; set; }
        public decimal? InsuredAmount { get; set; }

    }
}
