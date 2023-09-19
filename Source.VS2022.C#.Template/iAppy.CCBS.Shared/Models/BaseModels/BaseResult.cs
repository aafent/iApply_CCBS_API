using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    public class BaseResult
    {
        [JsonProperty("has_error")]
        public bool HasError { get; set; }

        [JsonProperty("api_code")]
        public string ApiCode { get; set; }

        [JsonProperty("api_code_description")]
        public string ApiCodeDescription { get; set; }

        [JsonProperty("trx_id")]
        public Guid TrxId { get; set; }

        [JsonProperty("identity_type")]
        public string IdentityType { get; set; }

        [JsonProperty("identity_number")]
        public string IdentityNumber { get; set; }
    }
}
