using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{

    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveCollateralGeneralResponse : BaseResponse
    {
        [DataMember]
        public string PropertyId { get; set; }

        [DataMember]
        public int PropertyCBSId { get; set; }

        [DataMember]
        public int AccountCd { get; set; }

        [DataMember]
        public string PropertyCustomerCBSId { get; set; }

        [DataMember]
        public int PropertyCustomerCBSCd { get; set; }

        [DataMember]
        public int? PropertyYear { get; set; }

        [DataMember]
        public int? PropertyCountry { get; set; }

        [DataMember]
        public string PropertyDesc1 { get; set; }

        [DataMember]
        public string PropertyDesc2 { get; set; }

        [DataMember]
        public string PropertyDesc3 { get; set; }

        [DataMember]
        public string PropertyDesc4 { get; set; }

        [DataMember]
        public string PropertyDesc5 { get; set; }

        [DataMember]
        public string PropertyDesc6 { get; set; }

        [DataMember]
        public string PropertyDesc7 { get; set; }

        [DataMember]
        public string PropertyDesc8 { get; set; }

        [DataMember]
        public string PropertyDesc9 { get; set; }

        [DataMember]
        public string PropertyDesc10 { get; set; }

        [DataMember]
        public string PropertyDesc11 { get; set; }

        [DataMember]
        public string PropertyDesc12 { get; set; }

        [DataMember]
        public string PropertyDesc13 { get; set; }

        [DataMember]
        public string PropertyDesc14 { get; set; }

        [DataMember]
        public string PropertyDesc15 { get; set; }

        [DataMember]
        public string PropertyDesc16 { get; set; }

        [DataMember]
        public string PropertyDesc17 { get; set; }

        [DataMember]
        public string PropertyDesc18 { get; set; }

        [DataMember]
        public string PropertyDesc19 { get; set; }

        [DataMember]
        public string PropertyDesc20 { get; set; }

        [DataMember]
        public string PropertyDesc21 { get; set; }

        [DataMember]
        public string PropertyDesc22 { get; set; }

        [DataMember]
        public string PropertyDesc23 { get; set; }

        [DataMember]
        public string PropertyDesc24 { get; set; }

        [DataMember]
        public string PropertyDesc25 { get; set; }

        [DataMember]
        public string PropertyDesc26 { get; set; }

        [DataMember]
        public string PropertyDesc27 { get; set; }

        [DataMember]
        public string PropertyDesc28 { get; set; }

        [DataMember]
        public DateTime? PropertyDate1 { get; set; }

        [DataMember]
        public DateTime? PropertyDate2 { get; set; }

        [DataMember]
        public DateTime? PropertyDate3 { get; set; }

        [DataMember]
        public DateTime? PropertyDate4 { get; set; }

        [DataMember]
        public DateTime? PropertyDate5 { get; set; }

        [DataMember]
        public DateTime? PropertyDate6 { get; set; }

        [DataMember]
        public DateTime? PropertyDate7 { get; set; }

        [DataMember]
        public DateTime? PropertyDate8 { get; set; }

        [DataMember]
        public DateTime? PropertyDate9 { get; set; }

        [DataMember]
        public decimal? Amount1 { get; set; }

        [DataMember]
        public int? PropertyCcy { get; set; }

        [DataMember]
        public string PropertyCCyD { get; set; }

        [DataMember]
        public int? Number1 { get; set; }

        [DataMember]
        public decimal? Number2 { get; set; }

        [DataMember]
        public decimal? Amount2 { get; set; }

        [DataMember]
        public int? PropertyCcy2 { get; set; }

        [DataMember]
        public string PropertyCCyD2 { get; set; }

        [DataMember]
        public decimal? Amount3 { get; set; }

        [DataMember]
        public int? PropertyCcy3 { get; set; }

        [DataMember]
        public string PropertyCCyD3 { get; set; }

        [DataMember]
        public decimal? Amount4 { get; set; }

        [DataMember]
        public int? PropertyCcy4 { get; set; }

        [DataMember]
        public string PropertyCCyD4 { get; set; }

        [DataMember]
        public decimal? Amount5 { get; set; }

        [DataMember]
        public decimal? Amount6 { get; set; }

        [DataMember]
        public decimal? Amount7 { get; set; }

        [DataMember]
        public string PropertyLDesc1 { get; set; }
        [DataMember]
        public string PropertyLDesc2 { get; set; }

        [DataMember]
        public DateTime? PropertyInsurDate1 { get; set; }

        [DataMember]
        public int? PropertyInsurDesc1 { get; set; }

        [DataMember]
        public decimal? PropertyInsurAmt1 { get; set; }

        [DataMember]
        public int? PropertyInsurAmt1Ccy { get; set; }

        [DataMember]
        public string PropertyInsurAmt1CcyD { get; set; }

        [DataMember]
        public decimal? PropertyInsurAmt2 { get; set; }

        [DataMember]
        public int? PropertyInsurAmt2Ccy { get; set; }

        [DataMember]
        public string PropertyInsurAmt2CcyD { get; set; }

        [DataMember]
        public DateTime? PropertyInsurDate2 { get; set; }

        [DataMember]
        public int? PropertyValBankEmployee { get; set; }

        [DataMember]
        public DateTime? PropertyValDate1 { get; set; }

        [DataMember]
        public decimal? PropertyValAmt1 { get; set; }

        [DataMember]
        public int? PropertyValAmt1Ccy { get; set; }

        [DataMember]
        public string PropertyValAmt1CcyD { get; set; }

        [DataMember]
        public decimal? PropertyValAmt2 { get; set; }

        [DataMember]
        public int? PropertyValAmt2Ccy { get; set; }

        [DataMember]
        public string PropertyValAmt2CcyD { get; set; }

        [DataMember]
        public decimal? PropertyRate { get; set; }

        [DataMember]
        public string PropertyCbsStatus { get; set; }
    }


}
