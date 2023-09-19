using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CollateralCbsDetailItem
    {
        [DataMember]
        public string CollAccountCd { get; set; }

        [DataMember]
        public decimal? CollSecAmount { get; set; }

        [DataMember]
        public decimal? CollEstAmount { get; set; }

        [DataMember]
        public decimal? CollCovAmount { get; set; }

        [DataMember]
        public DateTime? CollExpDate { get; set; }

        [DataMember]
        public int? CollNoItems { get; set; }

        [DataMember]
        public string CollAccount { get; set; }


        [DataMember]
        public string CollReCcy { get; set; }


        [DataMember]
        public decimal? CollLimit { get; set; }

        [DataMember]
        public decimal? CollPerc { get; set; }

        [DataMember]
        public int? CollateralTrCbsId { get; set; }

        [DataMember]
        public string CollateralStatus { get; set; }

        [DataMember]
        public int? CollAccountType { get; set; }

        [DataMember]
        public string CollRefNum { get; set; }

        [DataMember]
        public decimal? CollRevValue { get; set; }

        [DataMember]
        public string CollClass { get; set; }

        [DataMember]
        public DateTime? CollReDate { get; set; }

        [DataMember]
        public decimal? CollReAmount { get; set; }

        [DataMember]
        public decimal? CollReOrig { get; set; }

        [DataMember]
        public decimal? CollReCur { get; set; }


    }
}
