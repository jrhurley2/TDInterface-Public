using Microsoft.Web.WebView2.Core;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TdInterface
{
    public class OAuthLoginForm : Form
    {
        private bool _autoConfirmAmeritrade;
        private IContainer components;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;

        public string Code { get; private set; }

        public OAuthLoginForm(string loginUrl, string title = null, int width = 0, int height = 0)
        {
            OAuthLoginForm oauthLoginForm = this;
            this.InitializeComponent();
            this.Text = title ?? "Login";
            if (loginUrl == null || !loginUrl.StartsWith("https://"))
            {
                this.Close();
            }
            else
            {
                int num1 = width;
                Size minimumSize = this.MinimumSize;
                int width1 = minimumSize.Width;
                if (num1 >= width1)
                    this.Width = width;
                int num2 = height;
                minimumSize = this.MinimumSize;
                int height1 = minimumSize.Height;
                if (num2 >= height1)
                    this.Height = height;
                this.Load += (EventHandler)(async (s, e) =>
                {
                    CoreWebView2Environment async = await CoreWebView2Environment.CreateAsync(); // userDataFolder: Utils.WebViewDataDir);
                    await oauthLoginForm.webView.EnsureCoreWebView2Async(async);
                    oauthLoginForm.webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
                    oauthLoginForm.webView.CoreWebView2.Settings.AreDevToolsEnabled = false;
                    oauthLoginForm.webView.CoreWebView2.Settings.IsStatusBarEnabled = false;
                    oauthLoginForm.webView.CoreWebView2.Navigate(loginUrl);
                });
                this.webView.NavigationCompleted += (EventHandler<CoreWebView2NavigationCompletedEventArgs>)(async (s, e) =>
                {
                    if (oauthLoginForm._autoConfirmAmeritrade)
                        await oauthLoginForm.ProcessAutomatedAmeritradeLogin();
                    else
                        oauthLoginForm.ProcessNormalLogin();
                });
                this.webView.NavigationStarting += (EventHandler<CoreWebView2NavigationStartingEventArgs>)((s, e) => e.Cancel = !e.Uri.StartsWith("http://") && !e.Uri.StartsWith("https://"));
            }
        }

        private void ProcessNormalLogin()
        {
            string str1 = this.webView.Source?.ToString() ?? string.Empty;
            string str2 = str1.Contains("code=") ? "code=" : (str1.Contains("oauth_verifier=") ? "oauth_verifier=" : (string)null);
            if (str2 != null && str1.Contains(str2))
            {
                int startIndex1 = str1.IndexOf(str2) + str2.Length;
                if (startIndex1 <= 4 || startIndex1 >= str1.Length - 1)
                    return;
                this.Code = str1.Substring(startIndex1);
                int startIndex2 = this.Code.IndexOf('&');
                this.Code = startIndex2 == -1 ? this.Code.Trim() : this.Code.Remove(startIndex2).Trim();
                if (string.IsNullOrEmpty(this.Code))
                    return;
                this.Close();
            }
            else
            {
                if (!str1.Contains("error=access_denied"))
                    return;
                this.Close();
            }
        }


        private async Task ProcessAutomatedAmeritradeLogin() => this.ProcessNormalLogin();

        private async Task<string> GetHtml(string selector = null)
        {
            string str;
            if (!string.IsNullOrWhiteSpace(selector))
                str = await this.webView.ExecuteScriptAsync(string.Format("document.querySelector('{0}').outerHTML;", (object)selector));
            else
                str = await this.webView.ExecuteScriptAsync("document.documentElement.outerHTML;");
            return Regex.Unescape(str ?? string.Empty);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(OAuthLoginForm));
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.SuspendLayout();
            this.webView.Name = "webView";
            this.webView.Location = new Point(0, 0);
            this.webView.MinimumSize = new Size(20, 20);
            this.webView.Size = new Size(1200, 630);
            this.webView.Dock = DockStyle.Fill;
            this.webView.TabIndex = 0;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1200, 630);
            this.Controls.Add((Control)this.webView);
            //this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MinimumSize = new Size(800, 600);
            this.Name = nameof(OAuthLoginForm);
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
        }
    }
}
