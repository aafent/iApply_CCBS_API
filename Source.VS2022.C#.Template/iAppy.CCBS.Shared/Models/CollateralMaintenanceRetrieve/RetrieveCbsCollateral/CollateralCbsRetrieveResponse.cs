using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CollateralCbsRetrieveResponse : BaseResponse
    {
        [DataMember]
        public string ApplicationId { get; set; }

        [DataMember]
        public string CollateralId { get; set; }

        [DataMember]
        public string CollBasil { get; set; }

        [DataMember]
        public decimal? CollSecAmount { get; set; }

        [DataMember]
        public string CollCode { get; set; }

        [DataMember]
        public string CollComments { get; set; }

        [DataMember]
        public string CollStatus { get; set; }

        [DataMember]
        public int? CustomerId { get; set; }

        [DataMember]
        public decimal? CollCovAmount { get; set; }

        [DataMember]
        public decimal? CollEstAmount { get; set; }

        [DataMember]
        public DateTime? CollRevDate { get; set; }

        [DataMember]
        public int? CollNoItems { get; set; }

        [DataMember]
        public string CollReCcy { get; set; }

        [DataMember]
        public DateTime? CollNextRevDate { get; set; }

        [DataMember]
        public decimal? CollLimit { get; set; }

        [DataMember]
        public decimal? CollPerc { get; set; }

        [DataMember]
        public string CollCcy { get; set; }

        [DataMember]
        public string CollCcyD { get; set; }

        [DataMember]
        public string CollOfficer { get; set; }


        [DataMember]
        public string MonUnit { get; set; }


        [DataMember]
        public string CollRegid { get; set; }

        [DataMember]
        public string CollLandReg { get; set; }

        [DataMember]
        public decimal? CollExpenses { get; set; }

        [DataMember]
        public decimal? CollReEstVal { get; set; }

        [DataMember]
        public decimal? CollReOrig { get; set; }

        [DataMember]
        public decimal? CollReCur { get; set; }

        [DataMember] 
        public List<CollateralCbsDetailItem> CollateralCbsDetailItems { get; set; }


    }
}
