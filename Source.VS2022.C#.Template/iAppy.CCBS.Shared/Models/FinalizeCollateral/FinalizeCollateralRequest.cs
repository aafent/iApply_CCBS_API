using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class FinalizeCollateralRequest : BaseRequest
    {
        [DataMember]
        public string ApplicationId { get; set; }

        ///// <summary>
        ///// Loan account no.	InGrp[]InGrmAccountCollateral.PrftAccount	Text
        ///// </summary>
        //[DataMember]
        //public string LoanAccountNumber { get; set; }
        ///// <summary>
        /////Reference number	InCollateral.CollateralSn	Numeric
        ///// </summary>
        //[DataMember]
        //public double ReferenceNumber { get; set; }
        ///// <summary>
        /////Account type	InGrp[]InGrmAccountCollateral.ProfitsSystem	Numeric
        ///// </summary>
        //[DataMember]
        //public int AccountType { get; set; }
    }
}
