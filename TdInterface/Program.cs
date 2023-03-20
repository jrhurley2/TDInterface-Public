using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;


namespace TdInterface
{
    internal static class Program
    {
        public static string AppVersion
        {
            get
            {
                var versionInfo = Assembly.GetExecutingAssembly().GetName().Version;
                return $"{versionInfo.Major}.{versionInfo.Minor}.{versionInfo.Build}";
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set application configuration
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var masterForm = serviceProvider.GetRequiredService<MasterForm>();
                Application.Run(masterForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MasterForm>();
        }
    }
}
