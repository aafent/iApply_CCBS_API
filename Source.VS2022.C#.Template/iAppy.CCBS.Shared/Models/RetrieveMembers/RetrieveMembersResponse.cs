using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    public class RetrieveMembersResponse : BaseResponse
    {
        [DataMember]
        public string MemberId { get; set; }

        [DataMember]
        public string StatusDesc { get; set; }

        [DataMember]
        public DateTime? CreationDate { get; set; }

        [DataMember]
        public DateTime? DeletionDate { get; set; }

        [DataMember]
        public string StatusCode { get; set; }

        [DataMember]
        public decimal? CapitalAmt { get; set; }

        [DataMember]
        public decimal? FuneralFee { get; set; }

        [DataMember]
        public decimal? InsuranceFee { get; set; }

        [DataMember]
        public decimal? SharesValue { get; set; }

        [DataMember]
        public double AvailableShares { get; set; }

        [DataMember]
        public decimal? SAYEAmt { get; set; }

        [DataMember]
        public string SubStatus { get; set; }

        [DataMember]
        public decimal? ProrataAmount { get; set; }

        [DataMember]
        public string BusinessRegistry { get; set; }
    }
}
