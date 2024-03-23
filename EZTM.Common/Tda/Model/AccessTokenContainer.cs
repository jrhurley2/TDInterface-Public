using Newtonsoft.Json;

namespace EZTM.Common.Tda.Model
{

    public class AccessTokenContainer
    {
        public enum EnumTokenSystem { TDA, TradeStation }

        private DateTime _tokenExpiration;
        private DateTime _refreshExpiration;

        public EnumTokenSystem TokenSystem { get; set; }

        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn
        {
            get => (int)(_tokenExpiration - DateTime.UtcNow).TotalSeconds;
            set => _tokenExpiration = DateTime.UtcNow.AddSeconds(value);
        }

        [JsonProperty(PropertyName = "refresh_token_expires_in")]
        public int RefreshTokenExpiresIn
        {
            get => (int)(_refreshExpiration - DateTime.UtcNow).TotalSeconds;
            set => _refreshExpiration = DateTime.UtcNow.AddSeconds(value);
        }

        public bool IsTokenExpired => _tokenExpiration <= DateTime.UtcNow;

        public bool IsRefreshTokenExpired => _refreshExpiration <= DateTime.UtcNow;
        public int RefreshTokenExpiresInDays
        {
            get
            {
                return (_refreshExpiration - DateTime.UtcNow).Days;
            }
        }
    }
}
