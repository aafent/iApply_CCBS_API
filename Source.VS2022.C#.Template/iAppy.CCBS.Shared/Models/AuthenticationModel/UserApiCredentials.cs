using Newtonsoft.Json;

namespace iApplyShared.Models
{
    public class UserApiCredentials
    {
        #region Public Properties

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        #endregion Public Properties
    }
}