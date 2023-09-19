using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    public class DownloadRepInstallmentResponse : BaseResponse
    {
        [DataMember]
        public decimal InstallmentAmount { get; set; }
        [DataMember]
        public decimal CapitalAmount { get; set; }
        [DataMember]
        public decimal FirstInstallmentAmount { get; set; }
        [DataMember]
        public int RemainingInstallments { get; set; }
        [DataMember]
        public int LoanDuration { get; set; }
        [DataMember]
        public decimal RemainingInterests { get; set; }
        [DataMember]
        public int Product { get; set; }
    }
}
