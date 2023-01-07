using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using TdInterface.Tda.Model;
using TdInterface.Model;

namespace TdInterface
{
    public class Utility
    {
        private static string TokenFile = "AccessToken.json";
        private static string SettingsFile = "Settings.json";
        private static string AccountInfoFile = "AccountInfo.json";

        public static string AuthToken { get; set; }
        private static string _consumerKey = null;

        public static AccessTokenContainer AccessTokenContainer { get; set; }

        public static UserPrincipal UserPrincipal { get; set; }

        public static AccessTokenContainer GetAccessTokenContainer()
        {
            try
            {
                var bytesToDecrypt = File.ReadAllBytes(TokenFile);
                var decrypted = ProtectedData.Unprotect(bytesToDecrypt, GetEntropy(), DataProtectionScope.CurrentUser);

                var accessTokenContainerSTring = UnicodeEncoding.ASCII.GetString(decrypted);
                return JsonConvert.DeserializeObject<AccessTokenContainer>(accessTokenContainerSTring);
            }
            catch
            {
                return null;
            }
        }

        public static void SaveAccessTokenContainer(AccessTokenContainer accessTokenContainer)
        {
            var accessTokenAsString = JsonConvert.SerializeObject(accessTokenContainer);

            var bytesToEncrypt = UnicodeEncoding.ASCII.GetBytes(accessTokenAsString);
            var encrypted = ProtectedData.Protect(bytesToEncrypt, GetEntropy(), DataProtectionScope.CurrentUser);
            File.WriteAllBytes(TokenFile, encrypted);
        }

        public static void SaveSettings(Settings settings)
        {
            var settingsAsString = JsonConvert.SerializeObject(settings);

            File.WriteAllText(SettingsFile, settingsAsString);
        }

        public static Settings GetSettings()
        {
            try
            {
                var settinngsAsString = File.ReadAllText(SettingsFile);
                return JsonConvert.DeserializeObject<Settings>(settinngsAsString);
            }
            catch
            {
                return null;
            }
        }

        public static void SaveAccountInfo(AccountInfo accountInfo)
        {
            var accountInfoAsString = JsonConvert.SerializeObject(accountInfo);

            var bytesToEncrypt = UnicodeEncoding.ASCII.GetBytes(accountInfoAsString);
            var encrypted = ProtectedData.Protect(bytesToEncrypt, null, DataProtectionScope.CurrentUser);
            File.WriteAllBytes(AccountInfoFile, encrypted);
            //var accountInfoAsString = JsonConvert.SerializeObject(accountInfo);

            //File.WriteAllText(AccountInfoFile, accountInfoAsString);
        }

        public static AccountInfo GetAccountInfo()
        {
            try
            {
                var bytesToDecrypt = File.ReadAllBytes(AccountInfoFile);
                var decrypted = ProtectedData.Unprotect(bytesToDecrypt, null, DataProtectionScope.CurrentUser);

                var accountInfoString = UnicodeEncoding.ASCII.GetString(decrypted);
                return JsonConvert.DeserializeObject<AccountInfo>(accountInfoString);
                //var accountInfoAsString = File.ReadAllText(AccountInfoFile);
                //return JsonConvert.DeserializeObject<AccountInfo>(accountInfoAsString);
            }
            catch
            {
                return null;
            }
        }


        public static byte[] GetEntropy()
        {
            return UnicodeEncoding.ASCII.GetBytes(GetConsumerKey());
        }

        public static string GetConsumerKey()
        {
            try
            {
                if (_consumerKey == null)
                {
                    _consumerKey = File.ReadAllText("consumerkey.txt");
                }
            }
            catch (Exception) { }  //Eat exception and return null;
            return _consumerKey;
        }

        public static void SaveConsumerKey(string key)
        {
            File.WriteAllText("consumerkey.txt", key);
        }

        public static void ClearAccessTokenContainerFile()
        {
            File.Delete(TokenFile);
        }


        public static T DeserializeJsonFromStream<T>(Stream stream)
        {
            if (stream == null || stream.CanRead == false)
                return default(T);

            using (var sr = new StreamReader(stream))
            using (var jtr = new JsonTextReader(sr))
            {
                var js = new JsonSerializer();
                var searchResult = js.Deserialize<T>(jtr);
                return searchResult;
            }

        }

    }
}
