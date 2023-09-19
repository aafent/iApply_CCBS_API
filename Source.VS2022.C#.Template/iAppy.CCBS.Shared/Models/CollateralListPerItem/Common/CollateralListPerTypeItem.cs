using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models.RetrieveCollateralListPerItem.Common
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CollateralListPerTypeItem
    {
        [DataMember]
        public double? SN { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Usage { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public double UsedCollatSn { get; set; }

        [DataMember]
        public int UsedUnit { get; set; }

        [DataMember]
        public int UsedCollatType { get; set; }

    }
}
