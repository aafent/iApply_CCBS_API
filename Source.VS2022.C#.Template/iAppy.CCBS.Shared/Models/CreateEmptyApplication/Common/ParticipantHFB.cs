using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class ParticipantHFB
    {
        [DataMember(IsRequired = true)]
        public string CrmId { get; set; }

        [DataMember(IsRequired = true)]
        public string CBSID { get; set; }

        [DataMember(IsRequired = true)]
        public int CheckDigit { get; set; }

        [DataMember(IsRequired = true)]
        public string ParticipantType { get; set; }
    }

}