using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DownloadRepScenarioRequest : BaseRequest
    {
        [DataMember(IsRequired = true)]
        public string ApplicationId { get; set; }

        [DataMember(IsRequired = true)]
        public int CustomerCBSId { get; set; }

        [DataMember(IsRequired = true)]
        public short CustomerCBSCd { get; set; }
    }
}
