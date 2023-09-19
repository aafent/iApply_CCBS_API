using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DynamicCollateral
    {
        [DataMember]
        virtual public double INTERNAL_SN { get; set; }

        [DataMember]
        virtual public string RECORD_TYPE { get; set; }

        [DataMember]
        virtual public string RECORD_DESCR { get; set; }

        [DataMember]
        virtual public decimal? AMOUNT_2 { get; set; }

        [DataMember]
        virtual public string DESCR_1 { get; set; }

        [DataMember]
        virtual public string ENTRY_STATUS { get; set; }

        [DataMember]
        virtual public string PROFITS_ACCOUNT_2 { get; set; }

        [DataMember]
        virtual public short? ACCOUNT_CD_2 { get; set; }

        [DataMember]
        virtual public decimal? AMOUNT_1 { get; set; }

        [DataMember]
        virtual public short? PRFT_SYSTEM_2 { get; set; }

        [DataMember]
        virtual public string TAG_SET_CODE { get; set; }

        [DataMember]
        virtual public string DESCRIPTION { get; set; }
    }
}
