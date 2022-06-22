using Newtonsoft.Json;
using System;

namespace TdInterface.Model
{

    public class AccessTokenContainer
    {
        private DateTime _tokenExpiration;
        private DateTime _refreshExpiration;

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
            get => (int)(this._tokenExpiration - DateTime.UtcNow).TotalSeconds;
            set => this._tokenExpiration = DateTime.UtcNow.AddSeconds((double)value);
        }

        [JsonProperty(PropertyName = "refresh_token_expires_in")]
        public int RefreshTokenExpiresIn
        {
            get => (int)(this._refreshExpiration - DateTime.UtcNow).TotalSeconds;
            set => this._refreshExpiration = DateTime.UtcNow.AddSeconds((double)value);
        }

        public bool IsTokenExpired => this._tokenExpiration <= DateTime.UtcNow;

        public bool IsRefreshTokenExpired => this._refreshExpiration <= DateTime.UtcNow;
        public int RefreshTokenExpiresInDays
        {
            get
            {
                return (this._refreshExpiration - DateTime.UtcNow).Days;
            }
        }
    }
}
