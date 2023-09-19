using Newtonsoft.Json;

namespace iApplyShared.Models
{
    public class MemberModel
    {
        #region Public Properties

        [JsonProperty("F_DEPT")]
        public string FDept { get; set; }

        [JsonProperty("F_FILENO")]
        public string FFileNo { get; set; }

        [JsonProperty("FIRST_NAME")]
        public string FirstName { get; set; }

        [JsonProperty("F_NEW_NO")]
        public string FNewNo { get; set; }

        [JsonProperty("F_PF_NO")]
        public string FPfNo { get; set; }

        [JsonProperty("SURNAME")]
        public string Surname { get; set; }

        #endregion Public Properties
    }
}