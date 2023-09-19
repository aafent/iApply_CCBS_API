using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models.CollateralGeneral.Common
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GeneralCollateralListItem
    {
        [DataMember]
        public double CollateralId { get; set; }

        [DataMember]
        public string CollateralDescr { get; set; }

        [DataMember]
        public string CollateralDesc1 { get; set; }

        [DataMember]
        public string CollateralDesc2 { get; set; }

        [DataMember]
        public string CollateralDesc3 { get; set; }

        [DataMember]
        public string CollateralStatus { get; set; }

        [DataMember]
        public decimal? CollateralAmount { get; set; }
    }
}
