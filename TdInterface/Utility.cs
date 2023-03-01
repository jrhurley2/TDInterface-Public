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

namespace TdInterface
{
    public class Utility
    {
        private static string TokenFile = "AccessToken.json";
        private static string SettingsFile = "Settings.json";
        private static string AccountInfoFile = "AccountInfo.json";

        public static string AuthToken { get; set; }

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
            return UnicodeEncoding.ASCII.GetBytes("TDInterface");
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
    }
}
