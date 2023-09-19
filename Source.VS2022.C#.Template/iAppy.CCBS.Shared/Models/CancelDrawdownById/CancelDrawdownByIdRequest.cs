using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{

    public class CancelDrawdownByIdRequest : BaseRequest
    {
        [DataMember]
        public string ApplicationId { get; set; }

        [DataMember]
        public string DrawDownId { get; set; }

        [DataMember]
        public string DrawDownStatus { get; set; }


        [DataMember]
        public DateTime? DrawDownDate { get; set; }

        [DataMember]
        public string Branch { get; set; }

        [DataMember]
        public string Ccy { get; set; }

        [DataMember]
        public string Account { get; set; }

        [DataMember]
        public int? AccountCd { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }
    }
}
