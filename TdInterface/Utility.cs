using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdInterface.Model;
using System.Security.Cryptography;

namespace TdInterface
{
    public class Utility
    {
        private static string TokenFile = "AccessToken.json";
        public static string AuthToken { get; set; }
        private static string _consumerKey = null;

        public static AccessTokenContainer AccessTokenContainer{ get; set; }

        public static UserPrincipal UserPrincipal{ get; set; }

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
    }
}
