using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TdInterface.Tda.Model;

namespace TdInterface.TradeStation
{
    internal class TradeStationHelper
    {
        public static HttpClient _httpClient = new HttpClient();
        public static Uri BaseUri = new Uri("https://api.tdameritrade.com");
        public static Uri TokenUri = new Uri("https://signin.tradestation.com/oauth/token");

        public const string routeGetToken = "v1/oauth2/token";

        public async Task<AccessTokenContainer> GetAccessToken(string authToken, string clientId, string clientSecret)
        {
            List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("grant_type", "authorization_code"));
            postData.Add(new KeyValuePair<string, string>("access_type", "offline"));
            postData.Add(new KeyValuePair<string, string>("code", $"{authToken}"));
            postData.Add(new KeyValuePair<string, string>("client_id", clientId));
            postData.Add(new KeyValuePair<string, string>("client_secret", clientSecret));
            postData.Add(new KeyValuePair<string, string>("redirect_uri", "http://localhost"));

            FormUrlEncodedContent content = new FormUrlEncodedContent(postData);
            var rawSTring = await content.ReadAsStringAsync();
            var request = new HttpRequestMessage(HttpMethod.Post, TokenUri) 
            {
                Method = HttpMethod.Post,
                Content = content
            };

            var response = await _httpClient.SendAsync(request);

            var accessTokenContainer = Utility.DeserializeJsonFromStream<AccessTokenContainer>(await response.Content.ReadAsStreamAsync());

            return accessTokenContainer;
        }

        public async Task<AccessTokenContainer> RefreshAccessToken(AccessTokenContainer accessTokenContainer, string clientId, string clientSecret)
        {
            try
            {
                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("grant_type", "refresh_token"));
                postData.Add(new KeyValuePair<string, string>("client_id", clientId));
                postData.Add(new KeyValuePair<string, string>("client_secret", clientSecret));
                postData.Add(new KeyValuePair<string, string>("refresh_token", System.Net.WebUtility.UrlEncode( accessTokenContainer.RefreshToken)));

                FormUrlEncodedContent content = new FormUrlEncodedContent(postData);
                var rawSTring = await content.ReadAsStringAsync();
                var request = new HttpRequestMessage(HttpMethod.Post, new Uri(BaseUri, routeGetToken)) //Uri."https://api.tdameritrade.com/v1/oauth2/token"); // ; 
                {
                    Method = HttpMethod.Post,
                    Content = content
                };

                var response = await _httpClient.SendAsync(request).ConfigureAwait(false);

                var newAccessTokenContainer = Utility.DeserializeJsonFromStream<AccessTokenContainer>(await response.Content.ReadAsStreamAsync());
                //Add the refresh token back as it doesn't come back with the payload.
                newAccessTokenContainer.RefreshToken = accessTokenContainer.RefreshToken;

                return newAccessTokenContainer;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }



    }
}
