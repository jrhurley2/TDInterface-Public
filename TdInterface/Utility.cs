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
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Net;
using TdInterface.Properties;

namespace TdInterface
{
    public class Utility
    {
        private static string SettingsFile = "Settings.json";
        private static string AccountInfoFile = "AccountInfo.json";

        public static string AuthToken { get; set; }

        public static AccessTokenContainer AccessTokenContainer { get; set; }

        public static UserPrincipal UserPrincipal { get; set; }

        public static AccessTokenContainer GetAccessTokenContainer(string tokenFile)
        {
            try
            {
                var bytesToDecrypt = File.ReadAllBytes(tokenFile);
                var decrypted = ProtectedData.Unprotect(bytesToDecrypt, GetEntropy(), DataProtectionScope.CurrentUser);

                var accessTokenContainerSTring = UnicodeEncoding.ASCII.GetString(decrypted);
                return JsonConvert.DeserializeObject<AccessTokenContainer>(accessTokenContainerSTring);
            }
            catch
            {
                return null;
            }
        }

        public static void SaveAccessTokenContainer(string tokenFileName , AccessTokenContainer accessTokenContainer)
        {
            var accessTokenAsString = JsonConvert.SerializeObject(accessTokenContainer);

            var bytesToEncrypt = UnicodeEncoding.ASCII.GetBytes(accessTokenAsString);
            var encrypted = ProtectedData.Protect(bytesToEncrypt, GetEntropy(), DataProtectionScope.CurrentUser);
            File.WriteAllBytes(tokenFileName, encrypted);
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
        }

        public virtual AccountInfo GetAccountInfo()
        {
            try
            {
                var bytesToDecrypt = File.ReadAllBytes(AccountInfoFile);
                var decrypted = ProtectedData.Unprotect(bytesToDecrypt, null, DataProtectionScope.CurrentUser);

                var accountInfoString = UnicodeEncoding.ASCII.GetString(decrypted);
                return JsonConvert.DeserializeObject<AccountInfo>(accountInfoString);
            }
            catch
            {
                return null;
            }
        }


        public static byte[] GetEntropy()
        {
            return UnicodeEncoding.ASCII.GetBytes("TDInterface");
        }

        public static void ClearAccessTokenContainerFile(string fileName)
        {
            File.Delete(fileName);
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

        public static void CaptureScreen(string ticker)
        {
            try
            {
                //Creating a new Bitmap object with size of entire virtual screen (all screens in one)
                Bitmap captureBitmap = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height, PixelFormat.Format32bppArgb);
                //Creating a Rectangle object to capture entire virtual screen bounds

                Rectangle captureRectangle = SystemInformation.VirtualScreen;

                //Creating a New Graphics Object pointing to bitmap to capture to
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                
                //Copying Image from The Screen
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
                
                //Save the screenshot
                captureBitmap.Save(Path.Combine(ScreenshotPath(ticker), $"{DateTime.Now.ToString("yyyyMMdd-HHmmss")}_{ticker}.png"), ImageFormat.Png);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public static string ScreenshotPath()
        {
            // Check for existence of the OS provided 'Pictures' folder
            string screenshotFolder = "Trade Screenshots";
            string screenshotRootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);


            if (!Directory.Exists(screenshotRootPath))
            {
                // Create folder within application directory
                screenshotRootPath = Directory.GetCurrentDirectory();
            }

            string screenshotFullPath = Path.Combine(screenshotRootPath, screenshotFolder, DateTime.Now.ToString("yyyyMMdd"));

            if (!Directory.Exists(screenshotFullPath))
            {
                Directory.CreateDirectory(screenshotFullPath);
            }

            // Return screenshot path
            return screenshotFullPath;
        }

        public static string ScreenshotPath(string ticker)
        {
            string screenshotFullPathWithTicker = Path.Combine(ScreenshotPath(), ticker);
            Directory.CreateDirectory(screenshotFullPathWithTicker);
            return screenshotFullPathWithTicker;
        }

        public static void SplitTdaConsumerKey(string tdaConsumerKey, out string consumerKey, out string callback)
        {
            consumerKey = tdaConsumerKey;
            callback = "http://localhost";
            if (consumerKey.IndexOf("~") > 0)
            {
                var parts = consumerKey.Split('~');
                consumerKey = parts[0];
                callback = parts[1];
            }
        }

        /// <summary>
        /// Checks GitHub for the latset release and compares it to the current version
        /// </summary>
        /// <returns>
        /// <c>True</c> if there is a newer version available, <c>False</c> otherwise.
        /// </returns>
        public async static Task<bool> IsAppUpdateAvailable()
        {
            try
            {
                Uri requestUri = new Uri("https://api.github.com/repos/jrhurley2/TDInterface-Public/releases/latest");

                using HttpClient client = new HttpClient();

                using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requestUri);
                request.Headers.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36 Edg/110.0.1587.6");

                using HttpResponseMessage response = await client.SendAsync(request);

                var contentJson = await response.Content.ReadAsStringAsync();
                VerifyGitHubAPIResponse(response.StatusCode, contentJson);
                var jsonNode = JsonNode.Parse(contentJson);
                if (jsonNode != null)
                {
                    var tagName = jsonNode["tag_name"];
                    if (tagName != null)
                    {
                        var latestVersion = new Version(jsonNode["tag_name"].ToString());
                        var currentVersion = new Version(Program.GetAppVersion());
                        return latestVersion > currentVersion;
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CheckForAppUpdates: {ex.Message}");
            }
            return false;
        }

        public static void OpenAppOnGitHub()
        {
            openWebUrl(Resources.githubProjectURL);
        }

        public static void OpenAppLatestReleaseOnGitHub()
        {
            openWebUrl(Resources.githubProjectLatestReleaseURL);
        }

        private static void openWebUrl(string url)
        {
            if (!String.IsNullOrEmpty(url))
            {
                Process.Start(new ProcessStartInfo() { FileName = url, UseShellExecute = true });
            }
        }

        private static void VerifyGitHubAPIResponse(HttpStatusCode statusCode, string content)
        {
            switch (statusCode)
            {
                case HttpStatusCode.Forbidden when content.Contains("API rate limit exceeded"):
                    throw new Exception("GitHub API rate limit exceeded.");
                case HttpStatusCode.NotFound when content.Contains("Not Found"):
                    throw new Exception("GitHub Repo not found.");
                default:
                    {
                        if (statusCode != HttpStatusCode.OK) throw new Exception("GitHub API call failed.");
                        break;
                    }
            }
        }

    }
}
